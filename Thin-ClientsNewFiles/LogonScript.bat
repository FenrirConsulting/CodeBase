@ECHO ON
prompt $T$_
setlocal enabledelayedexpansion

::#########################################################################################
::# Set Environment                                                                       #
::#########################################################################################
SET APP_SERVER=RFL6DPSAPW1V
SET APPL_RUNTIME_SHARE=WMS-RT
SET APPL_VAR_SHARE=WMS-VAR
SET APPL_LOG_SHARE=WMS-LOG
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
set path=%PATH%;\\%APP_SERVER%\%APPL_RUNTIME_SHARE%\asl\runtime\bin
set path=%PATH%;\\%APP_SERVER%\%APPL_RUNTIME_SHARE%\asl\runtime\shlib
set path=%PATH%;\\%APP_SERVER%\%APPL_RUNTIME_SHARE%\asl\runtime\system
set path=%PATH%;\\%APP_SERVER%\%APPL_RUNTIME_SHARE%\abl\runtime\bin
set path=%PATH%;\\%APP_SERVER%\%APPL_RUNTIME_SHARE%\abl\runtime\shlib
set path=%PATH%;\\%APP_SERVER%\%APPL_RUNTIME_SHARE%\atl\runtime\bin
set path=%PATH%;\\%APP_SERVER%\%APPL_RUNTIME_SHARE%\atl\runtime\shlib
::MUschold: 18.11.2020: vcredist_x86 content needed for windows 7 client to make executable MSDEV 2015 or newer build applications
set path=%PATH%;\\%APP_SERVER%\%APPL_RUNTIME_SHARE%\atl\vcredist_x86\
set path=%PATH%;\\%APP_SERVER%\OracleInstantClient
set path=%PATH%;%menudir%
setx path "%PATH%"

setx APPL_VAR_SHARE "%APPL_VAR_SHARE%"
setx APPLSERVER "%APPLSERVER%"
setx APPLSHAREBIN "%APPLSHAREBIN%"
setx APPLSHARELOG "%APPLSHARELOG%"
setx APPLSHAREVAR "%APPLSHAREVAR%"
setx PCO_VAR %PCO_VAR%
::=========================================================================================

::#########################################################################################
::# OracleInstantClient                                                                   #
::#########################################################################################
set TNS_ADMIN=\\%APP_SERVER%\OracleInstantClient
set ORACLE_HOME=\\%APP_SERVER%\OracleInstantClient
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

cmdkey /generic:ts-cluster.RFL6WMSDOM.local /rfl6wmsdom /user:rfl6wmsdom\WCLIENT_USER /pass:WMS.2016
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
    copy /Y \\%APP_SERVER%\%APPL_RUNTIME_SHARE%\abl\runtime\bin\dcc_srv.exe %TEMP%
	copy /Y \\%APP_SERVER%\%APPL_RUNTIME_SHARE%\asl\runtime\bin\amtiguimfc.exe %TEMP%
	
	cd /d %TEMP%
	
    C:\Witron\PCO\starthidden.exe %TEMP%\dcc_srv.exe %WSNR%
	
    :: All have AMTIGUI
    ::amtiguimfc_start.cmd
	start /MAX %TEMP%\amtiguimfc.exe -h %APP_SERVER% -p 12%WSNR% -o2 -o4
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
::    start \\%APP_SERVER%\%APPL_RUNTIME_SHARE%\atl\runtime\etc\ClientFiles\AutoLogon.cmd
  GOTO END
    


:END