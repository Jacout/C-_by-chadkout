using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EjemploBdS
{
    public class Login
    {
      
        protected readonly string CN = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=E:\\Kakout\\EjemploBdS\\EjemploBdS\\weyyyn1.mdf;Integrated Security=True";
        public Login()
        {
            try
            {
                using (SqlConnection CON = new SqlConnection(CN))
                {

                    CON.Open();
                    MessageBox.Show("Se ha conectado");
                }
            }
            catch (Exception E)
            {

                MessageBox.Show("No se conecto: " + E.ToString());
            }

        }

        public int Inicio(string nom, string con) {
            int S = 0;
        try
        {
            SqlConnection CON = new SqlConnection(CN);
            CON.Open();
            SqlCommand COM = new SqlCommand("Select * from Administrador where UserName=@nom and Pass=@con", CON);
            
                COM.Parameters.AddWithValue("@nom", nom);
                COM.Parameters.AddWithValue("@con", con);
                SqlDataReader RE = COM.ExecuteReader();
                while (RE.Read()) {
                    S = 1;
                }

                CON.Close();

            }

        
        catch {
            S = 0;
        }
            
        return S;
        }



    }

    }

