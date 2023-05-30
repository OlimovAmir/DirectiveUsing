using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirectiveUsing
{
    internal class FileManager
    {
        static void Main(string[] args)
        {
                string ReadFromFile = "TEST data";
               
                WriteToFile(ReadFromFile);
          
        }

        static void WriteToFile(string path)
        {
            // Создание файла
            using(FileStream fs = new FileStream("list4.txt", FileMode.Create))
            {
                // Запись в файл

                byte[] bytes = Encoding.UTF8.GetBytes(path);
                fs.Write(bytes, 0, bytes.Length);

                // Чтение из файла
                fs.Seek(0, SeekOrigin.Begin);
                byte[] buffer = new byte[1024];
                int bytesRead = fs.Read(buffer, 0, buffer.Length);
                string result = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                Console.WriteLine(result);
                Console.WriteLine();
                Console.ReadKey();
                // Закрытие файла
                fs.Close();
            }

            
        }

        
        
    }

    
}
