
namespace Proyecto8voA.Vista
{
    partial class Inicio
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
            this.Btn_AVotantes = new System.Windows.Forms.Button();
            this.Btn_APartidoPolitico = new System.Windows.Forms.Button();
            this.Btn_ACandidato = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_AVotantes
            // 
            this.Btn_AVotantes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_AVotantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AVotantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AVotantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_AVotantes.Location = new System.Drawing.Point(123, 182);
            this.Btn_AVotantes.Name = "Btn_AVotantes";
            this.Btn_AVotantes.Size = new System.Drawing.Size(185, 51);
            this.Btn_AVotantes.TabIndex = 2;
            this.Btn_AVotantes.Text = "Añadir Votantes";
            this.Btn_AVotantes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_AVotantes.UseVisualStyleBackColor = true;
            this.Btn_AVotantes.Click += new System.EventHandler(this.Btn_AVotantes_Click);
            // 
            // Btn_APartidoPolitico
            // 
            this.Btn_APartidoPolitico.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_APartidoPolitico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_APartidoPolitico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_APartidoPolitico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_APartidoPolitico.Location = new System.Drawing.Point(123, 117);
            this.Btn_APartidoPolitico.Name = "Btn_APartidoPolitico";
            this.Btn_APartidoPolitico.Size = new System.Drawing.Size(185, 50);
            this.Btn_APartidoPolitico.TabIndex = 1;
            this.Btn_APartidoPolitico.Text = "Añadir Partido Politico";
            this.Btn_APartidoPolitico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_APartidoPolitico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_APartidoPolitico.UseVisualStyleBackColor = true;
            this.Btn_APartidoPolitico.Click += new System.EventHandler(this.Btn_APartidoPolitico_Click);
            // 
            // Btn_ACandidato
            // 
            this.Btn_ACandidato.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_ACandidato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ACandidato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ACandidato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ACandidato.Location = new System.Drawing.Point(123, 59);
            this.Btn_ACandidato.Name = "Btn_ACandidato";
            this.Btn_ACandidato.Size = new System.Drawing.Size(185, 51);
            this.Btn_ACandidato.TabIndex = 0;
            this.Btn_ACandidato.Text = "Añadir Candidato";
            this.Btn_ACandidato.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ACandidato.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_ACandidato.UseVisualStyleBackColor = true;
            this.Btn_ACandidato.Click += new System.EventHandler(this.Btn_ACandidato_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Btn_AVotantes);
            this.panel1.Controls.Add(this.Btn_APartidoPolitico);
            this.panel1.Controls.Add(this.Btn_ACandidato);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 314);
            this.panel1.TabIndex = 3;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 330);
            this.Controls.Add(this.panel1);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inicio_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_ACandidato;
        private System.Windows.Forms.Button Btn_APartidoPolitico;
        private System.Windows.Forms.Button Btn_AVotantes;
        private System.Windows.Forms.Panel panel1;
    }
}