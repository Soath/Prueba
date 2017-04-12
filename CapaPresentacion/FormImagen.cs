using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormImagen : Form
    {
        int numero = 1; 
        public FormImagen()
        {
            InitializeComponent();

        }

        private void FormImagen_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("E:\\Dariel\\Sophie Turner\\Sophie" + numero + ".jpg");
            label1.Text = "Sophie" + numero;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numero++;
            try
            {
                if (numero > 1)
                {
                    pictureBox1.Image = Image.FromFile("E:\\Dariel\\Sophie Turner\\Sophie" + numero + ".jpg");
                    label1.Text = "Sophie" + numero;
                }
            }
            catch (Exception ex)
            {
                numero--;
                label1.Text = "Sophie" + numero;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numero > 1)
            {
                numero--;
                pictureBox1.Image = Image.FromFile("E:\\Dariel\\Sophie Turner\\Sophie" + numero + ".jpg");
                label1.Text = "Sophie" + numero;
            }
        }


    }
}
