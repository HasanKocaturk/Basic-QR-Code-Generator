using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QRCoder.PayloadGenerator;

namespace qrCodeGenerator
{
    public partial class frmQrCode : Form
    {
        public frmQrCode()
        {
            InitializeComponent();
        }

        private void btnAppExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnQrCodeGenerate_Click(object sender, EventArgs e)
        {
            
            QRCoder.QRCodeGenerator qrGen = new QRCoder.QRCodeGenerator();
            var qrData = qrGen.CreateQrCode(txtbQrCodeData.Text,QRCoder.QRCodeGenerator.ECCLevel.H);
            var qrCode = new QRCoder.QRCode(qrData);


            picbQrCode.Image = qrCode.GetGraphic(50);
        }

        private void btnQrSave_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog sFD=new SaveFileDialog())
            {
                sFD.Filter= "JPEG dosyaları (*.jpg)|*.jpg|Tüm dosyalar (*.*)|*.*";
                sFD.FilterIndex = 1;
                sFD.RestoreDirectory = true;

                if(sFD.ShowDialog() == DialogResult.OK)
                {
                    string filePath = sFD.FileName;
                    picbQrCode.Image.Save(filePath,ImageFormat.Jpeg);
                    MessageBox.Show("QR kodu başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
