$currentPath = $PSScriptRoot = Split-Path -Parent -Path $MyInvocation.MyCommand.Definition # (Get-Item -Path ".\" -Verbose).FullName
$solutionpath = (get-item $PSScriptRoot ).parent.FullName
$pathexe = "'$solutionpath\packages\FluentMigrator.Tools.1.6.2\tools\AnyCPU\40\Migrate.exe'"
$params = " -connection 'data source=.\SQLEXPRESS01;initial catalog=Testing;Integrated Security=True' -db SQLserver2008 -timeout 600 -target "
$pathdll = "'$PSScriptRoot\bin\Debug\RestaurantInspections.Database.dll'"
$path = $pathexe + $params + $pathdll

clear

write-output($temppath)
write-output($path)
Invoke-Expression "& $path "