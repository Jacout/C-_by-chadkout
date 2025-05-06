using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploBdS
{
    public partial class Form1 : Form
    {
        Login L = new Login();
        public Form1()
        {
            InitializeComponent();
        }

        private void Bnt_Iniciar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(User_Text.Text)) {
            
            
            }
            else if (string.IsNullOrEmpty(Pass_Text.Text))
            {


            }
            else if (L.Inicio(User_Text.Text, Pass_Text.Text) == 1)
            {
                Inicio I = new Inicio();
                this.Hide();
                I.Show();


            }
            else {
                MessageBox.Show("No puede ingresar, intente de nuevo");
            
            }
        }
    }
}
