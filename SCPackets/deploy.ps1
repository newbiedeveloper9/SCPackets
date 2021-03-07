function GetPackageVersion
{
    $PackageVersion = Read-Host "Please enter package version to publish (left empty for "$global:Packages[$global:Packages.Length-1]")"
    if(-not $PackageVersion)
    {
        $PackageVersion = $global:Packages[$global:Packages.Length-1]
    }

    if($global:Packages -notcontains $PackageVersion){
        Write-Host "Given version does not exist in the release folder" -ForegroundColor White -BackgroundColor Red
        $PackageVersion = GetPackageVersion
    }

    Write-Output $PackageVersion
}

$ApiKey = Read-Host "Please enter apikey"

$Pattern = "(?:\d+\.)*\d+(?:\.\d+)?"
[string[]]$global:Packages = Get-ChildItem $PSScriptRoot\bin\Release -Name -File -Include *.nupkg | Select-String -Pattern $Pattern | foreach {$_.Matches.Value}
Write-Host $Packages -Separator "`n" -ForegroundColor DarkGray -BackgroundColor Yellow

$Version = GetPackageVersion
dotnet nuget push $PSScriptRoot\bin\Release\SCPackets.$Version.nupkg --api-key $ApiKey --source https://api.nuget.org/v3/index.json

Write-Host "`nPress any key to continue..."
$Host.UI.RawUI.ReadKey("NoEcho,IncludeKeyDown")