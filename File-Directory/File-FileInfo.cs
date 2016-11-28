using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Directory
{
    class File_FileInfo
    {
    }

    /// <summary>
    /// 使用FileInfo对单个文件执行多次操作creation->writing->opening->reading.
    /// 1. fi.Create()==>wirte==>fs<==fi.OpenText()==>sr.ReadLine()==>Console.WriteLine(s);
    /// </summary>
    public class MyFileInfo
    {
        public MyFileInfo()
        {
            string path = @"MyTest.txt";
            FileInfo fi = new FileInfo(path);

            // Check for existing file
            if (!fi.Exists)
            {
                // Create the file.
                using (FileStream fs = fi.Create())
                {
                    Byte[] info =
                        new UTF8Encoding(true).GetBytes("This is some text in the file.");

                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                    fs.Close();
                }
            }

            // Open the stream and read it back.
            using (StreamReader sr = fi.OpenText())
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
