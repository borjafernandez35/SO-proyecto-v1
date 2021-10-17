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

        public Iniciar()
        {
            InitializeComponent();
            contraseña.UseSystemPasswordChar = true; //La contraseña no sará visible por defecto
        }

        private void mostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (mostrar.Checked)
            {
                contraseña.UseSystemPasswordChar = false;
            }
            else
            {
                contraseña.UseSystemPasswordChar = true;
            }
        }

        private void registro_Click(object sender, EventArgs e)
        {
            Registro f2 = new Registro();
            f2.Show();
        }

        private void inicio_Click(object sender, EventArgs e)
        {

            //Creamos un IPEndPoint con el ip del servidor y puerto del servidor 
            //al que deseamos conectarnos
            IPAddress direc = IPAddress.Parse("192.168.56.102");
            IPEndPoint ipep = new IPEndPoint(direc, 9070);

            //Creamos el socket 
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                server.Connect(ipep);//Intentamos conectar el socket

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

                    //Mensaje de desconexión
                    mensaje = "0/";

                    msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    server.Send(msg);

                    // Nos desconectamos
                    server.Shutdown(SocketShutdown.Both);
                    server.Close();

                    Consultas f3 = new Consultas();
                    f3.Show();

                }

                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta");
                    server.Shutdown(SocketShutdown.Both);
                    server.Close();

                }
            }

            catch (SocketException ex)
            {
                //Si hay excepcion imprimimos error y salimos del programa con return 
                MessageBox.Show("No he podido conectar con el servidor");
                return;
            }
        }
    }
}
