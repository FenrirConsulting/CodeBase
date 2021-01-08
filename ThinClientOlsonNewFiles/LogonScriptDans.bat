@ECHO ON
prompt $T$_
setlocal enabledelayedexpansion

::#########################################################################################
::# Set Environment                                                                       #
::#########################################################################################
SET APP_SERVER=RFL6DPSPW2C
SET APPL_RUNTIME_SHARE=CVS-APP-RT
SET APPL_VAR_SHARE=CVS-APP-VAR
SET APPL_LOG_SHARE=CVS-CLIENT-LOG
::=========================================================================================

set APPLSERVER=%APP_SERVER%
set APPLSHAREBIN=\\%APP_SERVER%\%APPL_RUNTIME_SHARE%
set APPLSHARELOG=\\%APP_SERVER%\%APPL_LOG_SHARE%
set APPLSHAREVAR=\\%APP_SERVER%\%APPL_VAR_SHARE%
set PCO_VAR=\\%APP_SERVER%\%APPL_VAR_SHARE%\asl\var\opt\pco\

::#########################################################################################
::# Set Menu directory                                                                    #
::#########################################################################################
set menudir=\\%APP_SERVER%\%APPL_RUNTIME_SHARE%\atl\runtime\etc\clientFiles
::=========================================================================================


::#########################################################################################
::# Set path variables                                                                    #
::#########################################################################################
set path=C:\PROGRAM FILES\BROADCOM\BROADCOM 802.11\DRIVER;C:\PROGRAM FILES\WIDCOMM\BLUETOOTH SOFTWARE\;C:\WINDOWS;C:\WINDOWS\SYSTEM32;C:\WINDOWS\SYSTEM32\WBEM;C:\WINDOWS\SYSTEM32\WINDOWSPOWERSHELL\V1.0\
set path=%PATH%;O:\asl\runtime\bin
set path=%PATH%;O:\asl\runtime\shlib
set path=%PATH%;O:\asl\runtime\system
set path=%PATH%;R:\abl\runtime\bin
set path=%PATH%;R:\abl\runtime\shlib
set path=%PATH%;R:\atl\runtime\bin
set path=%PATH%;R:\atl\runtime\shlib
set path=%PATH%;C:\OracleInstantClient
set path=%PATH%;\\%APP_SERVER%\%APPL_RUNTIME_SHARE%\asl\runtime\bin
set path=%PATH%;\\%APP_SERVER%\%APPL_RUNTIME_SHARE%\asl\runtime\shlib
set path=%PATH%;\\%APP_SERVER%\%APPL_RUNTIME_SHARE%\asl\runtime\system
set path=%PATH%;\\%APP_SERVER%\%APPL_RUNTIME_SHARE%\abl\runtime\bin
set path=%PATH%;\\%APP_SERVER%\%APPL_RUNTIME_SHARE%\abl\runtime\shlib
set path=%PATH%;\\%APP_SERVER%\%APPL_RUNTIME_SHARE%\atl\runtime\bin
set path=%PATH%;\\%APP_SERVER%\%APPL_RUNTIME_SHARE%\atl\runtime\shlib
set path=%PATH%;%menudir%
setx path "%PATH%"

setx APPL_VAR_SHARE "%APPL_VAR_SHARE%"
setx APPLSERVER "%APPLSERVER%"
setx APPLSHAREBIN "%APPLSHAREBIN%"
setx APPLSHARELOG "%APPLSHARELOG%"
setx APPLSHAREVAR "%APPLSHAREVAR%"
setx PCO_VAR "%PCO_VAR%"
::=========================================================================================

::#########################################################################################
::# OracleInstantClient                                                                   #
::#########################################################################################
set TNS_ADMIN=C:\OracleInstantClient 
set ORACLE_HOME=C:\OracleInstantClient
set NLS_LANG=AMERICAN_AMERICA.WE8MSWIN1252

::#########################################################################################
::# Set pco_var                                                                           #
::#########################################################################################
::PCO settings moved form configTemplate to logonscript
::for online switching of application servers
  ::set PCO_VAR=%menudir%\
  set PCO_VAR=\\%APP_SERVER%\%APPL_VAR_SHARE%\asl\var\opt\pco\
::=========================================================================================  


::#########################################################################################
::# Set the tool to start an executeable without a window                                 #
::#########################################################################################
  set STARTHIDDEN=call "%MENUDIR%\StartHidden.bat"
::=========================================================================================


::#########################################################################################
::# Set screen resolution                                                                 #
::#########################################################################################
  ::needed for driver to initialize
  %menudir%\sleep 1

  ::default resolution is 1280x1024
  %menudir%\resswitch.exe -width:1280 -height:1024
  
  ::HEMA repack needs 1024x768
  echo %Computername% | %0\..\find /I "PCREPACK"  && %menudir%\resswitch.exe -width:1024 -height:768

  :: new way autodetect optimal screen resolution currently only works for windows 7 clients
  ::cscript.exe "%MENUDIR%\setResolution.vbs"
::=========================================================================================


::#########################################################################################
::# Disable the Task Manager for the Thin-Client                                          #
::#########################################################################################
if /I "%USERNAME%" NEQ "Administrator" (
    REG add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\System /v DisableTaskMgr /t REG_DWORD /d 1 /f
    REG add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\System /v DisableLockWorkstation /t REG_DWORD /d 1 /f
    REG add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\System /v DisableChangePassword /t REG_DWORD /d 1 /f
)


