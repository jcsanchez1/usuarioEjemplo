using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using usuarioEjemplo;

namespace usuarioEjemplo
{
    public partial class Form1 : Form
    {
        public Form2 ventana;
        public Form1()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            if(txtusuario.Text == "")
            {
                MessageBox.Show("ingrese sus usario");
            }
            else
            {
                ventana = new Form2();
                ventana.nombre = txtusuario.Text;
                ventana.Show();
                this.timer1.Enabled = true;
                this.Hide();
                
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(ventana.IsDisposed)
            {
                this.txtusuario.Text = "";
                this.timer1.Enabled = false;
                this.Show();
            }
        }
    }

}
