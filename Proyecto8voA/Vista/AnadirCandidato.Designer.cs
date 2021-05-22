
namespace Proyecto8voA
{
    partial class Form1
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
        /// este sirve
        /// 
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.labelObtenerNombreCandidato = new System.Windows.Forms.Label();
            this.labelNombreCandidato = new System.Windows.Forms.Label();
            this.Combox_Rol = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Combox_Partido = new System.Windows.Forms.ComboBox();
            this.Btn_CargarFoto = new System.Windows.Forms.Button();
            this.Ver_Imagen = new System.Windows.Forms.PictureBox();
            this.Txt_Cedula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Ventana_seleccionar = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ver_Imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.labelObtenerNombreCandidato);
            this.panel1.Controls.Add(this.labelNombreCandidato);
            this.panel1.Controls.Add(this.Combox_Rol);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Combox_Partido);
            this.panel1.Controls.Add(this.Btn_CargarFoto);
            this.panel1.Controls.Add(this.Ver_Imagen);
            this.panel1.Controls.Add(this.Txt_Cedula);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Btn_Eliminar);
            this.panel1.Controls.Add(this.Btn_Modificar);
            this.panel1.Controls.Add(this.Btn_Guardar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 317);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Dispositivos";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(494, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 21);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(266, 212);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "ActivarCamara";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // labelObtenerNombreCandidato
            // 
            this.labelObtenerNombreCandidato.AutoSize = true;
            this.labelObtenerNombreCandidato.Location = new System.Drawing.Point(72, 54);
            this.labelObtenerNombreCandidato.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelObtenerNombreCandidato.Name = "labelObtenerNombreCandidato";
            this.labelObtenerNombreCandidato.Size = new System.Drawing.Size(35, 13);
            this.labelObtenerNombreCandidato.TabIndex = 13;
            this.labelObtenerNombreCandidato.Text = "label5";
            // 
            // labelNombreCandidato
            // 
            this.labelNombreCandidato.AutoSize = true;
            this.labelNombreCandidato.Location = new System.Drawing.Point(16, 54);
            this.labelNombreCandidato.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombreCandidato.Name = "labelNombreCandidato";
            this.labelNombreCandidato.Size = new System.Drawing.Size(44, 13);
            this.labelNombreCandidato.TabIndex = 12;
            this.labelNombreCandidato.Text = "Nombre";
            // 
            // Combox_Rol
            // 
            this.Combox_Rol.FormattingEnabled = true;
            this.Combox_Rol.Items.AddRange(new object[] {
            " ",
            "Presidente",
            "Vicepresidente"});
            this.Combox_Rol.Location = new System.Drawing.Point(72, 166);
            this.Combox_Rol.Name = "Combox_Rol";
            this.Combox_Rol.Size = new System.Drawing.Size(128, 21);
            this.Combox_Rol.TabIndex = 11;
            this.Combox_Rol.SelectedIndexChanged += new System.EventHandler(this.Combox_Rol_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Rol";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Partido";
            // 
            // Combox_Partido
            // 
            this.Combox_Partido.FormattingEnabled = true;
            this.Combox_Partido.Location = new System.Drawing.Point(72, 128);
            this.Combox_Partido.Name = "Combox_Partido";
            this.Combox_Partido.Size = new System.Drawing.Size(128, 21);
            this.Combox_Partido.TabIndex = 8;
            // 
            // Btn_CargarFoto
            // 
            this.Btn_CargarFoto.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_CargarFoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_CargarFoto.Location = new System.Drawing.Point(245, 169);
            this.Btn_CargarFoto.Name = "Btn_CargarFoto";
            this.Btn_CargarFoto.Size = new System.Drawing.Size(140, 37);
            this.Btn_CargarFoto.TabIndex = 7;
            this.Btn_CargarFoto.Text = "Seleccionar foto";
            this.Btn_CargarFoto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_CargarFoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_CargarFoto.UseVisualStyleBackColor = false;
            this.Btn_CargarFoto.Click += new System.EventHandler(this.Btn_CargarFoto_Click);
            // 
            // Ver_Imagen
            // 
            this.Ver_Imagen.Location = new System.Drawing.Point(245, 33);
            this.Ver_Imagen.Name = "Ver_Imagen";
            this.Ver_Imagen.Size = new System.Drawing.Size(140, 129);
            this.Ver_Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ver_Imagen.TabIndex = 6;
            this.Ver_Imagen.TabStop = false;
            // 
            // Txt_Cedula
            // 
            this.Txt_Cedula.Location = new System.Drawing.Point(72, 89);
            this.Txt_Cedula.MaxLength = 10;
            this.Txt_Cedula.Name = "Txt_Cedula";
            this.Txt_Cedula.Size = new System.Drawing.Size(128, 20);
            this.Txt_Cedula.TabIndex = 5;
            this.Txt_Cedula.TextChanged += new System.EventHandler(this.Txt_Cedula_TextChanged);
            this.Txt_Cedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Cedula_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Foto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cedula";
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Eliminar.Location = new System.Drawing.Point(274, 240);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(99, 37);
            this.Btn_Eliminar.TabIndex = 2;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Modificar.Location = new System.Drawing.Point(158, 240);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(94, 37);
            this.Btn_Modificar.TabIndex = 1;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Modificar.UseVisualStyleBackColor = false;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Guardar.Location = new System.Drawing.Point(49, 240);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(96, 37);
            this.Btn_Guardar.TabIndex = 0;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Guardar.UseVisualStyleBackColor = false;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Ventana_seleccionar
            // 
            this.Ventana_seleccionar.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(736, 339);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Añadir Candidatos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ver_Imagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_CargarFoto;
        private System.Windows.Forms.TextBox Txt_Cedula;
        private System.Windows.Forms.OpenFileDialog Ventana_seleccionar;
        private System.Windows.Forms.ComboBox Combox_Rol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Combox_Partido;
        private System.Windows.Forms.Label labelObtenerNombreCandidato;
        private System.Windows.Forms.Label labelNombreCandidato;
        public System.Windows.Forms.PictureBox Ver_Imagen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

