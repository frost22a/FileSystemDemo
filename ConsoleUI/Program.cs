using System;
using System.IO;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\PROGRAMOWANIE\C#\FileSystemDemo";

            //string[] dirs = Directory.GetDirectories(rootPath);
            //string[] dirs = Directory.GetDirectories(rootPath, "*" , SearchOption.AllDirectories);

            //foreach (var dir in dirs)
            //{
            //    Console.WriteLine(dir);
            //}

            //Console.WriteLine("------");
            //Console.WriteLine("------");


            //var files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);

            //foreach (var file in files)
            //{
            //Console.WriteLine(file);
            //Console.WriteLine(Path.GetFileName(file));
            //Console.WriteLine(Path.GetFileNameWithoutExtension(file));

            //    var info = new FileInfo(file);
            //    Console.WriteLine($"{Path.GetFileName(file)}: {info.Length} bytes");
            //}

            //use:

            //string newPath = @"C:\PROGRAMOWANIE\C#\FileSystemDemo\subfolder\subsubfolder";

            //Directory.CreateDirectory(newPath);

            //bool directoryExist = Directory.Exists(newPath);

            //if (directoryExist)
            //{
            //    Console.WriteLine("exist");
            //}
            //else
            //{
            //    Console.WriteLine("does not exist");
            //}

            string[] files = Directory.GetFiles(rootPath);
            string destinationFolder = @"C:\PROGRAMOWANIE\C#\FileSystemDemo\subfolder\";

            //foreach (string file in files)
            //{
            //    File.Copy(file, $"{ destinationFolder}{Path.GetFileName(file)}", true);
            //}

            for (int i = 0; i < files.Length; i++)
            {
                File.Copy(files[i], $"{destinationFolder}{i}.txt", true);

                //File.Move(files[i], $"{destinationFolder}{i}.txt");
            }
        }
    }
}
