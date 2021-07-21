@echo off
setlocal
:PROMPT
SET /P AREYOUSURE=Reset Startup Settings, are you sure  (Y/[N])?
IF /I "%AREYOUSURE%" NEQ "Y" GOTO END



Del \\rfl6lbsapw1v\WMS-USER\%USERNAME%\info.txt

echo Config Reset

:END
endlocal
