echo �밴�������ʼ��װ��Ŀ����ϵͳ����. . .
echo.
pause
echo.
echo ����ԭ�з�����. . .
%SystemRoot%\Microsoft.NET\Framework\v4.0.30319\installutil /U LHJ.SYNC.WinService.exe > InstallService.log
echo.
echo ������ϣ���ʼ��װ��̨����. . .
echo.
%SystemRoot%\Microsoft.NET\Framework\v4.0.30319\installutil LHJ.SYNC.WinService.exe > InstallService.log
echo ����װ��ϣ���������. . .
net start JJYService >> InstallService.log
echo.
echo �������������� InstallService.log �в鿴����Ĳ��������
echo.
pause