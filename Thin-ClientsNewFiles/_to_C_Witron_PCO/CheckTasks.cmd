@echo off
if "%SETUP_SERVER%"=="" goto END
if "%SETUP_SERVER_DOMAIN%"=="" goto END
if "%SETUP_SERVER_USER%"=="" goto END
if "%SETUP_SERVER_PASSWORD%"=="" goto END
if "%CHECKTASKS_SCRIPT%"=="" goto END
echo Checking for Updates...
call %0\..\SetEnvironment.cmd
call %0\..\share-connect.cmd %SETUP_SERVER% %SETUP_SERVER_DOMAIN%\%SETUP_SERVER_USER% %SETUP_SERVER_PASSWORD% > %NUL%
call "%CHECKTASKS_SCRIPT%" %1
:End
