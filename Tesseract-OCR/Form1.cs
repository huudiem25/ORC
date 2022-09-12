using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace Tesseract_OCR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btOCR_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var img = new Bitmap(openFileDialog.FileName);
                var ocr = new TesseractEngine("./tessdata", "eng", EngineMode.TesseractAndCube);
                var page = ocr.Process(img);
                txtResult.Text = page.GetText();
            }
        }
    }
}
