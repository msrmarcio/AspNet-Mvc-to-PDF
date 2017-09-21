using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace POC.PDF.WEB.Domain
{
    public class ManagerPdf
    {
        
        System.Drawing.Image image;

        public ManagerPdf()
        {
            string pathImage = @"c:\Users\supor\Documents\Visual Studio 2015\Projects\POC.PDF.WEB\POC.PDF.WEB\Content\nwfM3ii.jpg.png";
            image = System.Drawing.Image.FromFile(pathImage);
        }

        public void gerarPdf()
        {
            Document doc = new Document(PageSize.A4);
            PdfWriter.GetInstance(doc, new FileStream(@"c:\Users\supor\Documents\image.pdf", FileMode.Create));
            doc.Open();
            iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(image, System.Drawing.Imaging.ImageFormat.Jpeg);
            doc.Add(pdfImage);
            doc.Close();

            // abre e le documento pdf
            ReadDocumentPdf();
        }

        private void ReadDocumentPdf()
        {
            try
            {
                string filename = @"C:\Users\supor\Downloads\organico\anexo_contrato_locacao_HORAS.pdf";
                //PdfReader reader = new PdfReader(filename);
                PdfReader reader = new PdfReader(new RandomAccessFileOrArray(filename), null);
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}