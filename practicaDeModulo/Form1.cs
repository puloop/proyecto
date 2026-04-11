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
        // ACA CREAMOS LA LISTA DONDE SE GUARDAN LOS USUARIOS QUE SE REGISTREN
        List<Usuario> ListaU = new List<Usuario>();

        // ESTE ID ES PARA QUE CADA USUARIO TENGA UN NUMERO DIFERENTE
        public int id = 2;

        public Form1()
        {
            InitializeComponent();

            // CREAMOS LOS ROLES PARA PODER USARLOS
            Rol RolAdmin = new Administrador();
            Rol RolJugador = new Jugador();

            // AGREGAMOS UNOS USUARIOS DE PRUEBA PARA NO TENER QUE REGISTRAR SIEMPRE
            ListaU.Add(new Usuario("Luben", 1, "1234", RolAdmin));
            ListaU.Add(new Usuario("valentina", 2, "2222", RolJugador));
        }

        // ESTA FUNCION ES PARA VACEAR LOS CUADRITOS DEL REGISTRO
        void limpiar()
        {
            txtClaveRegistro.Clear();
            txtconfirmarClaveRegistro.Clear();
            txtUsuarioR.Clear();
        }

        // CUANDO TOCAS EL LABEL DE "CREAR CUENTA" SE CAMBIA EL PANEL
        private void label1_Click(object sender, EventArgs e)
        {
            Panelogin.Visible = false; // escondemos el login
            panelRegistro.Visible = true; // mostramos el registro
            panelRegistro.BringToFront();

            // le cambiamos el color al fondo para que se vea mas pro
            this.BackColor = ColorTranslator.FromHtml("#0F172A");
            this.Text = "Crear nueva cuenta";
        }

        // BOTON PARA VOLVER AL LOGIN SI TE ARREPENTIS
        private void Volverbtn_Click(object sender, EventArgs e)
        {
            panelRegistro.Visible = false;
            Panelogin.Visible = true;
            this.Refresh();
            this.Text = "Iniciar Sesion";
        }

        // ESTE ES EL BOTON PARA ENTRAR AL SISTEMA
        private void Aceptarbtn_Click(object sender, EventArgs e)
        {
            // revisamos que no dejen espacios en blanco
            if (txtUsuario.Text == "" || txtClave.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string NombreUsuarioI = txtUsuario.Text;
            string ClaveUsuario = txtClave.Text;

            // BUSCAMOS EN LA LISTA SI EXISTE ESE USUARIO Y SI LA CLAVE ESTA BIEN
            Usuario UsusarioEncontrado = ListaU.Find(x => x.NombreUser == NombreUsuarioI && x.Clave == ClaveUsuario);

            if (UsusarioEncontrado != null)
            {
                // SI ES ADMIN, LO MANDAMOS AL PANEL DE CONTROL
                if (UsusarioEncontrado.Perfil is Administrador)
                {
                    FormAdmin panelAdmin = new FormAdmin();
                    this.Hide(); // escondemos el login
                    panelAdmin.Show();
                }
                else // SI NO, ES JUGADOR Y VA AL MENU DE JUEGOS
                {
                    FormJugador panelJugador = new FormJugador();
                    this.Hide();
                    panelJugador.Show();
                }

                MessageBox.Show($"Bienvenido {UsusarioEncontrado.NombreUser}, tu perfil es {UsusarioEncontrado.Perfil}.", "Inicio de Sesion Exitoso");
                limpiar();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error");
            }
        }

        // BOTON PARA REGISTRAR UN USUARIO NUEVO
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // validamos que pongan todo
            if (txtUsuarioR.Text == "" || txtClaveRegistro.Text == "" || txtconfirmarClaveRegistro.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error");
                return;
            }
            else
            {
                string Codigo = "soyadmin"; // este es el codigo secreto para ser admin
                string nombreUserR = txtUsuarioR.Text;
                string claveUsuarioR = txtClaveRegistro.Text;

                // REVISAMOS QUE EL NOMBRE NO ESTE REPETIDO
                Usuario encontrado = ListaU.Find(x => x.NombreUser == nombreUserR);
                if (encontrado != null)
                {
                    MessageBox.Show("Ese nombre ya lo usa alguien mas.", "Error");
                }
                else
                {
                    // revisamos que las dos claves sean iguales
                    if (txtClaveRegistro.Text != txtconfirmarClaveRegistro.Text)
                    {
                        MessageBox.Show("Las contraseñas no coinciden.", "Error");
                        return;
                    }

                    // por defecto todos son jugadores
                    Rol rolAsignado = new Jugador();

                    // SI MARCA EL CHECK DE ADMIN, LE PEDIMOS EL CODIGO
                    if (checkBox1.Checked)
                    {
                        if (txtAdminR.Text == Codigo)
                        {
                            rolAsignado = new Administrador();
                        }
                        else
                        {
                            MessageBox.Show("El codigo de admin esta mal.", "Acceso Denegado");
                            checkBox1.Checked = false;
                            return;
                        }
                    }

                    // si todo salio bien, lo agregamos a la lista
                    id++;
                    ListaU.Add(new Usuario(nombreUserR, id, claveUsuarioR, rolAsignado));

                    MessageBox.Show("Registro Exitoso", "Exito");

                    limpiar();
                    checkBox1.Checked = false;
                }
            }
        }

        // ESTO ACTIVA O DESACTIVA EL CUADRITO DEL CODIGO ADMIN
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtAdminR.Enabled = checkBox1.Checked;
            if (!checkBox1.Checked)
            {
                txtAdminR.Clear();
            }
            else
            {
                txtAdminR.Focus(); // que se ponga el palito para escribir solo
            }
        }

        // ESTO ES PARA QUE LAS LINEAS SE PONGAN DE COLOR CUANDO HACES CLIC EN LOS TEXTBOX
        private void ResaltarLinea(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            string nombreLinea = "pnl" + txt.Name.Substring(3) + "Line";
            Control linea = this.Controls.Find(nombreLinea, true).FirstOrDefault();

            if (linea != null)
            {
                if (txt.Parent.Name == "pnlRegistro")
                    linea.BackColor = ColorTranslator.FromHtml("#10B981"); // verde para registro
                else
                    linea.BackColor = ColorTranslator.FromHtml("#007ACC"); // azul para login

                linea.Height = 2;
            }
        }

        // CUANDO SACAS EL MOUSE O CAMBIAS DE CUADRITO, LA LINEA VUELVE A SER GRIS
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

        // BOTON PARA CERRAR TODA LA APP
        private void salirPbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}