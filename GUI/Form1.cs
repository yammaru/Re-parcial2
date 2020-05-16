using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entiry;
using BLL;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        ServicioPublicoService service = new ServicioPublicoService();
        ServicioPublico publico = new ServicioPublico();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource= service.Consultar(comboServicioFiltro.Text, DtpFechaFiltro.Value);
            lblTotalizar.Text= service.Totalizar(comboServicioFiltro.Text, DtpFechaFiltro.Value).ToString();
        }

        private void comboServicioFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            publico.NombreServicioPublico = comboNombre.Text;
            publico.NumeroReciboPago = txtNumero.Text;
            publico.FechaPago = DtpFecha.Value ;
            publico.ValorPago = decimal.Parse( txtValor.Text);
            string mensaje=service.Guardar(publico);
            MessageBox.Show(mensaje,"Guardo!!!");
        }

        private void btnReportar_Click(object sender, EventArgs e)
        {
            string mensaje=service.Reportar(comboServicioFiltro.Text, DtpFechaFiltro.Value);
            MessageBox.Show(mensaje, "rrrrr");
        }
    }
}
