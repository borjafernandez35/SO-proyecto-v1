namespace WindowsFormsApp1
{
    partial class Registro
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
            this.nombre = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.aceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mostrar = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(298, 102);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(122, 22);
            this.nombre.TabIndex = 0;
            // 
            // contraseña
            // 
            this.contraseña.Location = new System.Drawing.Point(298, 157);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(122, 22);
            this.contraseña.TabIndex = 1;
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(320, 252);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(85, 42);
            this.aceptar.TabIndex = 2;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // mostrar
            // 
            this.mostrar.AutoSize = true;
            this.mostrar.Location = new System.Drawing.Point(298, 195);
            this.mostrar.Name = "mostrar";
            this.mostrar.Size = new System.Drawing.Size(153, 21);
            this.mostrar.TabIndex = 5;
            this.mostrar.Text = "Mostrar contraseña";
            this.mostrar.UseVisualStyleBackColor = true;
            this.mostrar.CheckedChanged += new System.EventHandler(this.mostrar_CheckedChanged);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 375);
            this.Controls.Add(this.mostrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.nombre);
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox mostrar;
    }
}