for ($i = 1; $i -le 9; $i++) {
    $inputFile = "be$i.txt"
    $outputFile = "ki$i.txt"

    Get-Content $inputFile | ./C1.exe | Out-File $outputFile
}
