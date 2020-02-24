@echo off
color f0
mode con: cols=50 lines=35
title Unknown Source Team
echo Script use for SQLServer 2019
set /p Name=Input Server Name: 
sqlcmd -E -S %Name% -i Trigger.sql
echo "===================>Waiting<==================="
echo Create ProcductFunction succeed
echo HOAN THANH
echo DataBase by US Team
pause
exit