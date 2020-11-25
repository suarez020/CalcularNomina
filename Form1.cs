using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularNomina
{
    
    public partial class FrmCalcularSalarioJuanRubio : Form
    {
        Empleado myEmpleado = new Empleado();
        Nomina myNomina = new Nomina();
        public FrmCalcularSalarioJuanRubio()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAlmacenarRegistro_Click(object sender, EventArgs e)
        {
            myEmpleado.Nombre = txtNombre.Text;
            myEmpleado.Identificacion = txtIdentificacion.Text;
            myEmpleado.AsignaicionDia = Convert.ToDecimal(txtSalarioDia.Text) ;
            myNomina.DiasLaborados = Convert.ToInt32(txtDiasLaborados.Text);
            MessageBox.Show("registro guardado con exito");

        }

        private void btnCalcularSalario_Click(object sender, EventArgs e)
        {
            txtValorDevengado.Text = myNomina.CalcularNomina(Convert.ToInt32(myNomina.DiasLaborados),
                Convert.ToDecimal (myEmpleado.AsignaicionDia)).ToString();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtIdentificacion.Clear();
            txtSalarioDia.Clear();
            txtDiasLaborados.Clear();
            txtValorDevengado.Clear();


        }
    }
}
