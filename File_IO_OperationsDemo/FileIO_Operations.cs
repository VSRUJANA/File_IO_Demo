using System;
using System.IO;

namespace File_IO_OperationsDemo
{
    public class FileIO_Operations
    {
        public void FileExists()
        {
            String path = @"C:\Users\sajju2002\source\repos\File_IO_OperationsDemo\File_IO_OperationsDemo\sample.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File exists in {0} path", path);
            }
            else
            {
                Console.WriteLine("File doesn't exist");
            }
            Console.ReadKey();
        }

        public void ReadAllLines()
        {
            String path = @"C:\Users\sajju2002\source\repos\File_IO_OperationsDemo\File_IO_OperationsDemo\sample.txt";
            if (File.Exists(path))
            {
                string[] lines;
                //Opens a text file, reads all lines of the file, and then closes the file.
                lines = File.ReadAllLines(path);
                Console.WriteLine("Printing first 2 lines using ReadAllLines method");
                Console.WriteLine(lines[0]);
                Console.WriteLine(lines[1]);
            }
            else
            {
                Console.WriteLine("File doesn't exist");
            }
            Console.ReadKey();
        }

        public void ReadAllText()
        {
            String path = @"C:\Users\sajju2002\source\repos\File_IO_OperationsDemo\File_IO_OperationsDemo\sample.txt";
            if (File.Exists(path))
            {
                string lines;
                //Opens a text file, reads all text in the file, and then closes the file.
                lines = File.ReadAllText(path);
                Console.WriteLine("Printing first 4 text using ReadAllText method");
                Console.WriteLine(lines[0]);
                Console.WriteLine(lines[1]);
                Console.WriteLine(lines[2]);
                Console.WriteLine(lines[3]);
            }
            else
            {
                Console.WriteLine("File doesn't exist");
            }
            Console.ReadKey();
        }

        public void CopyFile()
        {
            String path = @"C:\Users\sajju2002\source\repos\File_IO_OperationsDemo\File_IO_OperationsDemo\sample.txt";
            String newPath = @"C:\Users\sajju2002\source\repos\File_IO_OperationsDemo\File_IO_OperationsDemo\sampleDuplicate.txt";
            if (File.Exists(path))
            {
                File.Copy(path, newPath);
                Console.WriteLine("File copied successfully to {0}", newPath);
            }
            else
            {
                Console.WriteLine("File doesn't exist");
            }
            Console.ReadKey();
        }

        public void DeleteFile()
        {
            String newPath = @"C:\Users\sajju2002\source\repos\File_IO_OperationsDemo\File_IO_OperationsDemo\sampleDuplicate.txt";
            if (File.Exists(newPath))
            {
                File.Delete(newPath);
                Console.WriteLine("File in path {0} deleted Successfully", newPath);
            }
            else
            {
                Console.WriteLine("File doesnt exist");
            }
            Console.ReadKey();
        }

        public void ReadFileFromStreamReader()
        {
            String path = @"C:\Users\sajju2002\source\repos\File_IO_OperationsDemo\File_IO_OperationsDemo\sample.txt";
            if (File.Exists(path))
            {
                //StreamReader is unmanaged code. So, its GC is not taken care by CLR. using keyword makes sure that Once the use of streamReader is completed it will make sure that it gets disposed
                using (StreamReader streamReader = File.OpenText(path))
                {
                    String fileData = "";
                    while ((fileData = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(fileData);
                    }
                }
            }
            else
            {
                Console.WriteLine("File doesn't exist");
            }
            Console.ReadKey();
        }

        public void WriteFileUsingStreamWriter()
        {
            String path = @"C:\Users\sajju2002\source\repos\File_IO_OperationsDemo\File_IO_OperationsDemo\sample.txt";
            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("\nThis is the line added using StreamWriter");
                sr.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
            Console.ReadKey();
        }
    }
}
