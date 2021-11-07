using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace WindowsFormsApp1
{
    public partial class Iniciar : Form
    {
        Socket server;
        Boolean Conectado = false;
        Boolean log = false;

        public Iniciar()
        {
            InitializeComponent();
            contraseña.UseSystemPasswordChar = true; //La contraseña no sará visible por defecto
            password.UseSystemPasswordChar = true;
        }

        private void Mostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (Mostrar.Checked)
            {
                contraseña.UseSystemPasswordChar = false;
            }
            else
            {
                contraseña.UseSystemPasswordChar = true;
            }
        }

        private void conectar_Click(object sender, EventArgs e)
        {
            //Creamos un IPEndPoint con el ip del servidor y puerto del servidor 
            //al que deseamos conectarnos
            IPAddress direc = IPAddress.Parse("192.168.56.101");
            IPEndPoint ipep = new IPEndPoint(direc, 9080);


            //Creamos el socket 
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Connect(ipep);//Intentamos conectar el socket
                MessageBox.Show("Conectado");
                Conectado = true;
            }

            catch (SocketException)
            {
                //Si hay excepcion imprimimos error y salimos del programa con return 
                MessageBox.Show("No he podido conectar con el servidor");
                return;
            }
        }

        private void registro_Click(object sender, EventArgs e)
        {
            if (Conectado == true)
            {
                string mensaje = "1/" + nomb.Text + "/" + password.Text;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                //Recibimos la respuesta del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                MessageBox.Show(mensaje);

                nomb.Text = "";
                password.Text = "";
            }

            else
            {
                MessageBox.Show("Hay que conectarse");
            }
        }

        private void inicio_Click(object sender, EventArgs e)
        {

            if (Conectado == true)
            {
                string mensaje = "2/" + nombre.Text + "/" + contraseña.Text;

                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                //Recibimos la respuesta del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];

                if (mensaje == "SI")
                {
                    MessageBox.Show("Ha iniciado sesión correctamente");
                    log = true;
                }

                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta");
                }

                nombre.Text = "";
                contraseña.Text = "";
            }

            else
            {
                MessageBox.Show("Hay que conectarse");
            }
        }


        private void Enviar_Click(object sender, EventArgs e)
        {
            if (Conectado == true && log == true)
            {
                if (partidas.Checked)
                {
                    string mensaje = "5/" + nom.Text;
                    // Enviamos al servidor el nombre tecleado
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    server.Send(msg);

                    //Recibimos la respuesta del servidor
                    byte[] msg2 = new byte[200];
                    server.Receive(msg2);
                    mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                    MessageBox.Show(mensaje);

                }

                else if (historial.Checked)
                {
                    string mensaje = "6/";
                    // Enviamos al servidor el nombre tecleado
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    server.Send(msg);

                    //Recibimos la respuesta del servidor
                    byte[] msg2 = new byte[200];
                    server.Receive(msg2);
                    mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                    MessageBox.Show(mensaje);

                }

                else if (puntos.Checked)
                {
                    string mensaje = "4/" + nom.Text;
                    // Enviamos al servidor el nombre tecleado
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    server.Send(msg);

                    //Recibimos la respuesta del servidor
                    byte[] msg2 = new byte[200];
                    server.Receive(msg2);
                    mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];

                    MessageBox.Show(mensaje);
                }

                else
                {
                    string mensaje = "3/" + id.Text;
                    // Enviamos al servidor el nombre tecleado
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    server.Send(msg);

                    //Recibimos la respuesta del servidor
                    byte[] msg2 = new byte[80];
                    server.Receive(msg2);
                    mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];

                    MessageBox.Show(mensaje);
                }
            }

            else if (Conectado == false)
            {
                MessageBox.Show("Hay que conectarse");
            }

            else if (log == false)
            {
                MessageBox.Show("Hay que iniciar sesión");
            }
        }

        private void Desconectar_Click(object sender, EventArgs e)
        {
            //Mensaje de desconexión
            string mensaje = "0/";

            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            Conectado = false;

            // Nos desconectamos
            server.Shutdown(SocketShutdown.Both);
            server.Close();
            MessageBox.Show("Se ha desconectado");
        }

        private void salir_Click(object sender, EventArgs e)
        {
            if (Conectado == true)
            {
                string mensaje = "0/";

                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
                // Nos desconectamos
                server.Shutdown(SocketShutdown.Both);
                server.Close();
            }

            MessageBox.Show("Gracias y hasta la próxima");
            this.Close();
        }

        private void MostrarRe_CheckedChanged(object sender, EventArgs e)
        {
            if (MostrarRe.Checked)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }

        private void Lista_Click(object sender, EventArgs e)
        {
            string mensaje = "7/";
            // Enviamos al servidor el nombre tecleado
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            //Recibimos la respuesta del servidor
            byte[] msg2 = new byte[80];
            server.Receive(msg2);
            mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];

            string[] jugadores = mensaje.Split('/');

            conectados.ColumnCount = 1;
            conectados.RowCount = jugadores.Length;
            conectados.ColumnHeadersVisible = false;
            conectados.RowHeadersVisible = false;

            int i = 0;

            foreach (string nombre in jugadores)
            {
                conectados[0, i].Value = nombre;
                i++;
            }
        }
    }
}