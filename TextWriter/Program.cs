using System.Globalization;

string[] inputFile = File.ReadAllLines("input.txt");
File.Create("lineLength.txt");

for(int i = 0; i < inputFile.Length; i++)
{
    inputFile[i] = Convert.ToString(inputFile[i].Length);
}

File.WriteAllLines("lineLegths.txt", inputFile);