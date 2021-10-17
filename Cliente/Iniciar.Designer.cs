namespace WindowsFormsApp1
{
    partial class Iniciar
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
            this.nombre = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inicio = new System.Windows.Forms.Button();
            this.mostrar = new System.Windows.Forms.CheckBox();
            this.registro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(177, 88);
            this.nombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(76, 20);
            this.nombre.TabIndex = 0;
            // 
            // contraseña
            // 
            this.contraseña.Location = new System.Drawing.Point(177, 145);
            this.contraseña.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(76, 20);
            this.contraseña.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contraseña";
            // 
            // inicio
            // 
            this.inicio.Location = new System.Drawing.Point(168, 232);
            this.inicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inicio.Name = "inicio";
            this.inicio.Size = new System.Drawing.Size(100, 40);
            this.inicio.TabIndex = 5;
            this.inicio.Text = "Iniciar";
            this.inicio.UseVisualStyleBackColor = true;
            this.inicio.Click += new System.EventHandler(this.inicio_Click);
            // 
            // mostrar
            // 
            this.mostrar.AutoSize = true;
            this.mostrar.Location = new System.Drawing.Point(177, 177);
            this.mostrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mostrar.Name = "mostrar";
            this.mostrar.Size = new System.Drawing.Size(117, 17);
            this.mostrar.TabIndex = 7;
            this.mostrar.Text = "Mostrar contraseña";
            this.mostrar.UseVisualStyleBackColor = true;
            this.mostrar.CheckedChanged += new System.EventHandler(this.mostrar_CheckedChanged);
            // 
            // registro
            // 
            this.registro.Location = new System.Drawing.Point(298, 280);
            this.registro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.registro.Name = "registro";
            this.registro.Size = new System.Drawing.Size(94, 41);
            this.registro.TabIndex = 8;
            this.registro.Text = "Registrarse";
            this.registro.UseVisualStyleBackColor = true;
            this.registro.Click += new System.EventHandler(this.registro_Click);
            // 
            // Iniciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 349);
            this.Controls.Add(this.registro);
            this.Controls.Add(this.mostrar);
            this.Controls.Add(this.inicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.nombre);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Iniciar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button inicio;
        private System.Windows.Forms.CheckBox mostrar;
        private System.Windows.Forms.Button registro;
    }
}

