using System;
using System.IO;

string pathfolder = "";
int totalFiles = 0;
int totalDirect = 0;

Console.Write("Dossier: ");
pathfolder = Console.ReadLine();
countFile(pathfolder);

Console.WriteLine($"{pathfolder} {totalFiles} fichiers et {totalDirect} dossiers.");

void countFile(string pathfolder)
{
    string[] direct = Directory.GetDirectories(pathfolder);
    int fileCount = Directory.GetFiles(pathfolder).Length;

    totalFiles += fileCount;
    totalDirect += direct.Length;

    foreach (string subDir in direct)
    {
        countFile(subDir);
    }
}