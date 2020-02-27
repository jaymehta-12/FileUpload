using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using FileUpload.Model;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using File = FileUpload.Model.File;

namespace FileUpload.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileUploadController : ControllerBase
    {
        [HttpPost]
        public IActionResult UploadFile( IFormFile File)
        {
            string store = "C:\\Users\\jmehta\\Documents\\Text";

            var file = Request.Form.Files[0];

            var memory = new MemoryStream();

            file.CopyTo(memory);

            System.IO.File.WriteAllBytes(store + "\\" + file.FileName, memory.ToArray());




            return Ok();
           
        }
    }
}