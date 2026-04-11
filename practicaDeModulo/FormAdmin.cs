using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace practicaDeModulo
{
    public partial class FormAdmin : Form
    {
        // ACA CREO LA LISTA PARA GUARDAR LAS PREGUNTAS EN LA MEMORIA MIENTRAS EL PROGRAMA ESTE ABIERTO
        List<Pregunta> misPreguntas = new List<Pregunta>();

        // ESTA VARIABLE ES PARA ACORDARNOS DONDE ESTA LA IMAGEN QUE ELEJIMOS CON EL MOUSE
        string rutaImagenSeleccionada = "";

        public FormAdmin()
        {
            InitializeComponent();

            // APENAS CARGA EL FORMULARIO, LLENAMOS LOS COMBITOS CON LAS OPCIONES PARA QUE NO ESTEN VACIOS
            // paza que si no el usuario no tiene nada que elejir y se confunde
            ComboModulobox.Items.Add("Arquitectura del Computador");
            ComboModulobox.Items.Add("Antropologia Filosofica");
            ComboModulobox.Items.Add("Calculo");
            ComboModulobox.Items.Add("Deporte");

            // ESTO ES PARA ELEGIR CUAL DE LAS 4 OPCIONES ES LA QUE VALE PUNTOS (la verdadera)
            Respuestabox.Items.Add("Opcion A");
            Respuestabox.Items.Add("Opcion B");
            Respuestabox.Items.Add("Opcion C");
            Respuestabox.Items.Add("Opcion D");
        }

        // ESTE ES EL BOTON PARA GUARDAR TODO LO QUE ESCRIBIMOS EN LOS CUADRITOS
        private void Guardarbtn_Click(object sender, EventArgs e)
        {
            // PRIMERO REVISAMOS QUE NO ALLA NADA VACIO PORQUE SI NO DA ERROR MAS ADELANTE
            if (ComboModulobox.Text == "" || PreguntaEnESbox.Text == "" || PreguntaEnInglesbox.Text == "" ||
                OpcionAbox.Text == "" || OpcionBbox.Text == "" || OpcionCbox.Text == "" ||
                OpcionDbox.Text == "" || Respuestabox.Text == "")
            {
                // SI FALTA ALGO AVISAMOS CON UN MENSAJE EN PANTALLA
                MessageBox.Show("Por favor, completa todos los campos antes de guardar.");
            }
            else
            {
                // SI TODO ESTA BIEN, CREAMOS UNA PREGUNTA NUEVA (EL MOLDE)
                Pregunta p = new Pregunta();

                // LE PASAMOS TODO LO QUE ESCRIBIMOS EN LOS TEXTBOX A LA PREGUNTA
                p.Modulo = ComboModulobox.Text;
                p.TextoES = PreguntaEnESbox.Text;
                p.TextoEN = PreguntaEnInglesbox.Text;
                p.A = OpcionAbox.Text;
                p.B = OpcionBbox.Text;
                p.C = OpcionCbox.Text;
                p.D = OpcionDbox.Text;
                p.Correcta = Respuestabox.Text;
                p.RutaImagen = rutaImagenSeleccionada; // TAMBIEN GUARDAMOS LA DIRECCION DE LA FOTO

                // METEMOS LA PREGUNTA A LA LISTA QUE CREAMOS ARRIBA
                misPreguntas.Add(p);

                MessageBox.Show("Pregunta guardada con exito en la lista.");

                // BORRAMOS TODO PARA PODER ESCRIBIR OTRA PREGUNTA RAPIDO
                LimpiarCampos();

                // ESTO LLAMA A LA FUNCION DE ABAJO PARA QUE SE VEA EN EL DATA GRID (la tabla)
                actualizar();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // ESTA FUNCION ES PARA NO REPETIR CODIGO, SOLO LIMPIA LAS CAJAS DE TEXTO
        void LimpiarCampos()
        {
            PreguntaEnESbox.Clear();
            PreguntaEnInglesbox.Clear();
            OpcionAbox.Clear();
            OpcionBbox.Clear();
            OpcionCbox.Clear();
            OpcionDbox.Clear();
            ComboModulobox.SelectedIndex = -1; // ESTO RESETEA EL COMBOMODULO PARA QUE QUEDE EN BLANCO
            Respuestabox.SelectedIndex = -1;

            rutaImagenSeleccionada = "";

            // USAMOS UN IF POR SI ACASO EL PICTUREBOX ESTA VACIO O DA ALGUN PROBLMA
            if (imagenPregunta != null)
            {
                imagenPregunta.Image = null;
            }
        }

        // BOTON PARA SALIR Y VOLVER AL FORMULARIO 1 (EL LOGIN)
        private void salirbtn_Click(object sender, EventArgs e)
        {
            this.Close(); // CERRAMOS EL PANEL DE ADMIN
            if (Application.OpenForms["Form1"] != null)
            {
                Application.OpenForms["Form1"].Show(); // MOSTRAMOS EL LOGIN DE NUEVO
            }
        }

        // ESTA FUNCION HACE EL TRUCO PARA QUE LA TABLA SE REFREQUE Y SE VEA LO QUE ACABAMOS DE GUARDAR
        void actualizar()
        {
            dgvPreguntas.DataSource = null; // PRIMERO LO VACEAMOS PARA QUE NO SE DUPLIQUE LA INFO
            dgvPreguntas.DataSource = misPreguntas; // LUEGO LE PASAMOS LA LISTA OTRA VEZ
        }

        // ESTO SE ACTIVA CUANDO HACES CLIC EN EL CUADRO DE LA IMAGEN O EL BOTON DE BUSCAR
        private void imagenPregunta_Click(object sender, EventArgs e)
        {
            // ABRIMOS LA VENTANITA DE WINDOWS PARA BUSCAR ARCHIVOS PNG O JPG EN LA COMPUTADORA
            OpenFileDialog buscador = new OpenFileDialog();
            buscador.Filter = "Archivos de imagen|*.jpg;*.png;*.jpeg";

            // SI EL USUARIO ELIGE UNA FOTO Y LE DA AL BOTON DE ACEPTAR
            if (buscador.ShowDialog() == DialogResult.OK)
            {
                // NOS GUARDAMOS LA DIRECCION DE LA FOTO EN LA VARIABLE GLOBAL
                rutaImagenSeleccionada = buscador.FileName;

                // INTENTAMOS MOSTRAR LA FOTO EN EL CUADRO PARA VER QUE ELEGIMOS BIEN
                try
                {
                    imagenPregunta.ImageLocation = rutaImagenSeleccionada;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo mostrar la foto elegida: " + ex.Message);
                }
            }
        }
    }
}