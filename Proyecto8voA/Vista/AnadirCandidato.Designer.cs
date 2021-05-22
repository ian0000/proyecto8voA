
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.Txt_Cedula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Ventana_seleccionar = new System.Windows.Forms.OpenFileDialog();
            this.Btn_CargarFoto = new System.Windows.Forms.Button();
            this.Ver_Imagen = new System.Windows.Forms.PictureBox();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
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
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 476);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(617, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Dispositivos";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(743, 17);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 24);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(376, 265);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(135, 21);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "ActivarCamara";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // labelObtenerNombreCandidato
            // 
            this.labelObtenerNombreCandidato.AutoSize = true;
            this.labelObtenerNombreCandidato.Location = new System.Drawing.Point(96, 73);
            this.labelObtenerNombreCandidato.Name = "labelObtenerNombreCandidato";
            this.labelObtenerNombreCandidato.Size = new System.Drawing.Size(52, 17);
            this.labelObtenerNombreCandidato.TabIndex = 13;
            this.labelObtenerNombreCandidato.Text = "label5";
            // 
            // labelNombreCandidato
            // 
            this.labelNombreCandidato.AutoSize = true;
            this.labelNombreCandidato.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreCandidato.Location = new System.Drawing.Point(21, 73);
            this.labelNombreCandidato.Name = "labelNombreCandidato";
            this.labelNombreCandidato.Size = new System.Drawing.Size(69, 17);
            this.labelNombreCandidato.TabIndex = 12;
            this.labelNombreCandidato.Text = "Nombre:";
            // 
            // Combox_Rol
            // 
            this.Combox_Rol.FormattingEnabled = true;
            this.Combox_Rol.Items.AddRange(new object[] {
            " ",
            "Presidente",
            "Vicepresidente"});
            this.Combox_Rol.Location = new System.Drawing.Point(96, 233);
            this.Combox_Rol.Margin = new System.Windows.Forms.Padding(4);
            this.Combox_Rol.Name = "Combox_Rol";
            this.Combox_Rol.Size = new System.Drawing.Size(206, 24);
            this.Combox_Rol.TabIndex = 11;
            this.Combox_Rol.SelectedIndexChanged += new System.EventHandler(this.Combox_Rol_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 233);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Rol:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Partido:";
            // 
            // Combox_Partido
            // 
            this.Combox_Partido.FormattingEnabled = true;
            this.Combox_Partido.Location = new System.Drawing.Point(96, 179);
            this.Combox_Partido.Margin = new System.Windows.Forms.Padding(4);
            this.Combox_Partido.Name = "Combox_Partido";
            this.Combox_Partido.Size = new System.Drawing.Size(206, 24);
            this.Combox_Partido.TabIndex = 8;
            // 
            // Txt_Cedula
            // 
            this.Txt_Cedula.Location = new System.Drawing.Point(99, 123);
            this.Txt_Cedula.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Cedula.MaxLength = 10;
            this.Txt_Cedula.Name = "Txt_Cedula";
            this.Txt_Cedula.Size = new System.Drawing.Size(203, 22);
            this.Txt_Cedula.TabIndex = 5;
            this.Txt_Cedula.TextChanged += new System.EventHandler(this.Txt_Cedula_TextChanged);
            this.Txt_Cedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Cedula_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Foto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cédula:";
            // 
            // Ventana_seleccionar
            // 
            this.Ventana_seleccionar.FileName = "openFileDialog1";
            // 
            // Btn_CargarFoto
            // 
            this.Btn_CargarFoto.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_CargarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CargarFoto.Image = global::Proyecto8voA.Properties.Resources.camara;
            this.Btn_CargarFoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_CargarFoto.Location = new System.Drawing.Point(376, 211);
            this.Btn_CargarFoto.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_CargarFoto.Name = "Btn_CargarFoto";
            this.Btn_CargarFoto.Size = new System.Drawing.Size(187, 46);
            this.Btn_CargarFoto.TabIndex = 7;
            this.Btn_CargarFoto.Text = "Seleccionar foto";
            this.Btn_CargarFoto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_CargarFoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_CargarFoto.UseVisualStyleBackColor = false;
            this.Btn_CargarFoto.Click += new System.EventHandler(this.Btn_CargarFoto_Click);
            // 
            // Ver_Imagen
            // 
            this.Ver_Imagen.Location = new System.Drawing.Point(376, 44);
            this.Ver_Imagen.Margin = new System.Windows.Forms.Padding(4);
            this.Ver_Imagen.Name = "Ver_Imagen";
            this.Ver_Imagen.Size = new System.Drawing.Size(187, 159);
            this.Ver_Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ver_Imagen.TabIndex = 6;
            this.Ver_Imagen.TabStop = false;
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Eliminar.Image = global::Proyecto8voA.Properties.Resources.eliminar;
            this.Btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Eliminar.Location = new System.Drawing.Point(613, 376);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(157, 46);
            this.Btn_Eliminar.TabIndex = 2;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Modificar.Image = global::Proyecto8voA.Properties.Resources.editar;
            this.Btn_Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Modificar.Location = new System.Drawing.Point(376, 376);
            this.Btn_Modificar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(153, 46);
            this.Btn_Modificar.TabIndex = 1;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Modificar.UseVisualStyleBackColor = false;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Guardar.Image = global::Proyecto8voA.Properties.Resources.guardar;
            this.Btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Guardar.Location = new System.Drawing.Point(120, 376);
            this.Btn_Guardar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(157, 46);
            this.Btn_Guardar.TabIndex = 0;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Guardar.UseVisualStyleBackColor = false;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 504);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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

