
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
            this.label2 = new System.Windows.Forms.Label();
            this.Texto_Modo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textConfig = new System.Windows.Forms.TextBox();
            this.BtnInicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Modo de Funcionamiento";
            // 
            // Texto_Modo
            // 
            this.Texto_Modo.Location = new System.Drawing.Point(31, 62);
            this.Texto_Modo.Name = "Texto_Modo";
            this.Texto_Modo.Size = new System.Drawing.Size(149, 20);
            this.Texto_Modo.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Configuración Recomendada";
            // 
            // textConfig
            // 
            this.textConfig.Location = new System.Drawing.Point(31, 101);
            this.textConfig.Multiline = true;
            this.textConfig.Name = "textConfig";
            this.textConfig.Size = new System.Drawing.Size(149, 132);
            this.textConfig.TabIndex = 14;
            // 
            // BtnInicio
            // 
            this.BtnInicio.Location = new System.Drawing.Point(65, 253);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Size = new System.Drawing.Size(75, 23);
            this.BtnInicio.TabIndex = 15;
            this.BtnInicio.Text = "Aceptar";
            this.BtnInicio.UseVisualStyleBackColor = true;
            this.BtnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 299);
            this.Controls.Add(this.BtnInicio);
            this.Controls.Add(this.textConfig);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Texto_Modo);
            this.Name = "Configuracion";
            this.Text = "Configuracion";
            this.Load += new System.EventHandler(this.Configuracion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox Texto_Modo;
        private System.Windows.Forms.TextBox textConfig;
        private System.Windows.Forms.Button BtnInicio;
    }
}