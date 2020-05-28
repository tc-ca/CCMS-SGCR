using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRCMS.Utility
{
    public static class FileUploadHelper
    {
        public static async Task<string> ReadAsBase64StringAsync(this IFormFile file, ModelStateDictionary modelState, long sizeLimit)
        {
            
            if (file.Length > 0)
            {
                using (var ms = new MemoryStream())
                {
                    await file.CopyToAsync(ms);

                    if (ms.Length == 0)
                    {
                        modelState.AddModelError("File", "The file is empty.");
                    }
                    else if (ms.Length > sizeLimit)
                    {
                        var megabyteSizeLimit = sizeLimit / 1048576;
                        modelState.AddModelError("File",
                        $"The file exceeds {megabyteSizeLimit:N1} MB.");
                    }
                    //else if (!IsValidFileExtensionAndSignature(
                    //    contentDisposition.FileName.Value, memoryStream,
                    //    permittedExtensions))
                    //{
                    //    modelState.AddModelError("File",
                    //        "The file type isn't permitted or the file's " +
                    //        "signature doesn't match the file's extension.");
                    //}
                    else
                    {
                        var fileBytes = ms.ToArray();
                        string s = Convert.ToBase64String(fileBytes);
                        return s;
                    }
                }
            }
            return null;
        }
    }
}
