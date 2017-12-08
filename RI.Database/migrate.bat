echo .
echo -------------------------------------------------------------------------------

SET migexepath=\packages\FluentMigrator.Tools.1.6.2\tools\AnyCPU\40\Migrate.exe
SET dllpath=\RI.Database\bin\Debug\RI.Database.dll
for %%A in ("%~dp0\..") do set rootpath=%%~fA

echo %0
echo %rootpath%%migexepath%
echo %rootpath%%dllpath%

echo -------------------------------------------------------------------------------
echo .

"%rootpath%%migexepath%" /connection "data source=.\SQLEXPRESS;initial catalog=Testing;Integrated Security=True" /db SQLserver2008 /timeout 600 /target "%rootpath%%dllpath%"

rem  "C:\Users\RConnolly\Google Drive\dev\_sync-dev\Box Sync\RestaurantInspections\packages\FluentMigrator.Tools.1.6.2\tools\AnyCPU\40\Migrate.exe" --connection "data source=.\SQLEXPRESS;initial catalog=Testing;Integrated Security=True" --db SQLserver2008 --timeout 600 --target "C:\Users\RConnolly\Google Drive\dev\_sync-dev\Box Sync\RestaurantInspections\RI.Database\bin\Debug\RI.Database.dll"
