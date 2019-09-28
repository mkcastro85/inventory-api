using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_api.Helpers
{
    public class FileSystemHelper
    {
        public List<string> getAll(IFormFile formFile)
        {
            var result = new List<string>();
            using (var reader = new StreamReader(formFile.OpenReadStream()))
            {
                while (reader.Peek() >= 0)
                    result.Add(reader.ReadLine());

            }
            return result;

        }

        public void createFile(List<string> animals, string name)
        {

            string folderName = "Upload";
            string webRootPath = "./";
            string newPath = Path.Combine(webRootPath, folderName);
            string filePath = newPath + "/" + name + ".txt";
            //Si no existe directorio lo creamos
            if (!Directory.Exists(newPath))
            {
                Directory.CreateDirectory(newPath);
            }
            //Si ya existe archivo lo eliminamos
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            //Procedemos a guardar el archivo con el contenido
            using (StreamWriter file = new StreamWriter(filePath))
            {
                foreach (string line in animals)
                {
                    file.WriteLine(line);
                }
            }

        }

    }
}

