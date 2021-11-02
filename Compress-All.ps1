Get-ChildItem ".\src\HuffmanWords.Tests\Test Files" | ForEach-Object { 
    Write-Host ""
    .\src\HuffmanWords.Console\bin\Release\net6.0\HuffmanWords.Console.exe compress -f $_.FullName
}
Write-Host ""
    