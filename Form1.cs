using pryCafeteria.Cafeteria;
using pryCafeteria2.Cafeteria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCafeteria
{
    public partial class fmrCafeteria : Form
    {
        private List<Bebida> bebidas;
        public fmrCafeteria()
        {
            InitializeComponent();
            bebidas = new List<Bebida>();
        }

        private void rdbBebidaCaliente_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBebidaCaliente.Checked)
            {
                lblExtra.Text = "Temperatura (°C)";
            }
            else if (rdbBebidaFria.Checked)
            {
                lblExtra.Text = "Cantidad de Hielo";
            }
            else if (rdbBebidaAlcoholica.Checked)
            {
                lblExtra.Text = "Grados de Alcohol";
            }            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = "";
            float precio = 0.0f;
            string tamaño = "";
            float extra;

            nombre = txtBebida.Text;
            precio = float.Parse(txtPrecio.Text.Trim());
            tamaño = cmbTamaño.Text;
            extra = float.Parse(txtExtra.Text.Trim());

            if (rdbBebidaCaliente.Checked)
            {
                bebidas.Add(new BebidaCaliente(nombre, tamaño, precio, extra));
            }
            else if(rdbBebidaFria.Checked)
            {
                bebidas.Add(new BebidaFria(nombre, tamaño, precio, extra));
            }
            else if (rdbBebidaAlcoholica.Checked)
            {
                bebidas.Add(new BebidaAlcholica(nombre, tamaño, precio, extra));
            }
            MessageBox.Show("Bebida agregada correctamente, tienes: " + bebidas.Count + " bebidas registradas");
            Limpiar();

            if (bebidas[bebidas.Count - 1] is BebidaFria fria)
            {
                lsbLista.Items.Add(fria.Listar());
            }
            else if (bebidas[bebidas.Count - 1] is BebidaCaliente caliente)
            {
                lsbLista.Items.Add(caliente.Listar());
            }
            else if (bebidas[bebidas.Count - 1] is BebidaAlcholica alcholica)
            {
                lsbLista.Items.Add(alcholica.Listar());
            }
            
            lblCantidad.Text = bebidas.Count + " Bebidas Agregadas";


        }
        private void Limpiar()
        {
            txtBebida.Clear();
            txtPrecio.Clear();
            txtExtra.Clear();          
            cmbTamaño.SelectedIndex = 0;
        }

        private void lsbLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDescripcion.Text = bebidas[lsbLista.SelectedIndex].Preparar();            
        }

    }
}
