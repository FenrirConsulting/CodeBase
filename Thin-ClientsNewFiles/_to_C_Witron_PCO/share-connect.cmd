set NETUSE=c:\windows\system32\net.exe use
set SLEEP="c:\Witron\PCO\sleep.exe" 10

set SHARE=\\%1
set USER=%2
set PASS=%3


set RETRIES=987654321


:loopbegin
  echo.
  echo %RETRIES:~-1%. attempt to connect to %SHARE%. user %USER%.
  set RETRIES=%RETRIES:~0,-1%

  :: %NETUSE% %SHARE% /user:%USER% %PASS%  old unencrypted way
  %0\..\ScriptHelper.exe EXECUTEENCRYPTED "%NETUSE% %SHARE% /user:%USER% %PASS%"
  
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
