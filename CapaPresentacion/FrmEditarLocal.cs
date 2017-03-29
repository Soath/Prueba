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
    public partial class FrmEditarLocal : KryptonForm
    {
        ACFLOCT_LOCAL _owner;
        int LOCID;

        public FrmEditarLocal()
        {
            InitializeComponent();
        }

        public FrmEditarLocal(ACFLOCT_LOCAL owner)
        {
            _owner = owner;
            InitializeComponent();

            this.LOCID = Convert.ToInt32(_owner.ObtenerSeleccion().Cells["ID"].Value);
            this.textBoxNombre.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells["LOCAL"].Value);
            this.textBoxDescripcion.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells["DIRECCION"].Value);
            this.textBoxsegmento.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells["SEGMENTO"].Value);
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
            String mensaje = NACFLOCT_LOCAL.Editar(this.LOCID, this.textBoxNombre.Text, this.textBoxDescripcion.Text, this.textBoxsegmento.Text);

            if (mensaje == "Y")
            {
                this._owner.Mensaje(String.Format("El Local {0} ha sido EDITADO", this.textBoxNombre.Text));
                this._owner.Refrescar();
                this.Close();
            }
            else
            {
                MensajeError(mensaje);

            }
        }

        private void labelDescripcion_Click(object sender, EventArgs e)
        {

        }
    }
}
