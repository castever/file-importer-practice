Framework '4.0'

properties {
    $name = "FileImporter"
    $birthYear = 2015
    $company = "Chad Stever"
    $configuration = 'Release'
    $src = resolve-path '.\src'
    $projects = @(gci $src -rec -filter *.csproj)

    $build = if ($env:build_number -ne $NULL) { $env:build_number } else { '0' }
    $version = [IO.File]::ReadAllText('.\VERSION.txt') + '.' + $build
}

task default -depends Test

task Test -depends Compile {
    $testRunners = @(gci $src\packages -rec -filter Fixie.Console.exe)

    if ($testRunners.Length -ne 1)
    {
        throw "Expected to find 1 Fixie.Console.exe, but found $($testRunners.Length)."
    }

    foreach ($project in $projects)
    {
        $projectName = [System.IO.Path]::GetFileNameWithoutExtension($project)

        if ($projectName.EndsWith("Tests"))
        {
            $testRunner = $testRunners[0].FullName
            $testAssembly = "$($project.Directory)\bin\$configuration\$projectName.dll"
            exec { & $testRunner $testAssembly }
        }
    }
}

task Compile -depends AssemblyInfo {
  exec { msbuild /t:clean /v:q /nologo /p:Configuration=$configuration /p:VisualStudioVersion=12.0 $src\$name.sln }
  exec { msbuild /t:build /v:q /nologo /p:Configuration=$configuration /p:VisualStudioVersion=12.0 $src\$name.sln }
}

task AssemblyInfo {
    $copyright = get-copyright

    foreach ($project in $projects) {
        $projectName = [System.IO.Path]::GetFileNameWithoutExtension($project)

        regenerate-file "$($project.DirectoryName)\Properties\AssemblyInfo.cs" @"
using System.Reflection;
using System.Runtime.InteropServices;

[assembly: ComVisible(false)]
[assembly: AssemblyProduct("$name")]
[assembly: AssemblyTitle("$projectName")]
[assembly: AssemblyVersion("$version")]
[assembly: AssemblyFileVersion("$version")]
[assembly: AssemblyCopyright("$copyright")]
[assembly: AssemblyCompany("$company")]
[assembly: AssemblyConfiguration("$configuration")]
"@
    }
}

function get-copyright {
    $date = Get-Date
    $year = $date.Year
    $copyrightSpan = if ($year -eq $birthYear) { $year } else { "$birthYear-$year" }
    return "Copyright © $copyrightSpan $maintainers"
}

function regenerate-file($path, $newContent) {
    $oldContent = [IO.File]::ReadAllText($path)

    if ($newContent -ne $oldContent) {
        $relativePath = Resolve-Path -Relative $path
        write-host "Generating $relativePath"
        [System.IO.File]::WriteAllText($path, $newContent, [System.Text.Encoding]::UTF8)
    }
}