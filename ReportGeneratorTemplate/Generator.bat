
FOR /L %%A IN (1,1,200) DO (
  start "Overview Generator" /d \\Rfl6dpsapw1v\wms-rt\ISShare\Applications\PerfBoards\ReportGenerator\ "\\Rfl6dpsapw1v\wms-rt\ISShare\Applications\PerfBoards\ReportGenerator\OverviewReportGenerator.exe"  //Start program, with title and program path 
  timeout /t 3600
)