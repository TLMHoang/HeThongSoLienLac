@echo off
color f0
mode con: cols=50 lines=35
title Unknown Source Team
echo Script use for SQLServer 2019
set /p Name=Input Server Name: 
sqlcmd -E -S %Name% -i Table.sql
echo "===================>Waiting<==================="
echo Create DataBaseThanh succeed
sqlcmd -E -S %Name% -i ProcedureSelect.sql
echo "===================>Waiting<==================="
echo Create ProcedureSelect succeed
sqlcmd -E -S %Name% -i ProcedureCreate.sql
echo "===================>Waiting<==================="
echo Create ProcedureCreate succeed
sqlcmd -E -S %Name% -i ProcedureDelete.sql
echo "===================>Waiting<==================="
echo Create ProcedureDelete succeed
sqlcmd -E -S %Name% -i ProcedureUpdate.sql
echo "===================>Waiting<==================="
echo Create ProcedureUpdate succeed
sqlcmd -E -S %Name% -i ProcedureFunction.sql
echo "===================>Waiting<==================="
echo Create ProcductFunction succeed
sqlcmd -E -S %Name% -i Trigger.sql
echo "===================>Waiting<==================="
echo Create ProcductFunction succeed
sqlcmd -E -S %Name% -i Data.sql
echo "===================>Waiting<==================="
echo Insert data succeed
echo HOAN THANH
echo DataBase by US Team
pause
exit