echo off
if exist "%SystemRoot%\Microsoft.NET\Framework\v4.0.30319" goto netOld
:DispError
echo 您的机器上没有安装 .net FrameWork 4.0,安装即将终止
pause
goto LastEnd
:netOld
echo 即将卸载本服务，按任意键继续…………
echo off
pause
net stop "JJYService"
%SystemRoot%\Microsoft.NET\Framework\v4.0.30319\installutil /uninstall LHJ.SYNC.WinService.exe
pause
:LastEnd
rem exit
