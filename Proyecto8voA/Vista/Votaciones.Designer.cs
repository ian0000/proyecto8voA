
namespace Proyecto8voA.Vista
{
    partial class Votaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Votaciones));
            this.CB_Partido = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Presidente = new System.Windows.Forms.Label();
            this.Txt_Vice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Cedula = new System.Windows.Forms.Label();
            this.CheckNulo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ImagenVice = new System.Windows.Forms.PictureBox();
            this.Imagen_Presidente = new System.Windows.Forms.PictureBox();
            this.Imagen_Partido = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenVice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen_Presidente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen_Partido)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_Partido
            // 
            this.CB_Partido.FormattingEnabled = true;
            this.CB_Partido.Location = new System.Drawing.Point(170, 96);
            this.CB_Partido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CB_Partido.Name = "CB_Partido";
            this.CB_Partido.Size = new System.Drawing.Size(207, 24);
            this.CB_Partido.TabIndex = 1;
            this.CB_Partido.SelectionChangeCommitted += new System.EventHandler(this.CB_Partido_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Partido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 331);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Presidente";
            // 
            // Txt_Presidente
            // 
            this.Txt_Presidente.AutoSize = true;
            this.Txt_Presidente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Presidente.Location = new System.Drawing.Point(55, 359);
            this.Txt_Presidente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_Presidente.Name = "Txt_Presidente";
            this.Txt_Presidente.Size = new System.Drawing.Size(62, 17);
            this.Txt_Presidente.TabIndex = 5;
            this.Txt_Presidente.Text = "nombre";
            // 
            // Txt_Vice
            // 
            this.Txt_Vice.AutoSize = true;
            this.Txt_Vice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Vice.Location = new System.Drawing.Point(353, 359);
            this.Txt_Vice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_Vice.Name = "Txt_Vice";
            this.Txt_Vice.Size = new System.Drawing.Size(62, 17);
            this.Txt_Vice.TabIndex = 8;
            this.Txt_Vice.Text = "nombre";
            this.Txt_Vice.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(353, 331);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Vicepresidente";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Txt_Cedula
            // 
            this.Txt_Cedula.AutoSize = true;
            this.Txt_Cedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Cedula.Location = new System.Drawing.Point(388, 35);
            this.Txt_Cedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_Cedula.Name = "Txt_Cedula";
            this.Txt_Cedula.Size = new System.Drawing.Size(63, 17);
            this.Txt_Cedula.TabIndex = 11;
            this.Txt_Cedula.Text = "Cédula:";
            // 
            // CheckNulo
            // 
            this.CheckNulo.AutoSize = true;
            this.CheckNulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckNulo.Location = new System.Drawing.Point(391, 98);
            this.CheckNulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CheckNulo.Name = "CheckNulo";
            this.CheckNulo.Size = new System.Drawing.Size(63, 21);
            this.CheckNulo.TabIndex = 12;
            this.CheckNulo.Text = "Nulo";
            this.CheckNulo.UseVisualStyleBackColor = true;
            this.CheckNulo.CheckedChanged += new System.EventHandler(this.CheckNulo_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro Voto";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.CheckNulo);
            this.panel1.Controls.Add(this.Txt_Cedula);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ImagenVice);
            this.panel1.Controls.Add(this.Txt_Vice);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Imagen_Presidente);
            this.panel1.Controls.Add(this.Txt_Presidente);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Imagen_Partido);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CB_Partido);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(13, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 681);
            this.panel1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Proyecto8voA.Properties.Resources.votar;
            this.button1.Location = new System.Drawing.Point(170, 586);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 67);
            this.button1.TabIndex = 10;
            this.button1.Text = "Enviar Voto";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ImagenVice
            // 
            this.ImagenVice.Location = new System.Drawing.Point(356, 395);
            this.ImagenVice.Margin = new System.Windows.Forms.Padding(4);
            this.ImagenVice.Name = "ImagenVice";
            this.ImagenVice.Size = new System.Drawing.Size(133, 160);
            this.ImagenVice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenVice.TabIndex = 9;
            this.ImagenVice.TabStop = false;
            this.ImagenVice.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Imagen_Presidente
            // 
            this.Imagen_Presidente.Location = new System.Drawing.Point(58, 395);
            this.Imagen_Presidente.Margin = new System.Windows.Forms.Padding(4);
            this.Imagen_Presidente.Name = "Imagen_Presidente";
            this.Imagen_Presidente.Size = new System.Drawing.Size(133, 160);
            this.Imagen_Presidente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imagen_Presidente.TabIndex = 6;
            this.Imagen_Presidente.TabStop = false;
            // 
            // Imagen_Partido
            // 
            this.Imagen_Partido.Location = new System.Drawing.Point(169, 146);
            this.Imagen_Partido.Margin = new System.Windows.Forms.Padding(4);
            this.Imagen_Partido.Name = "Imagen_Partido";
            this.Imagen_Partido.Size = new System.Drawing.Size(208, 155);
            this.Imagen_Partido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imagen_Partido.TabIndex = 3;
            this.Imagen_Partido.TabStop = false;
            // 
            // Votaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 713);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Votaciones";
            this.Text = "Votaciones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Votaciones_FormClosing);
            this.Load += new System.EventHandler(this.Votaciones_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenVice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen_Presidente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen_Partido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_Partido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Imagen_Partido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Txt_Presidente;
        private System.Windows.Forms.PictureBox Imagen_Presidente;
        private System.Windows.Forms.PictureBox ImagenVice;
        private System.Windows.Forms.Label Txt_Vice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label Txt_Cedula;
        private System.Windows.Forms.CheckBox CheckNulo;
        private System.Windows.Forms.Panel panel1;
    }
}