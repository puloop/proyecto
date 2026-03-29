using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace practicaDeModulo
{
    public partial class Form1 : Form
    {
        List<Usuario> usuario = new List<Usuario>();
        {
            new Usuario { Nombre = "admin", Contraseña = "admin123" },
            new Usuario { Nombre = "user1", Contraseña = "123456" },
        public Form1()
        {
            InitializeComponent();
        }

        private void ResaltarLinea(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            string nombreLinea = "pnl" + txt.Name.Substring(3) + "Line";
            Control linea = this.Controls.Find(nombreLinea, true).FirstOrDefault();

            if (linea != null)
            {
                
                if (txt.Parent.Name == "pnlRegistro")
                    linea.BackColor = ColorTranslator.FromHtml("#10B981"); 
                else
                    linea.BackColor = ColorTranslator.FromHtml("#007ACC"); 

                linea.Height = 2; 
            }
        }
        private void NormalizarLinea(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            string nombreLinea = "pnl" + txt.Name.Substring(3) + "Line";
            Control linea = this.Controls.Find(nombreLinea, true).FirstOrDefault();

            if (linea != null)
            {
                linea.BackColor = Color.Gray; 
                linea.Height = 1; 
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            Panelogin.Visible = false;     
            panelRegistro.Visible = true;      
            panelRegistro.BringToFront();
            this.BackColor = ColorTranslator.FromHtml("#0F172A"); 
            this.Text = "Crear nueva cuenta";
        }

        private void Volverbtn_Click(object sender, EventArgs e)
        {
            panelRegistro.Visible = false;
            Panelogin.Visible = true;
            this.Refresh();
            this.Text = "Iniciar Sesión";


        }

        private void Aceptarbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
