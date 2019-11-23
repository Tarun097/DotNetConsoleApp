using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MyProgramsLib
{
    public class LargestFiles
    {
        public void PrintTopFiveLargestFiles(string dirpath)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(dirpath);
            var fileInfoArray = dirInfo.GetFiles();

            //Sorts array in-place
            Array.Sort(fileInfoArray, new FileInfoComparer());

            foreach (var fileInfo in fileInfoArray.Take(5))
            {
                Console.WriteLine($"{fileInfo.Name, -20} : {fileInfo.Length, 10:N0}");
            }

        }

        public void PrintTopFiveLargestFilesuisngLinq(string dirPath) 
        {
            DirectoryInfo dirInfo = new DirectoryInfo(dirPath);
            //var sortedFileInfo = dirInfo.GetFiles().OrderByDescending(fileInfo => fileInfo.Length);

            var sortedFileInfo = from file in new DirectoryInfo(dirPath).GetFiles()
                                 orderby file.Length descending
                                 select file;

            foreach(var fileInfo in sortedFileInfo.Take(5)) 
            {
                Console.WriteLine($"{fileInfo.Name, -20} : {fileInfo.Length, 10:N0}");
            }
        }

        public class FileInfoComparer : IComparer<FileInfo>
        {
            public int Compare(FileInfo x, FileInfo y)
            {
                return y.Length.CompareTo(x.Length);
            }
        }

    }
}
