using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenScraper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            string url = tbURL.Text;
            string sourceCode = WorkerClass.getSourceCode(url);

            StreamWriter sw = new StreamWriter("sourcecode.txt");
            sw.Write(sourceCode);
            sw.Close();

        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            WorkerClass.parseSource("sourcecode.txt");
        }
    }
}
