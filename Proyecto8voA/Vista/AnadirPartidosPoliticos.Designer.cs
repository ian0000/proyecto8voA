
namespace Proyecto8voA.Vista
{
    partial class AnadirPartidosPoliticos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnadirPartidosPoliticos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_CargarFoto = new System.Windows.Forms.Button();
            this.Ver_Imagen = new System.Windows.Forms.PictureBox();
            this.Txt_Nombre_p = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Ventana_Seleccionar = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ver_Imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Btn_CargarFoto);
            this.panel1.Controls.Add(this.Ver_Imagen);
            this.panel1.Controls.Add(this.Txt_Nombre_p);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Btn_Eliminar);
            this.panel1.Controls.Add(this.Btn_Modificar);
            this.panel1.Controls.Add(this.Btn_Guardar);
            this.panel1.Location = new System.Drawing.Point(10, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 367);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Btn_CargarFoto
            // 
            this.Btn_CargarFoto.Location = new System.Drawing.Point(125, 258);
            this.Btn_CargarFoto.Name = "Btn_CargarFoto";
            this.Btn_CargarFoto.Size = new System.Drawing.Size(145, 36);
            this.Btn_CargarFoto.TabIndex = 7;
            this.Btn_CargarFoto.Text = "Seleccionar foto";
            this.Btn_CargarFoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_CargarFoto.UseVisualStyleBackColor = true;
            this.Btn_CargarFoto.Click += new System.EventHandler(this.Btn_CargarFoto_Click);
            // 
            // Ver_Imagen
            // 
            this.Ver_Imagen.Location = new System.Drawing.Point(98, 84);
            this.Ver_Imagen.Name = "Ver_Imagen";
            this.Ver_Imagen.Size = new System.Drawing.Size(194, 167);
            this.Ver_Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ver_Imagen.TabIndex = 6;
            this.Ver_Imagen.TabStop = false;
            // 
            // Txt_Nombre_p
            // 
            this.Txt_Nombre_p.Location = new System.Drawing.Point(98, 33);
            this.Txt_Nombre_p.MaxLength = 45;
            this.Txt_Nombre_p.Multiline = true;
            this.Txt_Nombre_p.Name = "Txt_Nombre_p";
            this.Txt_Nombre_p.Size = new System.Drawing.Size(243, 20);
            this.Txt_Nombre_p.TabIndex = 5;
            this.Txt_Nombre_p.TextChanged += new System.EventHandler(this.Txt_change_nombre);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Foto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre Partido";
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Location = new System.Drawing.Point(268, 314);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(99, 36);
            this.Btn_Eliminar.TabIndex = 2;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.Location = new System.Drawing.Point(145, 314);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(99, 36);
            this.Btn_Modificar.TabIndex = 1;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Modificar.UseVisualStyleBackColor = true;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(20, 314);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(99, 36);
            this.Btn_Guardar.TabIndex = 0;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Ventana_Seleccionar
            // 
            this.Ventana_Seleccionar.FileName = "openFileDialog1";
            // 
            // AnadirPartidosPoliticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(413, 388);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnadirPartidosPoliticos";
            this.Text = "AnadirPartidosPoliticos";
            this.Load += new System.EventHandler(this.AnadirPartidosPoliticos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ver_Imagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_CargarFoto;
        private System.Windows.Forms.PictureBox Ver_Imagen;
        private System.Windows.Forms.TextBox Txt_Nombre_p;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.OpenFileDialog Ventana_Seleccionar;
    }
}