### Asp.Net Core: Generate PDF from HTML

Install package [Polybioz.HtmlRenderer.PdfSharp.Core](https://www.nuget.org/packages/Polybioz.HtmlRenderer.PdfSharp.Core/ "Polybioz.HtmlRenderer.PdfSharp.Core") from Nuget.

###### Basic Usage

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
