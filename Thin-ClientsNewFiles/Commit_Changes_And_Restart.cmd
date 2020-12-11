ewfmgr -all -commit

waitfor nul /T 5 2>nul

echo Restart the thin client.
pause
shutdown -r -t 0