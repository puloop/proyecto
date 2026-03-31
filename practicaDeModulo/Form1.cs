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
        void limpiar()
        {
            txtClaveRegistro.Clear();
            txtconfirmarClaveRegistro.Clear();
            txtUsuarioR.Clear();
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
                if (UsusarioEncontrado.Perfil is Administrador)
                {
                    // 1. Creamos la ventana
                    FormAdmin panelAdmin = new FormAdmin();

                    // 2. Ocultamos el Login (Form1)
                    this.Hide();

                    // 3. Mostramos el Panel de Admin
                    panelAdmin.Show();
                }
                else
                {
                    FormJugador panelJugador = new FormJugador();
                    this.Hide();
                    panelJugador.Show();
                }
                MessageBox.Show($"Bienvenido {UsusarioEncontrado.NombreUser}, tu perfil es {UsusarioEncontrado.Perfil}.", "Inicio de Sesión Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
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
                string Codigo = "!2w1";
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

                    Rol rolAsignado = new Jugador();

                    if (checkBox1.Checked)
                    {
                        if (txtAdminR.Text == Codigo)
                        {
                            rolAsignado = new Administrador();
                        }
                        else
                        {
                            MessageBox.Show("El código de administrador es incorrecto.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            checkBox1.Checked = false;

                            return;
                        }
                    }
                    id++;
                    ListaU.Add(new Usuario(nombreUserR, id, claveUsuarioR, rolAsignado));

                    MessageBox.Show("Registro Exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpiar();
                    checkBox1.Checked = false;
                }

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtAdminR.Enabled = checkBox1.Checked;
            if (!checkBox1.Checked)
            {
                txtAdminR.Clear();
            }
            else
            {
                txtAdminR.Focus();
            }
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
    }

}
