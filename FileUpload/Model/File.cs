using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileUpload.Model
{
    public class File
    {
        public string FileName { get; set; }

        public IFormFile Image  { get; set; }
    }
}
