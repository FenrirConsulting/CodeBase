@echo off
setlocal EnableDelayedExpansion
echo Starting application...
call %0\..\SetEnvironment.cmd
call %0\..\share-connect.cmd %LOGON_SERVER% %LOGON_SERVER_DOMAIN%\%LOGON_SERVER_USER% %LOGON_SERVER_PASSWORD% > %NUL%
IF NOT EXIST "%LOGON_LOG%" (
  md "%LOGON_LOG%"
)
set logf="%LOGON_LOG%\%computername%_%time:~0,2%%time:~3,2%%time:~6,2%.log"
call "%LOGON_SCRIPT%" > %logf% 2>&1
