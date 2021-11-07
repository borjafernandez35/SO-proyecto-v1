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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nombre = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inicio = new System.Windows.Forms.Button();
            this.Mostrar = new System.Windows.Forms.CheckBox();
            this.registro = new System.Windows.Forms.Button();
            this.historial = new System.Windows.Forms.RadioButton();
            this.nombres = new System.Windows.Forms.RadioButton();
            this.puntos = new System.Windows.Forms.RadioButton();
            this.partidas = new System.Windows.Forms.RadioButton();
            this.Enviar = new System.Windows.Forms.Button();
            this.conectar = new System.Windows.Forms.Button();
            this.Desconectar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.salir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nomb = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.MostrarRe = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Lista = new System.Windows.Forms.Button();
            this.conectados = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conectados)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(141, 65);
            this.nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 22);
            this.nombre.TabIndex = 0;
            // 
            // contraseña
            // 
            this.contraseña.Location = new System.Drawing.Point(141, 111);
            this.contraseña.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(100, 22);
            this.contraseña.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contraseña";
            // 
            // inicio
            // 
            this.inicio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.inicio.Location = new System.Drawing.Point(75, 191);
            this.inicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inicio.Name = "inicio";
            this.inicio.Size = new System.Drawing.Size(153, 41);
            this.inicio.TabIndex = 5;
            this.inicio.Text = "Iniciar";
            this.inicio.UseVisualStyleBackColor = true;
            this.inicio.Click += new System.EventHandler(this.inicio_Click);
            // 
            // Mostrar
            // 
            this.Mostrar.AutoSize = true;
            this.Mostrar.Location = new System.Drawing.Point(74, 152);
            this.Mostrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Size = new System.Drawing.Size(153, 21);
            this.Mostrar.TabIndex = 7;
            this.Mostrar.Text = "Mostrar contraseña";
            this.Mostrar.UseVisualStyleBackColor = true;
            this.Mostrar.CheckedChanged += new System.EventHandler(this.Mostrar_CheckedChanged);
            // 
            // registro
            // 
            this.registro.Location = new System.Drawing.Point(76, 192);
            this.registro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registro.Name = "registro";
            this.registro.Size = new System.Drawing.Size(162, 40);
            this.registro.TabIndex = 8;
            this.registro.Text = "Registrarse";
            this.registro.UseVisualStyleBackColor = true;
            this.registro.Click += new System.EventHandler(this.registro_Click);
            // 
            // historial
            // 
            this.historial.AutoSize = true;
            this.historial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historial.Location = new System.Drawing.Point(21, 413);
            this.historial.Margin = new System.Windows.Forms.Padding(4);
            this.historial.Name = "historial";
            this.historial.Size = new System.Drawing.Size(781, 28);
            this.historial.TabIndex = 9;
            this.historial.TabStop = true;
            this.historial.Text = "Dime cuantas pruebas se hicieron en la última partida, su nombre y los puntos que" +
    " dieron";
            this.historial.UseVisualStyleBackColor = true;
            // 
            // nombres
            // 
            this.nombres.AutoSize = true;
            this.nombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombres.Location = new System.Drawing.Point(21, 377);
            this.nombres.Margin = new System.Windows.Forms.Padding(4);
            this.nombres.Name = "nombres";
            this.nombres.Size = new System.Drawing.Size(518, 28);
            this.nombres.TabIndex = 10;
            this.nombres.TabStop = true;
            this.nombres.Text = "Dime cuantos jugadores hay en una partida y quienes son";
            this.nombres.UseVisualStyleBackColor = true;
            // 
            // puntos
            // 
            this.puntos.AutoSize = true;
            this.puntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntos.Location = new System.Drawing.Point(21, 474);
            this.puntos.Margin = new System.Windows.Forms.Padding(4);
            this.puntos.Name = "puntos";
            this.puntos.Size = new System.Drawing.Size(433, 28);
            this.puntos.TabIndex = 11;
            this.puntos.TabStop = true;
            this.puntos.Text = "Dime sus puntos y si ganó sus últimas 3 partidas";
            this.puntos.UseVisualStyleBackColor = true;
            // 
            // partidas
            // 
            this.partidas.AutoSize = true;
            this.partidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partidas.Location = new System.Drawing.Point(21, 508);
            this.partidas.Margin = new System.Windows.Forms.Padding(4);
            this.partidas.Name = "partidas";
            this.partidas.Size = new System.Drawing.Size(516, 28);
            this.partidas.TabIndex = 12;
            this.partidas.TabStop = true;
            this.partidas.Text = "Dime cuantas partidas ha ganado con su fecha y duración";
            this.partidas.UseVisualStyleBackColor = true;
            // 
            // Enviar
            // 
            this.Enviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Enviar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Enviar.Location = new System.Drawing.Point(1057, 499);
            this.Enviar.Margin = new System.Windows.Forms.Padding(4);
            this.Enviar.Name = "Enviar";
            this.Enviar.Size = new System.Drawing.Size(159, 52);
            this.Enviar.TabIndex = 13;
            this.Enviar.Text = "Enviar";
            this.Enviar.UseVisualStyleBackColor = false;
            this.Enviar.Click += new System.EventHandler(this.Enviar_Click);
            // 
            // conectar
            // 
            this.conectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.conectar.Location = new System.Drawing.Point(764, 26);
            this.conectar.Margin = new System.Windows.Forms.Padding(4);
            this.conectar.Name = "conectar";
            this.conectar.Size = new System.Drawing.Size(201, 54);
            this.conectar.TabIndex = 14;
            this.conectar.Text = "Conectar";
            this.conectar.UseVisualStyleBackColor = false;
            this.conectar.Click += new System.EventHandler(this.conectar_Click);
            // 
            // Desconectar
            // 
            this.Desconectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Desconectar.Location = new System.Drawing.Point(765, 107);
            this.Desconectar.Margin = new System.Windows.Forms.Padding(4);
            this.Desconectar.Name = "Desconectar";
            this.Desconectar.Size = new System.Drawing.Size(200, 54);
            this.Desconectar.TabIndex = 15;
            this.Desconectar.Text = "Desconectar";
            this.Desconectar.UseVisualStyleBackColor = false;
            this.Desconectar.Click += new System.EventHandler(this.Desconectar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1108, 320);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "ID partida";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(1071, 341);
            this.id.Margin = new System.Windows.Forms.Padding(4);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(132, 22);
            this.id.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1108, 424);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nombre";
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(1071, 445);
            this.nom.Margin = new System.Windows.Forms.Padding(4);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(132, 22);
            this.nom.TabIndex = 19;
            this.nom.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(941, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(346, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Introduzca la ID de la partida para la primera consulta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(903, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(432, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Introduzca el nombre del jugador para las dos segundas consultas:";
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.LightGray;
            this.salir.Location = new System.Drawing.Point(1323, 499);
            this.salir.Margin = new System.Windows.Forms.Padding(4);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(173, 50);
            this.salir.TabIndex = 22;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(99, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "BIENVENIDO";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Mostrar);
            this.groupBox1.Controls.Add(this.inicio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.contraseña);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 274);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inicar";
            // 
            // nomb
            // 
            this.nomb.Location = new System.Drawing.Point(138, 64);
            this.nomb.Name = "nomb";
            this.nomb.Size = new System.Drawing.Size(100, 22);
            this.nomb.TabIndex = 25;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(138, 115);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 22);
            this.password.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Nombre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Contraseña";
            // 
            // MostrarRe
            // 
            this.MostrarRe.AutoSize = true;
            this.MostrarRe.Location = new System.Drawing.Point(76, 152);
            this.MostrarRe.Name = "MostrarRe";
            this.MostrarRe.Size = new System.Drawing.Size(153, 21);
            this.MostrarRe.TabIndex = 29;
            this.MostrarRe.Text = "Mostrar contraseña";
            this.MostrarRe.UseVisualStyleBackColor = true;
            this.MostrarRe.CheckedChanged += new System.EventHandler(this.MostrarRe_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MostrarRe);
            this.groupBox2.Controls.Add(this.registro);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.password);
            this.groupBox2.Controls.Add(this.nomb);
            this.groupBox2.Location = new System.Drawing.Point(370, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 274);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registro";
            // 
            // Lista
            // 
            this.Lista.Location = new System.Drawing.Point(1323, 56);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(129, 65);
            this.Lista.TabIndex = 31;
            this.Lista.Text = "Lista de conectados";
            this.Lista.UseVisualStyleBackColor = true;
            this.Lista.Click += new System.EventHandler(this.Lista_Click);
            // 
            // conectados
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.conectados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.conectados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.conectados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.conectados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.conectados.DefaultCellStyle = dataGridViewCellStyle2;
            this.conectados.Location = new System.Drawing.Point(1032, 35);
            this.conectados.Name = "conectados";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.conectados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.conectados.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.conectados.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.conectados.RowTemplate.Height = 24;
            this.conectados.Size = new System.Drawing.Size(240, 187);
            this.conectados.TabIndex = 32;
            // 
            // Iniciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.inline_image_preview;
            this.ClientSize = new System.Drawing.Size(1525, 573);
            this.Controls.Add(this.conectados);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Desconectar);
            this.Controls.Add(this.conectar);
            this.Controls.Add(this.Enviar);
            this.Controls.Add(this.partidas);
            this.Controls.Add(this.puntos);
            this.Controls.Add(this.nombres);
            this.Controls.Add(this.historial);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Iniciar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conectados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button inicio;
        private System.Windows.Forms.CheckBox Mostrar;
        private System.Windows.Forms.Button registro;
        private System.Windows.Forms.RadioButton historial;
        private System.Windows.Forms.RadioButton nombres;
        private System.Windows.Forms.RadioButton puntos;
        private System.Windows.Forms.RadioButton partidas;
        private System.Windows.Forms.Button Enviar;
        private System.Windows.Forms.Button conectar;
        private System.Windows.Forms.Button Desconectar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nomb;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox MostrarRe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Lista;
        private System.Windows.Forms.DataGridView conectados;
    }
}

