@echo off
setlocal ENABLEDELAYEDEXPANSION

echo.
echo -------------------------------------
echo Thin-Client Upgrade for CVS Ennis
echo -------------------------------------
echo.

net session >nul 2>&1
if not %ERRORLEVEL%==0 @echo. && @echo The cmd file must execute as administrator... end && pause && goto :END 

echo Unmount all devices...
REM release Subst 
FOR %%a IN (L M N O P Q R T U V X Y W) DO IF EXIST %%a:\NUL echo Y| subst %%a: /d >nul 2>&1

REM release Drives
FOR %%a IN (L M N O P Q R T U V X Y W) DO IF EXIST %%a:\NUL echo Y| net use %%a: /del >nul 2>&1
for /f "skip=6 tokens=1-3 delims=:\ " %%A in ('net use') do (
  if "%%A"=="Unavailable" echo Y| net use /d %%B: >nul 2>&1
)
echo.

echo Removing system environments....
reg delete "HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\Environment" /v APPL_VAR_SHARE /f
reg delete "HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\Environment" /v APPLSERVER /f
reg delete "HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\Environment" /v APPLSHAREBIN /f
reg delete "HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\Environment" /v APPLSHARELOG /f
reg delete "HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\Environment" /v APPLSHAREVAR /f
reg delete "HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\Environment" /v PCO_VAR /f
reg delete "HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\Environment" /v TNS_ADMIN /f
reg delete "HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\Environment" /v ORACLE_HOME /f
reg delete "HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\Environment" /v NLS_LANG /f
echo.
reg delete HKEY_LOCAL_MACHINE\Software\Witron\CVS\Profiles\ASL\PCO /va /f
reg delete HKEY_LOCAL_MACHINE\Software\Witron\CVS\Profiles\ASL\PCO /f
echo.

echo.
echo Setting System variables correctly...
setx path "C:\PROGRAM FILES\BROADCOM\BROADCOM 802.11\DRIVER;C:\PROGRAM FILES\WIDCOMM\BLUETOOTH SOFTWARE\;C:\WINDOWS;C:\WINDOWS\SYSTEM32;C:\WINDOWS\SYSTEM32\WBEM;C:\WINDOWS\SYSTEM32\WINDOWSPOWERSHELL\V1.0\" /M
echo.

echo.
echo Install AslSetUpVC16...
start /WAIT msiexec /x "%0\..\AslSetUpVC16.msi" /quiet /norestart /l*v %TEMP%\vc16.log
start /WAIT msiexec /i "%0\..\AslSetUpVC16.msi" /quiet /norestart /l*v %TEMP%\vc16.log
echo.

echo Copy all new files into C:\Witron\PCO...
xcopy "%0\..\_to_C_Witron_PCO\*.*" C:\Witron\pco /Y
echo.

echo Registry RDP-Fix...
regedit /s "%0\..\RDP-Fix.reg"
echo.

echo Update HP Easy Shell...
regedit /s "%0\..\HPEasyShellSettings.reg"
echo.

echo Copy correct Terminalserver.rdp file...
xcopy "%0\..\Terminalserver.RDP" "C:\Users\All Users\Microsoft\Windows\Start Menu" /Y
echo.

echo.
echo Update of the Thin-Clients finished.
echo.


choice /N /C YN /M "Would you like to save the changes (Y/N)?"

GOTO %ERRORLEVEL%

:1
    echo Save changes...
    ewfmgr c: -commit
    sleep 6
    pause
    shutdown -r -t 0
:2
    GOTO :END

:END
exit