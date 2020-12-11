@echo off
setlocal EnableDelayedExpansion
echo Starting application...

SET APP_SERVER=RFL6DPSPW2C
SET APPL_RUNTIME_SHARE=CVS-APP-RT
SET APPL_VAR_SHARE=CVS-APP-VAR
SET APPL_LOG_SHARE=CVS-CLIENT-LOG
SET WS_USER_AUTOLOGON=WCLIENT_USER
SET WS_PASSWORD=WMS.2016
SET CLIENT_WITRON_DIR=%PROGRAMFILES%\Witron
SET LOGON_SERVER=RFL6DPSPW2C
SET LOGON_SERVER_DOMAIN=RFL6WMSDOM
SET LOGON_SCRIPT=\\%LOGON_SERVER%\CVS-APP-RT\atl\runtime\etc\ClientFiles\LogonScript.bat
SET LOGON_LOG=\\%LOGON_SERVER%\CVS-CLIENT-LOG\Client_Startup\
SET LOGON_RUNTIME_SHARE=CVS-APP-RT

SET WS_USER=WCLIENT_USER
SET WS_USER_AUTOLOGON=YES
set RETRIES=987654321

:loopbegin
  echo.
  echo %RETRIES:~-1%. attempt to connect to %LOGON_SERVER%. user %LOGON_SERVER_DOMAIN%\%WM_USER%.
  set RETRIES=%RETRIES:~0,-1%

  @Net Use X: \\%APP_SERVER%\%APPL_RUNTIME_SHARE% /User:%LOGON_SERVER_DOMAIN%\%WS_USER% %WS_PASSWORD% /PERSISTENT:NO
  @Net Use \\%APP_SERVER%\%APPL_RUNTIME_SHARE% /User:%LOGON_SERVER_DOMAIN%\%WS_USER% %WS_PASSWORD% 
  ::%0\..\ScriptHelper.exe EXECUTEENCRYPTED "%NETUSE% %SHARE% /user:%USER% %PASS%"
  
  echo ErrorLevel=%errorlevel%
  if errorlevel 2 goto looperror
  if errorlevel 0 goto success

:looperror
  if "%RETRIES%" == "" goto loopend
  echo Waiting 10 seconds for the next attempt ...
  %SLEEP%
  goto loopbegin

:loopend
  echo Giving up - no connection to %SHARE% could be established.
  goto end

:success
  echo Connection to %SHARE% successfully established.

:end

IF NOT EXIST "%LOGON_LOG%" (
  md "%LOGON_LOG%"
)
set logf="%LOGON_LOG%\%computername%_%time:~0,2%%time:~3,2%%time:~6,2%.log"
call "%LOGON_SCRIPT%" > %logf% 2>&1


:: Pretty sure the below two lines are not needed. They don't show up as being SET in old mapping file.
::CALL %0\..\ScriptHelperToEnv.cmd "QUERYDNSTEXT LOGON_SERVER_USER.WitronClientSetup" LOGON_SERVER_USER
::CALL %0\..\ScriptHelperToEnv.cmd "QUERYDNSTEXT LOGON_SERVER_PASSWORD.WitronClientSetup" LOGON_SERVER_PASSWORD > %NUL%
