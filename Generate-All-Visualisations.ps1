Set-Location .\src\HuffmanWords.Console\bin\Debug\net6.0
Get-ChildItem "..\..\..\..\HuffmanWords.Tests\Test Files\" | ForEach-Object { .\HuffmanWords.Console.exe visualise -f $_.FullName -o "..\..\..\..\..\visualisations\$($_.BaseName).html" }
Set-Location ..\..\..\..\..\