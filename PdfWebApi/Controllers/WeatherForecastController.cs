using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PdfSharpCore;
using PdfSharpCore.Pdf;
using System;
using System.IO;
using TheArtOfDev.HtmlRenderer.PdfSharp;

namespace PdfWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public void Get()
        {
            var document = new PdfDocument();
            var html = "<html><body style='color: black'>Hello World.</body></html>";
            PdfGenerator.AddPdfPages(document, html, PageSize.A4);
            string path = @"C:\\Temp";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            using (MemoryStream ms = new MemoryStream())
            {
                document.Save(path + "\\Test.pdf");
            }
        }
    }
}