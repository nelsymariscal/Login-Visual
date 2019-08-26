using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            this.Close();//Cierra el formulario
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (textbox_usuario.Text=="juancho" && textbox_salir.Text=="123tamarindo")
            {

            } 
            else
            {
                MessageBox.Show("usuario o contraseña no válidas");
                textbox_usuario.Text = "";
                textbox_salir.Text = "";
                textbox_usuario.Focus();
            }
        }
    }
}
