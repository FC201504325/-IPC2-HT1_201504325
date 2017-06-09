namespace _IPC2_HT1_201504325
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Input1 = new System.Windows.Forms.TextBox();
            this.Input2 = new System.Windows.Forms.TextBox();
            this.Input3 = new System.Windows.Forms.TextBox();
            this.Funcion1 = new System.Windows.Forms.Button();
            this.Funcion2 = new System.Windows.Forms.Button();
            this.Funcion3 = new System.Windows.Forms.Button();
            this.Funcion4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.Funcion4);
            this.panel1.Controls.Add(this.Funcion3);
            this.panel1.Controls.Add(this.Funcion2);
            this.panel1.Controls.Add(this.Funcion1);
            this.panel1.Controls.Add(this.Input3);
            this.panel1.Controls.Add(this.Input2);
            this.panel1.Controls.Add(this.Input1);
            this.panel1.Location = new System.Drawing.Point(2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 498);
            this.panel1.TabIndex = 0;
            // 
            // Input1
            // 
            this.Input1.BackColor = System.Drawing.Color.Black;
            this.Input1.ForeColor = System.Drawing.Color.Red;
            this.Input1.Location = new System.Drawing.Point(67, 143);
            this.Input1.Name = "Input1";
            this.Input1.Size = new System.Drawing.Size(126, 26);
            this.Input1.TabIndex = 0;
            // 
            // Input2
            // 
            this.Input2.BackColor = System.Drawing.Color.Black;
            this.Input2.ForeColor = System.Drawing.Color.Red;
            this.Input2.Location = new System.Drawing.Point(257, 143);
            this.Input2.Name = "Input2";
            this.Input2.Size = new System.Drawing.Size(124, 26);
            this.Input2.TabIndex = 1;
            // 
            // Input3
            // 
            this.Input3.BackColor = System.Drawing.Color.Black;
            this.Input3.ForeColor = System.Drawing.Color.Red;
            this.Input3.Location = new System.Drawing.Point(441, 143);
            this.Input3.Name = "Input3";
            this.Input3.Size = new System.Drawing.Size(126, 26);
            this.Input3.TabIndex = 2;
            // 
            // Funcion1
            // 
            this.Funcion1.Location = new System.Drawing.Point(146, 267);
            this.Funcion1.Name = "Funcion1";
            this.Funcion1.Size = new System.Drawing.Size(92, 49);
            this.Funcion1.TabIndex = 3;
            this.Funcion1.Text = "Funcion Triangulo";
            this.Funcion1.UseVisualStyleBackColor = true;
            this.Funcion1.Click += new System.EventHandler(this.Funcion1_Click);
            // 
            // Funcion2
            // 
            this.Funcion2.Location = new System.Drawing.Point(393, 267);
            this.Funcion2.Name = "Funcion2";
            this.Funcion2.Size = new System.Drawing.Size(110, 49);
            this.Funcion2.TabIndex = 4;
            this.Funcion2.Text = "Funcion Vocales";
            this.Funcion2.UseVisualStyleBackColor = true;
            // 
            // Funcion3
            // 
            this.Funcion3.Location = new System.Drawing.Point(146, 359);
            this.Funcion3.Name = "Funcion3";
            this.Funcion3.Size = new System.Drawing.Size(92, 80);
            this.Funcion3.TabIndex = 5;
            this.Funcion3.Text = "Funcion Invertir";
            this.Funcion3.UseVisualStyleBackColor = true;
            // 
            // Funcion4
            // 
            this.Funcion4.Location = new System.Drawing.Point(393, 359);
            this.Funcion4.Name = "Funcion4";
            this.Funcion4.Size = new System.Drawing.Size(110, 80);
            this.Funcion4.TabIndex = 6;
            this.Funcion4.Text = "Funcion Regla de Tres";
            this.Funcion4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 497);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Funcion4;
        private System.Windows.Forms.Button Funcion3;
        private System.Windows.Forms.Button Funcion2;
        private System.Windows.Forms.Button Funcion1;
        private System.Windows.Forms.TextBox Input3;
        private System.Windows.Forms.TextBox Input2;
        private System.Windows.Forms.TextBox Input1;
    }
}

