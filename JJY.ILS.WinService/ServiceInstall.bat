echo 请按任意键开始安装项目管理系统服务. . .
echo.
pause
echo.
echo 清理原有服务项. . .
%SystemRoot%\Microsoft.NET\Framework\v4.0.30319\installutil /U LHJ.SYNC.WinService.exe > InstallService.log
echo.
echo 清理完毕，开始安装后台服务. . .
echo.
%SystemRoot%\Microsoft.NET\Framework\v4.0.30319\installutil LHJ.SYNC.WinService.exe > InstallService.log
echo 服务安装完毕，启动服务. . .
net start JJYService >> InstallService.log
echo.
echo 操作结束，请在 InstallService.log 中查看具体的操作结果。
echo.
pause