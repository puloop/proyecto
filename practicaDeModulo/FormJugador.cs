using System;
using System.Windows.Forms;

namespace practicaDeModulo
{
    public partial class FormJugador : Form
    {
        // ACA GUARDO EN QUE NUMERO DE PREGNTA VAMOS (empezamos en 1)
        int p = 1;

        // EL TOTAL DE PREGUNTAS QUE TIENE EL MODULO
        int total = 10;

        public FormJugador()
        {
            InitializeComponent();
        }

        // --- CUANDO TOCAS EL BOTON DE ARQUITECTURA ---
        private void Arquitectura_Click(object sender, EventArgs e)
        {
            // Reseteamos el contador para que empieze de 1 siempre
            p = 1;
            contador.Text = p + " / " + total;
            LabelPregunta.Text = "Pregunta " + p + " (Arquitectura)";

            // Borramos los checks por si quedaron marcados de antes
            cleancheck();

            // Mostramos el panel donde se juega y escondemos el menu principal
            PanelDejuego.Visible = true;
            PanelMenu.Visible = false;
            pnlSidebar.Visible = false;

            // Mandamos el panel de juego al frente para que se vea bien
            PanelDejuego.BringToFront();
            labeldeModulo.Text = "💻\r\narquitectura\r\n \r\ndel computador";
        }

        // --- CUANDO TOCAS EL BOTON DE ANTROPOLOGIA ---
        private void Antropologia_Click(object sender, EventArgs e)
        {
            p = 1;
            contador.Text = p + " / " + total;
            LabelPregunta.Text = "Pregunta " + p + " (Antropología)";
            cleancheck();

            PanelDejuego.Visible = true;
            PanelMenu.Visible = false;
            pnlSidebar.Visible = false;
            PanelDejuego.BringToFront();
            labeldeModulo.Text = "🏺\r\nantropologia filosofica\r\n";
        }

        // --- CUANDO TOCAS EL BOTON DE CALCULO ---
        private void Calculo_Click(object sender, EventArgs e)
        {
            p = 1;
            contador.Text = p + " / " + total;
            LabelPregunta.Text = "Pregunta " + p + " (Cálculo)";
            cleancheck();

            PanelDejuego.Visible = true;
            PanelMenu.Visible = false;
            pnlSidebar.Visible = false;
            PanelDejuego.BringToFront();
            labeldeModulo.Text = "📐\r\nCálculo\r\n";
        }

        // --- CUANDO TOCAS EL BOTON DE DEPORTE ---
        private void Deporte_Click(object sender, EventArgs e)
        {
            p = 1;
            contador.Text = p + " / " + total;
            LabelPregunta.Text = "Pregunta " + p + " (Deporte)";
            cleancheck();

            PanelDejuego.Visible = true;
            PanelMenu.Visible = false;
            pnlSidebar.Visible = false;
            PanelDejuego.BringToFront();
            labeldeModulo.Text = "⚽\r\nDeporte\r\n";
        }

        // --- BOTON PARA PASAR A LA SIGIENTE PREGUNTA ---
        private void siguienteArbtn_Click(object sender, EventArgs e)
        {
            // Mientras no hayamos llegado al final...
            if (p < total)
            {
                p++; // sumamos uno al contador
                contador.Text = p + " / " + total;
                LabelPregunta.Text = "Pregunta " + p + " (Aquí va la pregunta)";

                // Limpiamos los cuadritos de respuesta
                cleancheck();
            }
            else
            {
                // Si ya no hay mas, avisamos que termino el examen
                MessageBox.Show("¡Ya terminaste todas las preguntas!");
            }
        }

        // --- BOTON PARA VOLVER A LA PREGUNTA DE ATRAS ---
        private void volverbtnAR_Click(object sender, EventArgs e)
        {
            // Si no estamos en la primera, podemos volver
            if (p > 1)
            {
                p--; // restamos uno
                contador.Text = p + " / " + total;
                LabelPregunta.Text = "Pregunta " + p + " (Aquí va la pregunta)";
                cleancheck();
            }
            else
            {
                // Si estamos en la 1 y quiere volver, lo mandamos al menu mejor
                menubtn_Click(sender, e);
            }
        }

        // --- ESTO NOS REGRESA AL MENU DE ELEJIR MODULOS ---
        private void menubtn_Click(object sender, EventArgs e)
        {
            PanelDejuego.Visible = false;
            PanelMenu.Visible = true;
            pnlSidebar.Visible = true;
            PanelMenu.BringToFront();
        }

        // --- BOTON PARA SALIR AL LOGIN ---
        private void Salirbtn_Click(object sender, EventArgs e)
        {
            this.Close(); // Cerramos esta ventana

            // Buscamos el formulario de inicio (Form1) para mostrarlo de nuevo
            if (Application.OpenForms["Form1"] != null)
            {
                Application.OpenForms["Form1"].Show();
            }
        }

        // ESTA FUNCION SOLO DESMARCA LOS CHECKS PARA QUE NO QUEDEN MARCADOS
        void cleancheck()
        {
            opcionA.Checked = false;
            OpcionB.Checked = false;
            OpcionC.Checked = false;
            OpcionD.Checked = false;
        }
    }
}