namespace practicaDeModulo
{
    partial class FormAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.Guardarbtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OpcionDbox = new System.Windows.Forms.TextBox();
            this.OpcionCbox = new System.Windows.Forms.TextBox();
            this.OpcionBbox = new System.Windows.Forms.TextBox();
            this.OpcionAbox = new System.Windows.Forms.TextBox();
            this.Respuestabox = new System.Windows.Forms.ComboBox();
            this.PreguntaEnInglesbox = new System.Windows.Forms.TextBox();
            this.PreguntaEnESbox = new System.Windows.Forms.TextBox();
            this.ComboModulobox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.salirbtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvPreguntas = new System.Windows.Forms.DataGridView();
            this.imagenPregunta = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreguntas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPregunta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.imagenPregunta);
            this.panel2.Controls.Add(this.Guardarbtn);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.OpcionDbox);
            this.panel2.Controls.Add(this.OpcionCbox);
            this.panel2.Controls.Add(this.OpcionBbox);
            this.panel2.Controls.Add(this.OpcionAbox);
            this.panel2.Controls.Add(this.Respuestabox);
            this.panel2.Controls.Add(this.PreguntaEnInglesbox);
            this.panel2.Controls.Add(this.PreguntaEnESbox);
            this.panel2.Controls.Add(this.ComboModulobox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(413, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(555, 600);
            this.panel2.TabIndex = 1;
            // 
            // Guardarbtn
            // 
            this.Guardarbtn.BackColor = System.Drawing.Color.Aqua;
            this.Guardarbtn.Location = new System.Drawing.Point(282, 482);
            this.Guardarbtn.Name = "Guardarbtn";
            this.Guardarbtn.Size = new System.Drawing.Size(203, 43);
            this.Guardarbtn.TabIndex = 15;
            this.Guardarbtn.Text = "Guardar";
            this.Guardarbtn.UseVisualStyleBackColor = false;
            this.Guardarbtn.Click += new System.EventHandler(this.Guardarbtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label10.Location = new System.Drawing.Point(246, 376);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 21);
            this.label10.TabIndex = 14;
            this.label10.Text = "Respuesta Correcta";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label11.Location = new System.Drawing.Point(54, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 21);
            this.label11.TabIndex = 13;
            this.label11.Text = "Nueva pregunta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label9.Location = new System.Drawing.Point(246, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 21);
            this.label9.TabIndex = 11;
            this.label9.Text = "Opcion C";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Location = new System.Drawing.Point(391, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 21);
            this.label8.TabIndex = 11;
            this.label8.Text = "Opcion D";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Location = new System.Drawing.Point(391, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Opcion B";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(244, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Opcion A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(20, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pregunta en Igles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(20, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Pregunta en Español";
            // 
            // OpcionDbox
            // 
            this.OpcionDbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.OpcionDbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OpcionDbox.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpcionDbox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.OpcionDbox.Location = new System.Drawing.Point(385, 328);
            this.OpcionDbox.Name = "OpcionDbox";
            this.OpcionDbox.Size = new System.Drawing.Size(100, 29);
            this.OpcionDbox.TabIndex = 8;
            // 
            // OpcionCbox
            // 
            this.OpcionCbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.OpcionCbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OpcionCbox.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpcionCbox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.OpcionCbox.Location = new System.Drawing.Point(248, 328);
            this.OpcionCbox.Name = "OpcionCbox";
            this.OpcionCbox.Size = new System.Drawing.Size(100, 29);
            this.OpcionCbox.TabIndex = 7;
            // 
            // OpcionBbox
            // 
            this.OpcionBbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.OpcionBbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OpcionBbox.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpcionBbox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.OpcionBbox.Location = new System.Drawing.Point(397, 240);
            this.OpcionBbox.Name = "OpcionBbox";
            this.OpcionBbox.Size = new System.Drawing.Size(100, 29);
            this.OpcionBbox.TabIndex = 6;
            // 
            // OpcionAbox
            // 
            this.OpcionAbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(23)))));
            this.OpcionAbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OpcionAbox.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpcionAbox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.OpcionAbox.Location = new System.Drawing.Point(248, 239);
            this.OpcionAbox.Name = "OpcionAbox";
            this.OpcionAbox.Size = new System.Drawing.Size(100, 29);
            this.OpcionAbox.TabIndex = 5;
            // 
            // Respuestabox
            // 
            this.Respuestabox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Respuestabox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Respuestabox.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Respuestabox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Respuestabox.FormattingEnabled = true;
            this.Respuestabox.Location = new System.Drawing.Point(237, 401);
            this.Respuestabox.Name = "Respuestabox";
            this.Respuestabox.Size = new System.Drawing.Size(194, 29);
            this.Respuestabox.TabIndex = 4;
            // 
            // PreguntaEnInglesbox
            // 
            this.PreguntaEnInglesbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PreguntaEnInglesbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PreguntaEnInglesbox.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreguntaEnInglesbox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PreguntaEnInglesbox.Location = new System.Drawing.Point(22, 388);
            this.PreguntaEnInglesbox.Multiline = true;
            this.PreguntaEnInglesbox.Name = "PreguntaEnInglesbox";
            this.PreguntaEnInglesbox.Size = new System.Drawing.Size(187, 74);
            this.PreguntaEnInglesbox.TabIndex = 3;
            // 
            // PreguntaEnESbox
            // 
            this.PreguntaEnESbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PreguntaEnESbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PreguntaEnESbox.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreguntaEnESbox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PreguntaEnESbox.Location = new System.Drawing.Point(22, 270);
            this.PreguntaEnESbox.Multiline = true;
            this.PreguntaEnESbox.Name = "PreguntaEnESbox";
            this.PreguntaEnESbox.Size = new System.Drawing.Size(187, 74);
            this.PreguntaEnESbox.TabIndex = 2;
            // 
            // ComboModulobox
            // 
            this.ComboModulobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ComboModulobox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboModulobox.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboModulobox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ComboModulobox.FormattingEnabled = true;
            this.ComboModulobox.Location = new System.Drawing.Point(28, 179);
            this.ComboModulobox.Name = "ComboModulobox";
            this.ComboModulobox.Size = new System.Drawing.Size(194, 29);
            this.ComboModulobox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(20, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "MODULO EDUCATIVO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Fira Code", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(493, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(612, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTION DE CONTENIDO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Fira Code Retina", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label2.Location = new System.Drawing.Point(521, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(502, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Configuración bilingüe de módulos y evaluaciones.";
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.pnlSidebar.Controls.Add(this.salirbtn);
            this.pnlSidebar.Controls.Add(this.button3);
            this.pnlSidebar.Controls.Add(this.button2);
            this.pnlSidebar.Controls.Add(this.label12);
            this.pnlSidebar.Controls.Add(this.label13);
            this.pnlSidebar.Controls.Add(this.label14);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(395, 728);
            this.pnlSidebar.TabIndex = 11;
            // 
            // salirbtn
            // 
            this.salirbtn.BackColor = System.Drawing.Color.Lavender;
            this.salirbtn.Location = new System.Drawing.Point(0, 647);
            this.salirbtn.Name = "salirbtn";
            this.salirbtn.Size = new System.Drawing.Size(392, 76);
            this.salirbtn.TabIndex = 18;
            this.salirbtn.Text = "salir";
            this.salirbtn.UseVisualStyleBackColor = false;
            this.salirbtn.Click += new System.EventHandler(this.salirbtn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(3, 419);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(392, 75);
            this.button3.TabIndex = 17;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(1, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(392, 75);
            this.button2.TabIndex = 16;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label12.Location = new System.Drawing.Point(12, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(366, 122);
            this.label12.TabIndex = 9;
            this.label12.Text = "Sistema de Administradores";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label13.Location = new System.Drawing.Point(156, 153);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 21);
            this.label13.TabIndex = 9;
            this.label13.Text = "Grupo1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Black", 55F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label14.Location = new System.Drawing.Point(59, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(264, 146);
            this.label14.TabIndex = 9;
            this.label14.Text = "edu";
            // 
            // dgvPreguntas
            // 
            this.dgvPreguntas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgvPreguntas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPreguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreguntas.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvPreguntas.Location = new System.Drawing.Point(974, 123);
            this.dgvPreguntas.Name = "dgvPreguntas";
            this.dgvPreguntas.RowHeadersWidth = 62;
            this.dgvPreguntas.RowTemplate.Height = 28;
            this.dgvPreguntas.Size = new System.Drawing.Size(477, 600);
            this.dgvPreguntas.TabIndex = 12;
            // 
            // imagenPregunta
            // 
            this.imagenPregunta.BackColor = System.Drawing.Color.Teal;
            this.imagenPregunta.Location = new System.Drawing.Point(262, 50);
            this.imagenPregunta.Name = "imagenPregunta";
            this.imagenPregunta.Size = new System.Drawing.Size(223, 129);
            this.imagenPregunta.TabIndex = 16;
            this.imagenPregunta.TabStop = false;
            this.imagenPregunta.Click += new System.EventHandler(this.imagenPregunta_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1463, 728);
            this.Controls.Add(this.dgvPreguntas);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdmin";
            this.Text = "admin";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreguntas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPregunta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PreguntaEnESbox;
        private System.Windows.Forms.ComboBox ComboModulobox;
        private System.Windows.Forms.TextBox OpcionDbox;
        private System.Windows.Forms.TextBox OpcionCbox;
        private System.Windows.Forms.TextBox OpcionBbox;
        private System.Windows.Forms.TextBox OpcionAbox;
        private System.Windows.Forms.ComboBox Respuestabox;
        private System.Windows.Forms.TextBox PreguntaEnInglesbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Guardarbtn;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button salirbtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvPreguntas;
        private System.Windows.Forms.PictureBox imagenPregunta;
    }
}