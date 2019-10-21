using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebcamCapturer.Core;
using ZXing;

namespace GeneradorQR
{
    public class CreatorQR
    {
        private BarcodeWriter escritor = new BarcodeWriter();
        QRCodeGenerator generator = new QRCodeGenerator();
        IBarcodeReader lector = new BarcodeReader();
        public CreatorQR() { }
        public Image GenerarCodigo(string datos)
        {
            //USANDO QRCoder
            //QRCodeData datoCodigo = generator.CreateQrCode(datos, QRCodeGenerator.ECCLevel.Q);
            //QRCode codigo = new QRCode(datoCodigo);
            //Image imagen = codigo.GetGraphic(10);

            //USANDO ZXing
            escritor.Format = BarcodeFormat.QR_CODE;
            Image imagen = escritor.Write(datos);
            imagen.Save(@"C:\Users\equir\Pictures\qrcodes\codigo");
            return imagen;
        }

        public string LeerCodigo()
        {
            var bitmap = (Bitmap)Bitmap.FromFile(@"C:\Users\equir\Pictures\qrcodes\codigo");
            var resultado = lector.Decode(bitmap);
            if (resultado != null)
                return resultado.Text;
            else
                return "Archivo no encontrado.";
        }
    }
}
