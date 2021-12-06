
namespace Aplicacion_Qmax_Instaladores
{
    partial class Configuracion
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
            this.label4 = new System.Windows.Forms.Label();
            this.Texto_Capacidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Texto_Perfil = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Texto_Modo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Capacidad del Banco";
            // 
            // Texto_Capacidad
            // 
            this.Texto_Capacidad.Location = new System.Drawing.Point(31, 245);
            this.Texto_Capacidad.Name = "Texto_Capacidad";
            this.Texto_Capacidad.Size = new System.Drawing.Size(149, 20);
            this.Texto_Capacidad.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Perfil de Baterías";
            // 
            // Texto_Perfil
            // 
            this.Texto_Perfil.Location = new System.Drawing.Point(31, 180);
            this.Texto_Perfil.Name = "Texto_Perfil";
            this.Texto_Perfil.Size = new System.Drawing.Size(149, 20);
            this.Texto_Perfil.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Modo de Funcionamiento";
            // 
            // Texto_Modo
            // 
            this.Texto_Modo.Location = new System.Drawing.Point(31, 84);
            this.Texto_Modo.Name = "Texto_Modo";
            this.Texto_Modo.Size = new System.Drawing.Size(149, 20);
            this.Texto_Modo.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sistema";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Baterías";
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Texto_Modo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Texto_Perfil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Texto_Capacidad);
            this.Name = "Configuracion";
            this.Text = "Configuracion";
            this.Load += new System.EventHandler(this.Configuracion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Texto_Capacidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Texto_Perfil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Texto_Modo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}