namespace WindowsFormsApp1
{
    partial class Consultas
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
            this.nombres = new System.Windows.Forms.RadioButton();
            this.puntos = new System.Windows.Forms.RadioButton();
            this.partidas = new System.Windows.Forms.RadioButton();
            this.historial = new System.Windows.Forms.RadioButton();
            this.id = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Enviar = new System.Windows.Forms.Button();
            this.conectar = new System.Windows.Forms.Button();
            this.Desconectar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombres
            // 
            this.nombres.AutoSize = true;
            this.nombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombres.Location = new System.Drawing.Point(33, 130);
            this.nombres.Name = "nombres";
            this.nombres.Size = new System.Drawing.Size(405, 22);
            this.nombres.TabIndex = 0;
            this.nombres.TabStop = true;
            this.nombres.Text = "Dime cuantos jugadores hay en una partida y quienes son";
            this.nombres.UseVisualStyleBackColor = true;
            // 
            // puntos
            // 
            this.puntos.AutoSize = true;
            this.puntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntos.Location = new System.Drawing.Point(31, 245);
            this.puntos.Name = "puntos";
            this.puntos.Size = new System.Drawing.Size(348, 22);
            this.puntos.TabIndex = 1;
            this.puntos.TabStop = true;
            this.puntos.Text = "Dime sus puntos y si ganó sus últimas 3 partidas";
            this.puntos.UseVisualStyleBackColor = true;
            // 
            // partidas
            // 
            this.partidas.AutoSize = true;
            this.partidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partidas.Location = new System.Drawing.Point(31, 273);
            this.partidas.Name = "partidas";
            this.partidas.Size = new System.Drawing.Size(407, 22);
            this.partidas.TabIndex = 2;
            this.partidas.TabStop = true;
            this.partidas.Text = "Dime cuantas partidas ha ganado con su fecha y duración";
            this.partidas.UseVisualStyleBackColor = true;
            // 
            // historial
            // 
            this.historial.AutoSize = true;
            this.historial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historial.Location = new System.Drawing.Point(31, 31);
            this.historial.Name = "historial";
            this.historial.Size = new System.Drawing.Size(612, 22);
            this.historial.TabIndex = 3;
            this.historial.TabStop = true;
            this.historial.Text = "Dime cuantas pruebas se hicieron en la última partida, su nombre y los puntos que" +
    " dieron";
            this.historial.UseVisualStyleBackColor = true;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(162, 104);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 20);
            this.id.TabIndex = 4;
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(162, 210);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(100, 20);
            this.nom.TabIndex = 5;
            this.nom.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID partida";
            // 
            // Enviar
            // 
            this.Enviar.Location = new System.Drawing.Point(368, 325);
            this.Enviar.Name = "Enviar";
            this.Enviar.Size = new System.Drawing.Size(125, 54);
            this.Enviar.TabIndex = 8;
            this.Enviar.Text = "Enviar";
            this.Enviar.UseVisualStyleBackColor = true;
            this.Enviar.Click += new System.EventHandler(this.Enviar_Click);
            // 
            // conectar
            // 
            this.conectar.Location = new System.Drawing.Point(630, 121);
            this.conectar.Name = "conectar";
            this.conectar.Size = new System.Drawing.Size(134, 58);
            this.conectar.TabIndex = 9;
            this.conectar.Text = "Conectar";
            this.conectar.UseVisualStyleBackColor = true;
            this.conectar.Click += new System.EventHandler(this.conectar_Click);
            // 
            // Desconectar
            // 
            this.Desconectar.Location = new System.Drawing.Point(630, 206);
            this.Desconectar.Name = "Desconectar";
            this.Desconectar.Size = new System.Drawing.Size(134, 61);
            this.Desconectar.TabIndex = 10;
            this.Desconectar.Text = "Desconectar";
            this.Desconectar.UseVisualStyleBackColor = true;
            this.Desconectar.Click += new System.EventHandler(this.Desconectar_Click);
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 404);
            this.Controls.Add(this.Desconectar);
            this.Controls.Add(this.conectar);
            this.Controls.Add(this.Enviar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.id);
            this.Controls.Add(this.historial);
            this.Controls.Add(this.partidas);
            this.Controls.Add(this.puntos);
            this.Controls.Add(this.nombres);
            this.Name = "Consultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton nombres;
        private System.Windows.Forms.RadioButton puntos;
        private System.Windows.Forms.RadioButton partidas;
        private System.Windows.Forms.RadioButton historial;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Enviar;
        private System.Windows.Forms.Button conectar;
        private System.Windows.Forms.Button Desconectar;
    }
}