::!!!!! Never use setlocal in this script !!!!!!!
::%1 Scripthelper Command
::%2 Environment variable to set
@echo Command : %1 
@echo Env name: %2
@echo Env val : !%2!

::first check if DNS returns error because the FOR statemant modifies the %errorlevel%
@%0\..\ScriptHelper.exe %~1
@if not %errorlevel% == 0 goto Error

@FOR /F "delims=," %%A IN ('%0\..\ScriptHelper.exe %~1') DO @SET %2=%%A
@GOTO END

:Error
  @echo DNS request failed with error %errorlevel%
  
:End
  @echo.
  @echo Env val : %2=!%2!

@exit /B %errorlevel%

