echo off
if exist "%SystemRoot%\Microsoft.NET\Framework\v4.0.30319" goto netOld
:DispError
echo ���Ļ�����û�а�װ .net FrameWork 4.0,��װ������ֹ
pause
goto LastEnd
:netOld
echo ����ж�ر����񣬰������������������
echo off
pause
net stop "JJYService"
%SystemRoot%\Microsoft.NET\Framework\v4.0.30319\installutil /uninstall LHJ.SYNC.WinService.exe
pause
:LastEnd
rem exit
