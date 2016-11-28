using System;
using System.IO;

namespace File_Directory
{
    class FileSystemInfoCase
    {
        public FileSystemInfoCase(string path)
        {
            //  Loop through all the immediate subdirectories of C.
            foreach (string entry in Directory.GetDirectories(path,"*.*",SearchOption.AllDirectories))
            {
                DisplayFileSystemInfoAttributes(new DirectoryInfo(entry));
            }
            //  Loop through all the files in C.
            foreach (string entry in Directory.GetFiles(path))
            {
                DisplayFileSystemInfoAttributes(new FileInfo(entry));
            }
        }

        private void DisplayFileSystemInfoAttributes(FileSystemInfo fsi)
        {
            //  Assume that this entry is a file.
            string entryType = "File";

            // Determine if entry is really a directory
            if ((fsi.Attributes & FileAttributes.Directory) == FileAttributes.Directory)
            {
                entryType = "Directory";
            }
            //  Show this entry's type, name, and creation date.
            Console.WriteLine("{0} entry {1} was created on {2:D}", entryType, fsi.FullName, fsi.CreationTime);
        }
    }
}
