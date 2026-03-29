using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static practicaDeModulo.Rol;

namespace practicaDeModulo
{
    public partial class Form1 : Form
    {
        List<Usuario> ListaU = new List<Usuario>();
        public int id = 2;



        public Form1()
        {
            InitializeComponent();



            Rol RolAdmin = new Administrador();
            Rol RolJugador = new Jugador();
            ListaU.Add(new Usuario("Luben", 1, "1234", RolAdmin));
            /*
            Aqui tenemos un ejemplo de un usuario administrador 
            llamamos a RolAdmin para asignarle ese perfil
            */
            ListaU.Add(new Usuario("valentina", 2, "2222", RolJugador));


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
            if (txtUsuario.Text == "" || txtClave.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string NombreUsuarioI = txtUsuario.Text;
            string ClaveUsuario = txtClave.Text;

            Usuario UsusarioEncontrado = ListaU.Find(x => x.NombreUser == NombreUsuarioI && x.Clave == ClaveUsuario);
            if (UsusarioEncontrado != null)
            {
                MessageBox.Show($"Bienvenido {UsusarioEncontrado.NombreUser}, tu perfil es {UsusarioEncontrado.Perfil}.", "Inicio de Sesión Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtUsuarioR.Text == "" || txtClaveRegistro.Text == "" || txtconfirmarClaveRegistro.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                id++;
                string nombreUserR = txtUsuarioR.Text;
                string claveUsuarioR = txtClaveRegistro.Text;
                string claveUsuarioRR = txtconfirmarClaveRegistro.Text;
                Rol RolJugador = new Jugador();
                Rol RolAdmin = new Administrador();

                Usuario encontrado = ListaU.Find(x => x.NombreUser == nombreUserR);
                if (encontrado != null)
                {
                    MessageBox.Show("El nombre de usuario ya existe. Por favor, elija otro.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                { 
                    if (txtClaveRegistro.Text != txtconfirmarClaveRegistro.Text)
                    {
                        MessageBox.Show("Las contraseñas no coinciden.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else

                        ListaU.Add(new Usuario(nombreUserR, id, claveUsuarioR, RolJugador));
                    MessageBox.Show("Registro Exitoso");

                }
            }
        }
    }
}
