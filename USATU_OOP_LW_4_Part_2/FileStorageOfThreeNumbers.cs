using System;
using System.IO;
using System.Text.Json;

namespace USATU_OOP_LW_4_Part_2;

public static class FileStorageOfThreeNumbers
{
    private const string FileName = "ThreeNumbers.txt";

    private class ThreeNumbers
    {
        public int NumA { get; }
        public int NumB { get; }
        public int NumC { get; }

        public ThreeNumbers(int numA, int numB, int numC) => (NumA, NumB, NumC) = (numA, numB, numC);
    }

    public static bool IsFileExists()
    {
        return File.Exists(FileName);
    }

    public static (int NumA, int NumB, int NumC) GetThreeNumbersFromStorage()
    {
        var readText = File.ReadAllText(FileName);
        var threeNumbers = JsonSerializer.Deserialize<ThreeNumbers>(readText);
        return (threeNumbers.NumA, threeNumbers.NumB, threeNumbers.NumC);
    }

    public static void WriteThreeNumbersToStorage(int numA, int numB, int numC)
    {
        var threeNumbers = new ThreeNumbers(numA, numB, numC);
        var threeNumbersString = JsonSerializer.Serialize(threeNumbers) + Environment.NewLine;
        File.WriteAllText(FileName, threeNumbersString);
    }
}