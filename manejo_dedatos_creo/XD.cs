using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDSSS
{
    [RunInstaller(true)]
    public partial class XD : System.Configuration.Install.Installer
    {
        public XD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog F = new OpenFileDialog();
            F.ShowDialog();
        }
    }
}