::#########################################################################################
::# Synchronize system time with APP_SERVER                                               #
::#########################################################################################
  :: now the wcient_user has the permission to use the 'net time' command. 
  :: Much easier than before.
  net time \\%APP_SERVER% /set /yes
::=========================================================================================

::#########################################################################################
::# Subst local devices                                                                   #
::#########################################################################################
net use H: /del /yes
net use X: /del /yes
net use V: /del /yes

subst H: C:\Witron
subst O: C:\Witron\wms\rt
subst R: C:\Witron\wms\rt

::#########################################################################################
::# Map Net drives                                                                        #
::#########################################################################################

net use X: \\%APP_SERVER%\%APPL_RUNTIME_SHARE%
Net Use V: \\%APP_SERVER%\%APPL_VAR_SHARE%

::#########################################################################################
::# Start the application launcher                                                        #
::#########################################################################################
  %menudir%\reg query "HKLM\software\microsoft\windows NT\currentVersion\winlogon" /v Shell
  for /F "skip=4 tokens=3" %%i in ('%menudir%\reg query "HKLM\software\microsoft\windows NT\currentVersion\winlogon" /v Shell') do set RegShell=%%i
  
  prompt $P^>
  ::if /I "%USERNAME%"=="Administrator" (
  ::  %menudir%\reg add "HKLM\software\microsoft\windows NT\currentVersion\winlogon" /f /v Shell /t REG_SZ /d Explorer.exe
  ::  start Explorer.exe
  ::  sleep 2
  ::  %menudir%\reg add "HKLM\software\microsoft\windows NT\currentVersion\winlogon" /f /v Shell /t REG_SZ /d !Regshell!
  ::  start "menu" %menudir%\wstartmenu.exe %menudir%\Admin_conf.smu
  ::) else (
  ::  start "menu" %menudir%\wstartmenu.exe %menudir%\User_conf.smu
  ::)
::=========================================================================================


::#########################################################################################
::# Set the desktop background                                                            #
::#########################################################################################
  cscript.exe /nologo "%MENUDIR%\setDesktopBackground.vbs" Company.bmp
  :: this call was moved from thr vbscipt to here and need "start" to run async
  :: otherwise wallpaper is not displayed on some WIN 7 PCs
  %menudir%\sleep 2
  start RUNDLL32.EXE user32.dll,UpdatePerUserSystemParameters
::=========================================================================================

::#########################################################################################
::# Autostart application                                                                 #
::#########################################################################################
  echo %Computername% | %0\..\find /I "DPSWS"  && GOTO DPSPICKWS
  echo %Computername% | %0\..\find /I "PTLZOC"  && GOTO PTLZOC
  echo %Computername% | %0\..\find /I "PTLLOGIN"  && GOTO PTLLOGIN
  
  ::FOR TESTING ONLY #################################################################################
  echo %Computername% | %0\..\find /I "TEST-NEW"  && set COMPUTERNAME=DPS_WS40 && GOTO DPSPICKWS
  ::echo %Computername% | %0\..\find /I "TEST-WIN7" && set COMPUTERNAME=DPS_WS99 && GOTO DPSPICKWS
  ::##################################################################################################

::default
GOTO START-TS


 ::####################################################################################################################################
  :DPSPICKWS
    echo [...starting Picking Workstation]

    
    :: for AMTI to find Pictures
    set AXL_SUBPROJECT=DPS
    set DDSP_VAR=\\%APP_SERVER%\%APPL_VAR_SHARE%\abl\var\opt\dps\DPS\DDSP\

    :: determine the WS Number
    set WSNR=%COMPUTERNAME:~-3%
	  :: DLM below for TESTING ONLY !!!
    ::set WSNR=140
    :: Only Ws 36-40 and 86-92 have a DCC
    %STARTHIDDEN% \\%APP_SERVER%\%APPL_RUNTIME_SHARE%\abl\runtime\bin\ dcc_srv.exe %WSNR%
    
    :: All have AMTIGUI
    ::amtiguimfc_start.cmd
    start /MAX %APPLSHAREBIN%\asl\runtime\bin\amtiguimfc_release.exe -h %APPLSERVER% -p 12%WSNR% -o2 -o4
  GOTO END

  ::####################################################################################################################################
  :PTLZOC
    echo [...starting PTL ZOC]
    set AXL_SUBPROJECT=PTL
    
    set WSNR=%COMPUTERNAME:~6,3%    
    %STARTHIDDEN% \\%APP_SERVER%\%APPL_RUNTIME_SHARE%\abl\runtime\bin\ dcc_srv.exe %WSNR%
  GOTO END
  
  ::####################################################################################################################################
  :PTLLOGIN
    echo [...starting PTL LOGIN]
    set AXL_SUBPROJECT=PTL    
    start amtiguistarter.exe
  GOTO END


  ::####################################################################################################################################
  :START-TS
 ::   start \\%APP_SERVER%\%APPL_RUNTIME_SHARE%\atl\runtime\etc\ClientFiles\AutoLogon.cmd
  GOTO END
    


:END