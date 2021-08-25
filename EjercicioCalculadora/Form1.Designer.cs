
namespace EjercicioCalculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BotonLimpiar = new System.Windows.Forms.Button();
            this.BotonResultado = new System.Windows.Forms.Button();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.EtiquetaSuma = new System.Windows.Forms.Label();
            this.EtiquetaValor1 = new System.Windows.Forms.Label();
            this.EtiquetaValor2 = new System.Windows.Forms.Label();
            this.EtiquetaResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BotonLimpiar
            // 
            this.BotonLimpiar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BotonLimpiar.Location = new System.Drawing.Point(683, 159);
            this.BotonLimpiar.Name = "BotonLimpiar";
            this.BotonLimpiar.Size = new System.Drawing.Size(50, 50);
            this.BotonLimpiar.TabIndex = 5;
            this.BotonLimpiar.Text = "C";
            this.BotonLimpiar.UseVisualStyleBackColor = true;
            this.BotonLimpiar.Click += new System.EventHandler(this.BotonLimpiar_Click);
            // 
            // BotonResultado
            // 
            this.BotonResultado.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BotonResultado.Location = new System.Drawing.Point(435, 159);
            this.BotonResultado.Name = "BotonResultado";
            this.BotonResultado.Size = new System.Drawing.Size(50, 50);
            this.BotonResultado.TabIndex = 3;
            this.BotonResultado.Text = "=";
            this.BotonResultado.UseVisualStyleBackColor = true;
            this.BotonResultado.Click += new System.EventHandler(this.BotonResultado_Click);
            // 
            // txtValor1
            // 
            this.txtValor1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValor1.Location = new System.Drawing.Point(39, 166);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(152, 36);
            this.txtValor1.TabIndex = 1;
            this.txtValor1.Text = "0";
            this.txtValor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtValor2
            // 
            this.txtValor2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValor2.Location = new System.Drawing.Point(263, 166);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(152, 36);
            this.txtValor2.TabIndex = 2;
            this.txtValor2.Text = "0";
            this.txtValor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResultado.Enabled = false;
            this.txtResultado.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResultado.Location = new System.Drawing.Point(507, 166);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(152, 36);
            this.txtResultado.TabIndex = 4;
            this.txtResultado.Text = "0";
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // EtiquetaSuma
            // 
            this.EtiquetaSuma.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EtiquetaSuma.Location = new System.Drawing.Point(218, 169);
            this.EtiquetaSuma.Name = "EtiquetaSuma";
            this.EtiquetaSuma.Size = new System.Drawing.Size(26, 36);
            this.EtiquetaSuma.TabIndex = 6;
            this.EtiquetaSuma.Text = "+";
            // 
            // EtiquetaValor1
            // 
            this.EtiquetaValor1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EtiquetaValor1.Location = new System.Drawing.Point(39, 127);
            this.EtiquetaValor1.Name = "EtiquetaValor1";
            this.EtiquetaValor1.Size = new System.Drawing.Size(83, 36);
            this.EtiquetaValor1.TabIndex = 7;
            this.EtiquetaValor1.Text = "Valor 1";
            // 
            // EtiquetaValor2
            // 
            this.EtiquetaValor2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EtiquetaValor2.Location = new System.Drawing.Point(263, 127);
            this.EtiquetaValor2.Name = "EtiquetaValor2";
            this.EtiquetaValor2.Size = new System.Drawing.Size(83, 36);
            this.EtiquetaValor2.TabIndex = 8;
            this.EtiquetaValor2.Text = "Valor 2";
            // 
            // EtiquetaResultado
            // 
            this.EtiquetaResultado.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EtiquetaResultado.Location = new System.Drawing.Point(507, 127);
            this.EtiquetaResultado.Name = "EtiquetaResultado";
            this.EtiquetaResultado.Size = new System.Drawing.Size(108, 36);
            this.EtiquetaResultado.TabIndex = 9;
            this.EtiquetaResultado.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EtiquetaResultado);
            this.Controls.Add(this.EtiquetaValor2);
            this.Controls.Add(this.EtiquetaValor1);
            this.Controls.Add(this.EtiquetaSuma);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.BotonResultado);
            this.Controls.Add(this.BotonLimpiar);
            this.Name = "Form1";
            this.Text = "Calculadora Primitiva";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonLimpiar;
        private System.Windows.Forms.Button BotonResultado;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label EtiquetaSuma;
        private System.Windows.Forms.Label EtiquetaValor1;
        private System.Windows.Forms.Label EtiquetaValor2;
        private System.Windows.Forms.Label EtiquetaResultado;
    }
}

