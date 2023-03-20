namespace wDibujarLasLineas
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
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtXInicial = new System.Windows.Forms.TextBox();
            this.txtXFinal = new System.Windows.Forms.TextBox();
            this.txtYInicial = new System.Windows.Forms.TextBox();
            this.txtYFinal = new System.Windows.Forms.TextBox();
            this.txtNumeroVeces = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xinicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS PGothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Xfinal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS PGothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(427, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yinicial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS PGothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(427, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yfinal";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(183, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Generar Linea";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(529, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cantidad de lineas";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtXInicial
            // 
            this.txtXInicial.Location = new System.Drawing.Point(126, 74);
            this.txtXInicial.Name = "txtXInicial";
            this.txtXInicial.Size = new System.Drawing.Size(121, 22);
            this.txtXInicial.TabIndex = 6;
            // 
            // txtXFinal
            // 
            this.txtXFinal.Location = new System.Drawing.Point(126, 140);
            this.txtXFinal.Name = "txtXFinal";
            this.txtXFinal.Size = new System.Drawing.Size(121, 22);
            this.txtXFinal.TabIndex = 7;
            // 
            // txtYInicial
            // 
            this.txtYInicial.Location = new System.Drawing.Point(493, 74);
            this.txtYInicial.Name = "txtYInicial";
            this.txtYInicial.Size = new System.Drawing.Size(121, 22);
            this.txtYInicial.TabIndex = 8;
            // 
            // txtYFinal
            // 
            this.txtYFinal.Location = new System.Drawing.Point(493, 146);
            this.txtYFinal.Name = "txtYFinal";
            this.txtYFinal.Size = new System.Drawing.Size(121, 22);
            this.txtYFinal.TabIndex = 9;
            // 
            // txtNumeroVeces
            // 
            this.txtNumeroVeces.Location = new System.Drawing.Point(534, 302);
            this.txtNumeroVeces.Name = "txtNumeroVeces";
            this.txtNumeroVeces.Size = new System.Drawing.Size(121, 22);
            this.txtNumeroVeces.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNumeroVeces);
            this.Controls.Add(this.txtYFinal);
            this.Controls.Add(this.txtYInicial);
            this.Controls.Add(this.txtXFinal);
            this.Controls.Add(this.txtXInicial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Lineas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtXInicial;
        private System.Windows.Forms.TextBox txtXFinal;
        private System.Windows.Forms.TextBox txtYInicial;
        private System.Windows.Forms.TextBox txtYFinal;
        private System.Windows.Forms.TextBox txtNumeroVeces;
    }
}

