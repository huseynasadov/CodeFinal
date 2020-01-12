using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.Helpers
{
    public class FileManager
    {
        private readonly  IWebHostEnvironment webHostEnvironment;
        public FileManager(IWebHostEnvironment _webHostEnvironment)
        {
            webHostEnvironment = _webHostEnvironment;
        }
        public  string Upload(IFormFile file, string allowedTypes = "image/png|image/jpeg|image/jpg|image/gif", int maxSize = 2048)
        {
            string UploadPath = Path.Combine(webHostEnvironment.WebRootPath, "images");
            if (file == null)
            {
                string fileName = "noimage.png";
                return fileName;
            }
            if (file.Length / 2048 > maxSize)
            {
                throw new Exception("File size max be 2048kb");
            }
            if (!allowedTypes.Split('|').Contains(file.ContentType))
            {
                throw new Exception("File type is not acceptable");
            }
            string filename = "uploads/"+CreatePath() + "/" + Guid.NewGuid().ToString() + "-" + file.FileName;
            string filePath = Path.Combine(UploadPath, filename);
            FileStream fs = new FileStream(filePath, FileMode.Create);
            file.CopyToAsync(fs);
            fs.Close();

            return filename;
        }
        public  void Delete(string filename)
        {
            string UploadPath = Path.Combine(webHostEnvironment.WebRootPath, "images");
            if (string.IsNullOrEmpty(filename))
            {
                throw new NullReferenceException("Filename cannot be null");
            }


            if (!File.Exists(Path.Combine(UploadPath, filename)))
            {
                throw new Exception("File doesnt exists");
            }


            File.Delete(Path.Combine(UploadPath, filename));
        }
        private  string CreatePath()
        {
            string UploadPath = Path.Combine(webHostEnvironment.WebRootPath, "images");
            DateTime now = DateTime.Now;

            if (!Directory.Exists(Path.Combine(UploadPath, now.Year.ToString())))
            {
                Directory.CreateDirectory(Path.Combine(UploadPath, now.Year.ToString()));
            }

            if (!Directory.Exists(Path.Combine(UploadPath, now.Year.ToString(), now.Month.ToString())))
            {
                Directory.CreateDirectory(Path.Combine(UploadPath, now.Year.ToString(), now.Month.ToString()));
            }

            return now.Year.ToString() + "/" + now.Month.ToString();
        }
    }
}
