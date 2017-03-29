using System;
using System.Collections.Generic;
using ComponentFactory.Krypton.Toolkit;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmAgregarNuevLocal : KryptonForm
    {
        ACFLOCT_LOCAL _owner;

        public FrmAgregarNuevLocal()
        {
            InitializeComponent();
        }

        public FrmAgregarNuevLocal(ACFLOCT_LOCAL owner)
        {
            _owner = owner;
            InitializeComponent();
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            String mensaje = NACFLOCT_LOCAL.Insertar(this.textBoxNombre.Text, this.textBoxDescripcion.Text);

            if (mensaje == "Y")
            {
                this._owner.Mensaje(String.Format("La Categoría {0} ha sido AGREGADA", this.textBoxNombre.Text));
                this._owner.Refrescar();
                this.Close();
            }
            else
            {
                MensajeError(mensaje);
            }
        }
    }
}
