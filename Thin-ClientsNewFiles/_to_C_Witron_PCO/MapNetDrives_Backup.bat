::SetEnvironments
@Echo Setting Environments.
@SET APP_SERVER=RFL6DPSPW2C
@SET APPL_RUNTIME_SHARE=CVS-CLIENT-RT
@SET APPL_VAR_SHARE=CVS-APP-VAR
@SET APPL_LOG_SHARE=CVS-CLIENT-LOG
@SET WS_USER_AUTOLOGON=YES
@SET WS_USER=WCLIENT_USER
@SET WS_PASSWORD=WMS.2016
@SET CLIENT_VAR=CVS-CLIENT-VAR
@SET CLIENT_WITRON_DIR=%PROGRAMFILES%\Witron
@SET LOGON_SERVER_DOMAIN=RFL6WMSDOM
@SET LOGON_SCRIPT=\\%%LOGON_SERVER%%\CVS-APP-RT\atl\runtime\etc\ClientFiles\LogonScript.bat
@SET LOGON_LOG=\\%%LOGON_SERVER%%\CVS-CLIENT-LOG\Client_Startup\
@Echo Completed setting Environments.

REM for /F "skip=6 tokens=1,2 delims=: " %%I in ('%NETUSE%') do (
REM   if not "%%J"=="command" if not "%%I"=="Disconnected" echo n | net use /d %%J: 
REM )
REM for /F "skip=6 tokens=1,2 delims= " %%I in ('%NETUSE%') do (
REM if not "%%J"=="command" if not "%%I"=="Disconnected" echo n | net use /d %%J 
REM )

net use * /d /y

for /F "tokens=1 delims=:" %%I in ('subst') do subst %%I: /d                   

@Net Use X: \\%APP_SERVER%\%APPL_RUNTIME_SHARE% /User:%LOGON_SERVER_DOMAIN%\%WS_USER% %WS_PASSWORD% /PERSISTENT:NO
::@Net Use \\%APP_SERVER%\%APPL_RUNTIME_SHARE% /User:%LOGON_SERVER_DOMAIN%\%WS_USER% %WS_PASSWORD% 

@Net Use V: \\%APP_SERVER%\%CLIENT_VAR% /User:%LOGON_SERVER_DOMAIN%\%WS_USER% %WS_PASSWORD% /PERSISTENT:NO
::@Net Use \\%APP_SERVER%\%CLIENT_VAR% /User:%LOGON_SERVER_DOMAIN%\%WS_USER% %WS_PASSWORD% 

Subst O: C:\Witron\wms\rt
Subst R: C:\Witron\wms\rt

::#########################################################################################
::# Autostart application                                                                 #
::#########################################################################################
  echo %Computername% | %0\..\find /I "PCDPSWS"  && GOTO DPSPICKWS
  echo %Computername% | %0\..\find /I "PTLZOC"  && GOTO PTLZOC
  echo %Computername% | %0\..\find /I "PTLLOGIN"  && GOTO PTLLOGIN

::default
GOTO END

 ::####################################################################################################################################
  :DPSPICKWS
    echo [...starting Picking Workstation]
    :: for AMTI to find Pictures
    set AXL_SUBPROJECT=DPS
    set DDSP_VAR=\\%APP_SERVER%\%APPL_VAR_SHARE%\abl\var\opt\dps\DPS\DDSP\

    :: determine the WS Number
    set WSNR=%COMPUTERNAME:~7,3%
    ::%STARTHIDDEN% \\%APP_SERVER%\%APPL_RUNTIME_SHARE%\abl\runtime\bin\dcc_srv.exe %WSNR%
	::\\RFL6DPSPW2C\CVS-CLIENT-RT\abl\runtime\bin\dcc_srv.exe 251
	::\\%APP_SERVER%\%APPL_RUNTIME_SHARE%\abl\runtime\bin\dcc_srv.exe %WSNR%
    C:\Witron\PCO\starthidden.exe \\RFL6DPSPW2C\CVS-CLIENT-RT\abl\runtime\bin\dcc_srv.exe %WSNR%
    :: All have AMTIGUI
    X:\atl\runtime\bin\amtiguimfc_start.cmd
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

:END