using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menus_desplegables
{
    public partial class INICIO : Form
    {
        public INICIO()
        {
            InitializeComponent();
            Cuztomize();
        }
        private void Cuztomize() {
            Panelprimero.Visible = false;
            Segundo.Visible = false;
        
        }
        private void hidesubmenu() {
            if (Panelprimero.Visible == true) {
                Panelprimero.Visible = false;
            }
            if (Segundo.Visible == true) {
                Segundo.Visible = false;

            }
        }
        private void showmenu(Panel submenu) {
            if (submenu.Visible == false)
            {
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showmenu(Panelprimero);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }
    }
}
