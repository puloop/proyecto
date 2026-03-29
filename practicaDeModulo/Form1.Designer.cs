namespace practicaDeModulo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.Aceptarbtn = new System.Windows.Forms.Button();
            this.panelRegistro = new System.Windows.Forms.Panel();
            this.pnlconfirmarClaveRegistroLine = new System.Windows.Forms.Panel();
            this.pnlUsuarioRLine = new System.Windows.Forms.Panel();
            this.pnlClaveRegistroLine = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.Volverbtn = new System.Windows.Forms.Button();
            this.txtconfirmarClaveRegistro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtUsuarioR = new System.Windows.Forms.TextBox();
            this.txtClaveRegistro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Panelogin = new System.Windows.Forms.Panel();
            this.pnlUsuarioLine = new System.Windows.Forms.Panel();
            this.pnlClaveLine = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panelRegistro.SuspendLayout();
            this.Panelogin.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
            this.label1.Location = new System.Drawing.Point(12, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "No tienes un cuenta?\r\nRegistre aqui.\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(59, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ususario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(59, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Clave";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtUsuario.Location = new System.Drawing.Point(186, 170);
            this.txtUsuario.MaxLength = 30;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(153, 24);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Enter += new System.EventHandler(this.ResaltarLinea);
            this.txtUsuario.Leave += new System.EventHandler(this.NormalizarLinea);
            // 
            // txtClave
            // 
            this.txtClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtClave.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtClave.Location = new System.Drawing.Point(186, 216);
            this.txtClave.MaxLength = 25;
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(153, 24);
            this.txtClave.TabIndex = 1;
            this.txtClave.UseSystemPasswordChar = true;
            this.txtClave.Enter += new System.EventHandler(this.ResaltarLinea);
            this.txtClave.Leave += new System.EventHandler(this.NormalizarLinea);
            // 
            // Aceptarbtn
            // 
            this.Aceptarbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Aceptarbtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Aceptarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aceptarbtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptarbtn.Location = new System.Drawing.Point(239, 299);
            this.Aceptarbtn.Name = "Aceptarbtn";
            this.Aceptarbtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Aceptarbtn.Size = new System.Drawing.Size(100, 45);
            this.Aceptarbtn.TabIndex = 3;
            this.Aceptarbtn.Text = "Aceptar";
            this.Aceptarbtn.UseVisualStyleBackColor = false;
            this.Aceptarbtn.Click += new System.EventHandler(this.Aceptarbtn_Click);
            // 
            // panelRegistro
            // 
            this.panelRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelRegistro.Controls.Add(this.pnlconfirmarClaveRegistroLine);
            this.panelRegistro.Controls.Add(this.pnlUsuarioRLine);
            this.panelRegistro.Controls.Add(this.pnlClaveRegistroLine);
            this.panelRegistro.Controls.Add(this.label7);
            this.panelRegistro.Controls.Add(this.Volverbtn);
            this.panelRegistro.Controls.Add(this.txtconfirmarClaveRegistro);
            this.panelRegistro.Controls.Add(this.label6);
            this.panelRegistro.Controls.Add(this.btnRegistrar);
            this.panelRegistro.Controls.Add(this.txtUsuarioR);
            this.panelRegistro.Controls.Add(this.txtClaveRegistro);
            this.panelRegistro.Controls.Add(this.label4);
            this.panelRegistro.Controls.Add(this.label5);
            this.panelRegistro.Location = new System.Drawing.Point(0, 0);
            this.panelRegistro.Name = "panelRegistro";
            this.panelRegistro.Size = new System.Drawing.Size(400, 450);
            this.panelRegistro.TabIndex = 6;
            // 
            // pnlconfirmarClaveRegistroLine
            // 
            this.pnlconfirmarClaveRegistroLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.pnlconfirmarClaveRegistroLine.Location = new System.Drawing.Point(183, 229);
            this.pnlconfirmarClaveRegistroLine.Name = "pnlconfirmarClaveRegistroLine";
            this.pnlconfirmarClaveRegistroLine.Size = new System.Drawing.Size(153, 2);
            this.pnlconfirmarClaveRegistroLine.TabIndex = 16;
            // 
            // pnlUsuarioRLine
            // 
            this.pnlUsuarioRLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.pnlUsuarioRLine.Location = new System.Drawing.Point(183, 130);
            this.pnlUsuarioRLine.Name = "pnlUsuarioRLine";
            this.pnlUsuarioRLine.Size = new System.Drawing.Size(153, 2);
            this.pnlUsuarioRLine.TabIndex = 16;
            // 
            // pnlClaveRegistroLine
            // 
            this.pnlClaveRegistroLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.pnlClaveRegistroLine.Location = new System.Drawing.Point(183, 179);
            this.pnlClaveRegistroLine.Name = "pnlClaveRegistroLine";
            this.pnlClaveRegistroLine.Size = new System.Drawing.Size(153, 2);
            this.pnlClaveRegistroLine.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.label7.Location = new System.Drawing.Point(115, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 38);
            this.label7.TabIndex = 12;
            this.label7.Text = "REGISTRAR";
            // 
            // Volverbtn
            // 
            this.Volverbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            this.Volverbtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Volverbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Volverbtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volverbtn.Location = new System.Drawing.Point(31, 329);
            this.Volverbtn.Name = "Volverbtn";
            this.Volverbtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Volverbtn.Size = new System.Drawing.Size(132, 35);
            this.Volverbtn.TabIndex = 4;
            this.Volverbtn.Text = "Volver";
            this.Volverbtn.UseVisualStyleBackColor = false;
            this.Volverbtn.Click += new System.EventHandler(this.Volverbtn_Click);
            // 
            // txtconfirmarClaveRegistro
            // 
            this.txtconfirmarClaveRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtconfirmarClaveRegistro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtconfirmarClaveRegistro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtconfirmarClaveRegistro.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtconfirmarClaveRegistro.Location = new System.Drawing.Point(184, 207);
            this.txtconfirmarClaveRegistro.MaxLength = 25;
            this.txtconfirmarClaveRegistro.Name = "txtconfirmarClaveRegistro";
            this.txtconfirmarClaveRegistro.Size = new System.Drawing.Size(152, 24);
            this.txtconfirmarClaveRegistro.TabIndex = 2;
            this.txtconfirmarClaveRegistro.UseSystemPasswordChar = true;
            this.txtconfirmarClaveRegistro.Enter += new System.EventHandler(this.ResaltarLinea);
            this.txtconfirmarClaveRegistro.Leave += new System.EventHandler(this.NormalizarLinea);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.label6.Location = new System.Drawing.Point(26, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Confirmar Clave";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(241, 329);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnRegistrar.Size = new System.Drawing.Size(132, 35);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "Registrarme";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtUsuarioR
            // 
            this.txtUsuarioR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtUsuarioR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuarioR.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsuarioR.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtUsuarioR.Location = new System.Drawing.Point(184, 109);
            this.txtUsuarioR.MaxLength = 30;
            this.txtUsuarioR.Name = "txtUsuarioR";
            this.txtUsuarioR.Size = new System.Drawing.Size(152, 24);
            this.txtUsuarioR.TabIndex = 0;
            this.txtUsuarioR.Enter += new System.EventHandler(this.ResaltarLinea);
            this.txtUsuarioR.Leave += new System.EventHandler(this.NormalizarLinea);
            // 
            // txtClaveRegistro
            // 
            this.txtClaveRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtClaveRegistro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClaveRegistro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtClaveRegistro.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtClaveRegistro.Location = new System.Drawing.Point(184, 156);
            this.txtClaveRegistro.MaxLength = 25;
            this.txtClaveRegistro.Name = "txtClaveRegistro";
            this.txtClaveRegistro.Size = new System.Drawing.Size(152, 24);
            this.txtClaveRegistro.TabIndex = 1;
            this.txtClaveRegistro.UseSystemPasswordChar = true;
            this.txtClaveRegistro.Enter += new System.EventHandler(this.ResaltarLinea);
            this.txtClaveRegistro.Leave += new System.EventHandler(this.NormalizarLinea);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.label4.Location = new System.Drawing.Point(64, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Clave";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.label5.Location = new System.Drawing.Point(49, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ususario";
            // 
            // Panelogin
            // 
            this.Panelogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Panelogin.Controls.Add(this.pnlUsuarioLine);
            this.Panelogin.Controls.Add(this.pnlClaveLine);
            this.Panelogin.Controls.Add(this.label8);
            this.Panelogin.Controls.Add(this.txtUsuario);
            this.Panelogin.Controls.Add(this.txtClave);
            this.Panelogin.Controls.Add(this.Aceptarbtn);
            this.Panelogin.Controls.Add(this.label3);
            this.Panelogin.Controls.Add(this.label1);
            this.Panelogin.Controls.Add(this.label2);
            this.Panelogin.Location = new System.Drawing.Point(435, 3);
            this.Panelogin.Name = "Panelogin";
            this.Panelogin.Size = new System.Drawing.Size(400, 450);
            this.Panelogin.TabIndex = 7;
            // 
            // pnlUsuarioLine
            // 
            this.pnlUsuarioLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.pnlUsuarioLine.Location = new System.Drawing.Point(186, 191);
            this.pnlUsuarioLine.Name = "pnlUsuarioLine";
            this.pnlUsuarioLine.Size = new System.Drawing.Size(153, 2);
            this.pnlUsuarioLine.TabIndex = 15;
            // 
            // pnlClaveLine
            // 
            this.pnlClaveLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.pnlClaveLine.Location = new System.Drawing.Point(186, 238);
            this.pnlClaveLine.Name = "pnlClaveLine";
            this.pnlClaveLine.Size = new System.Drawing.Size(153, 2);
            this.pnlClaveLine.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.label8.Location = new System.Drawing.Point(92, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(247, 38);
            this.label8.TabIndex = 13;
            this.label8.Text = "INICIAR SECION ";
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.pnlSidebar.Controls.Add(this.panel1);
            this.pnlSidebar.Controls.Add(this.pictureBox1);
            this.pnlSidebar.Controls.Add(this.label10);
            this.pnlSidebar.Controls.Add(this.label9);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSidebar.Location = new System.Drawing.Point(1029, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(205, 450);
            this.pnlSidebar.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 450);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::practicaDeModulo.Properties.Resources.eicon;
            this.pictureBox1.Location = new System.Drawing.Point(56, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 81);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.label10.Location = new System.Drawing.Point(32, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 392);
            this.label10.TabIndex = 17;
            this.label10.Text = "Este es nuestra app educativa con un estilo moderno el cual busca captar la atenc" +
    "ion de cada uno de las persona que busquen aprender o poner a prueba sus conocim" +
    "ientos\r\n";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label9.Location = new System.Drawing.Point(12, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 80);
            this.label9.TabIndex = 16;
            this.label9.Text = "SISTEMA DE\r\n  LOGIN\r\n";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1234, 450);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.Panelogin);
            this.Controls.Add(this.panelRegistro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelRegistro.ResumeLayout(false);
            this.panelRegistro.PerformLayout();
            this.Panelogin.ResumeLayout(false);
            this.Panelogin.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button Aceptarbtn;
        private System.Windows.Forms.Panel panelRegistro;
        private System.Windows.Forms.TextBox txtUsuarioR;
        private System.Windows.Forms.TextBox txtClaveRegistro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel Panelogin;
        private System.Windows.Forms.TextBox txtconfirmarClaveRegistro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button Volverbtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlUsuarioLine;
        private System.Windows.Forms.Panel pnlClaveLine;
        private System.Windows.Forms.Panel pnlconfirmarClaveRegistroLine;
        private System.Windows.Forms.Panel pnlUsuarioRLine;
        private System.Windows.Forms.Panel pnlClaveRegistroLine;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

