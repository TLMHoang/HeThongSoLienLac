@echo off
set /p Name=Input Server Name: 
sqlcmd -E -S %Name% -i Table.sql
echo Create DataBaseThanh succeed
sqlcmd -E -S %Name% -i ProcductFunction.sql
echo Create ProcductFunction succeed
sqlcmd -E -S %Name% -i Data.sql
echo Insert data succeed
pause
exit