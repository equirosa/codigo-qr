using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorQR
{
    public class CreatorQR
    {
        private QRCodeGenerator generador = new QRCodeGenerator();
        public CreatorQR() { }
        public Image GenerarCodigo(string datos)
        {
            QRCodeData CodeData = generador.CreateQrCode(datos, QRCodeGenerator.ECCLevel.Q);
            QRCode codigo = new QRCode(CodeData);
            Bitmap imagen = codigo.GetGraphic(10);
            return imagen;
        }
    }
}
