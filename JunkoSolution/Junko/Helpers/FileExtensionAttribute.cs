using Junko.DAL;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.Helpers
{
    public class FileExtensionAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //var _db = (JunkoDBContext)validationContext.GetService(typeof(JunkoDBContext));
            var file = value as IFormFile;
            if (file!=null)
            {
                var extension = Path.GetExtension(file.FileName);
                string[] extensions = { "jpg", "jpeg", "png" };
                bool result = extensions.Any(x => extension.EndsWith(x));
                if (!result)
                {
                    return new ValidationResult(GetErrorMessage());
                };
            }

            return ValidationResult.Success;
        }

        private string GetErrorMessage()
        {
            return "Allowed Extensions are jpeg,jpg and png";
        }
    }
}
