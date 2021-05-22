
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
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Partido = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Imagen_Partido = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Presidente = new System.Windows.Forms.Label();
            this.Imagen_Presidente = new System.Windows.Forms.PictureBox();
            this.ImagenVice = new System.Windows.Forms.PictureBox();
            this.Txt_Vice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Txt_Cedula = new System.Windows.Forms.Label();
            this.CheckNulo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen_Partido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen_Presidente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenVice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Votaciones";
            // 
            // CB_Partido
            // 
            this.CB_Partido.FormattingEnabled = true;
            this.CB_Partido.Location = new System.Drawing.Point(122, 50);
            this.CB_Partido.Name = "CB_Partido";
            this.CB_Partido.Size = new System.Drawing.Size(144, 21);
            this.CB_Partido.TabIndex = 1;
            this.CB_Partido.SelectionChangeCommitted += new System.EventHandler(this.CB_Partido_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Partido";
            // 
            // Imagen_Partido
            // 
            this.Imagen_Partido.Location = new System.Drawing.Point(122, 88);
            this.Imagen_Partido.Name = "Imagen_Partido";
            this.Imagen_Partido.Size = new System.Drawing.Size(144, 126);
            this.Imagen_Partido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imagen_Partido.TabIndex = 3;
            this.Imagen_Partido.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Presidente";
            // 
            // Txt_Presidente
            // 
            this.Txt_Presidente.AutoSize = true;
            this.Txt_Presidente.Location = new System.Drawing.Point(73, 250);
            this.Txt_Presidente.Name = "Txt_Presidente";
            this.Txt_Presidente.Size = new System.Drawing.Size(42, 13);
            this.Txt_Presidente.TabIndex = 5;
            this.Txt_Presidente.Text = "nombre";
            // 
            // Imagen_Presidente
            // 
            this.Imagen_Presidente.Location = new System.Drawing.Point(15, 266);
            this.Imagen_Presidente.Name = "Imagen_Presidente";
            this.Imagen_Presidente.Size = new System.Drawing.Size(100, 130);
            this.Imagen_Presidente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imagen_Presidente.TabIndex = 6;
            this.Imagen_Presidente.TabStop = false;
            // 
            // ImagenVice
            // 
            this.ImagenVice.Location = new System.Drawing.Point(204, 266);
            this.ImagenVice.Name = "ImagenVice";
            this.ImagenVice.Size = new System.Drawing.Size(100, 130);
            this.ImagenVice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenVice.TabIndex = 9;
            this.ImagenVice.TabStop = false;
            this.ImagenVice.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Txt_Vice
            // 
            this.Txt_Vice.AutoSize = true;
            this.Txt_Vice.Location = new System.Drawing.Point(272, 250);
            this.Txt_Vice.Name = "Txt_Vice";
            this.Txt_Vice.Size = new System.Drawing.Size(42, 13);
            this.Txt_Vice.TabIndex = 8;
            this.Txt_Vice.Text = "nombre";
            this.Txt_Vice.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Vicepresidente";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Guardar Voto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Txt_Cedula
            // 
            this.Txt_Cedula.AutoSize = true;
            this.Txt_Cedula.Location = new System.Drawing.Point(285, 9);
            this.Txt_Cedula.Name = "Txt_Cedula";
            this.Txt_Cedula.Size = new System.Drawing.Size(39, 13);
            this.Txt_Cedula.TabIndex = 11;
            this.Txt_Cedula.Text = "cedula";
            // 
            // CheckNulo
            // 
            this.CheckNulo.AutoSize = true;
            this.CheckNulo.Location = new System.Drawing.Point(280, 50);
            this.CheckNulo.Name = "CheckNulo";
            this.CheckNulo.Size = new System.Drawing.Size(48, 17);
            this.CheckNulo.TabIndex = 12;
            this.CheckNulo.Text = "Nulo";
            this.CheckNulo.UseVisualStyleBackColor = true;
            this.CheckNulo.CheckedChanged += new System.EventHandler(this.CheckNulo_CheckedChanged);
            // 
            // Votaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 468);
            this.Controls.Add(this.CheckNulo);
            this.Controls.Add(this.Txt_Cedula);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ImagenVice);
            this.Controls.Add(this.Txt_Vice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Imagen_Presidente);
            this.Controls.Add(this.Txt_Presidente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Imagen_Partido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CB_Partido);
            this.Controls.Add(this.label1);
            this.Name = "Votaciones";
            this.Text = "Votaciones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Votaciones_FormClosing);
            this.Load += new System.EventHandler(this.Votaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Imagen_Partido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen_Presidente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenVice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}