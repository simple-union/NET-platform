# make
## vars
$MakeBasePath = $PSScriptRoot
$RepoBasePath = $MakeBasePath + "/../"
$SrcBasePath = $RepoBasePath + "src/"
$PublishBasePath = $RepoBasePath + ".publish/"
## build
### recreate publish directory
if (Test-Path -Path $PublishBasePath) {
    Remove-Item $PublishBasePath -Force -Recurse
}
New-Item -ItemType directory -Path $PublishBasePath -Force
### make solution
$BuildStepsArray = @("clean", "restore", "pack")
foreach ($BuildStepsItem in $BuildStepsArray) {
    msbuild /t:$BuildStepsItem `
            /p:PackageOutputPath=$PublishBasePath `
            /p:Configuration=Release `
            /verbosity:minimal `
            $SrcBasePath

    if (-Not $LastExitCode -eq 0) {
        Write-Output "FAILED!"
        exit 1
    }
}
## exit
exit 0
