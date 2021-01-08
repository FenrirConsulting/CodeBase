@echo off
setlocal EnableDelayedExpansion
echo Starting application...

SET APP_SERVER=RFL6DPSAPW1V
SET APPL_RUNTIME_SHARE=WMS-RT
SET APPL_VAR_SHARE=WMS-VAR
SET APPL_LOG_SHARE=APPL_LOG_SHARE
SET CLIENT_WITRON_DIR=C:\Witron
SET WS_USER_AUTOLOGON=WCLIENT_USER
SET WS_PASSWORD=WMS.2016
SET CLIENT_VAR=WMS-VAR
SET LOGON_SERVER=RFL6DPSAPW1V
SET LOGON_SERVER_DOMAIN=RFL6WMSDOM
SET LOGON_SCRIPT=\\RFL6DPSAPW1V\WMS-RT\atl\runtime\etc\ClientFiles\LogonScript.bat
SET LOGON_LOG=\\RFL6DPSAPW1V\WMS-LOG\Client_Startup\
SET LOGON_RUNTIME_SHARE=WMS-RT
SET WS_USER=WCLIENT_USER
SET WS_USER_AUTOLOGON=YES
set RETRIES=987654321

  net use * /d /y
  for /F "tokens=1 delims=:" %%I in (subst') do subst %%I: /d

  Subst O: C:\Witron\wms\rt
  Subst R: C:\Witron\wms\rt

:loopbegin
  echo.
  echo %RETRIES:~-1%. attempt to connect to %LOGON_SERVER%. user %LOGON_SERVER_DOMAIN%\%WM_USER%.
  set RETRIES=%RETRIES:~0,-1%

  @Net Use X: \\%APP_SERVER%\%APPL_RUNTIME_SHARE% /User:%LOGON_SERVER_DOMAIN%\%WS_USER% %WS_PASSWORD% /PERSISTENT:NO
  echo Mapping X:\ 
  @Net Use V: \\%APP_SERVER%\%CLIENT_VAR% /User:%LOGON_SERVER_DOMAIN%\%WS_USER% %WS_PASSWORD% /PERSISTENT:NO
  echo Mapping V:\
  
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
::call "%LOGON_SCRIPT%" > %logf% 2>&1

PAUSE


:: Pretty sure the below two lines are not needed. They don't show up as being SET in old mapping file.
::CALL %0\..\ScriptHelperToEnv.cmd "QUERYDNSTEXT LOGON_SERVER_USER.WitronClientSetupTest" LOGON_SERVER_USER
::CALL %0\..\ScriptHelperToEnv.cmd "QUERYDNSTEXT LOGON_SERVER_PASSWORD.WitronClientSetupTest" LOGON_SERVER_PASSWORD > %NUL%
