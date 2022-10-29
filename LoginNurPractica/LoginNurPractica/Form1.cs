using Encriptacion;
using ServiceLogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginNurPractica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string estado = "";
            int intentos = 0;
            string[,] arreglo = { { "ocsicnarF", "ana" }, { "1991", "2016" } };

            var reversion = new Reverse();
            var log01 = new RegistroLog();
            var login1 = new Login();


            //Inversion de usuario
            textBox1.Text = reversion.Reverse1(textBox1.Text);
            textBox2.Text = reversion.Reverse1(textBox2.Text);

            //Login
            string resultado = login1.inicio(textBox1.Text, textBox2.Text);

            if (resultado == "OK")
            {
                estado = "Registro OK -" + DateTime.Today.ToString();
                MessageBox.Show("Login Correcto....","OK", MessageBoxButtons.OK , MessageBoxIcon.Information);
                this.Hide();
                Principal p = new Principal();
                p.Show();
            }
            else
            {
                estado = "Error de autenticacion" + "-"+ DateTime.Today.ToString();
                MessageBox.Show("Error de autenticacion, verifique usuario y/O contraseña ó es posible que su cuenta este inhabilitada", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox2.Text = "";
            }
            //registos de logs
            log01.log(estado);
        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
