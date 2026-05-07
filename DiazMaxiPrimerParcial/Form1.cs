using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiazMaxiPrimerParcial
{
    public partial class frmVentaEquiposInformaticos : Form
    {
        public frmVentaEquiposInformaticos()
        {
            InitializeComponent();
        }

        private void lblArticulosConsulta_Click(object sender, EventArgs e)
        {

        }

        private void frmVentaEquiposInformaticos_Load(object sender, EventArgs e)
        {
            StreamReader ArchivoRubros = new StreamReader("RUBROS.CSV");
            String linea;

            while ((linea = ArchivoRubros.ReadLine()) != null)
            {
                string[] datos = linea.Split(';');
                cmbRubro.Items.Add(datos[0]);
            }
            ArchivoRubros.Close();
        }
       

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cmbRubro.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un rubro de lista");
                return;
            }

            dgvArticulos.Rows.Clear();
            int CantidadArticulos = 0;
            float AcumuladorTotal = 0;

            string RubroElegido = cmbRubro.Text;

            StreamReader ArchivoArticulos = new StreamReader("ARTICULOS.CSV");
            String linea;

            while ((linea = ArchivoArticulos.ReadLine()) != null)
            {
                string[] datos = linea.Split(';');

                if (datos[3] == RubroElegido)
                {
                    string Codigo = datos[0];
                    string Descripcion = datos[1];
                    float Costo = Convert.ToInt32(datos[2]);
                    int Stock = Convert.ToInt32(datos[4]);

                    float ValorStock = Costo * Stock;

                    dgvArticulos.Rows.Add(Codigo, Descripcion, Costo, Stock, ValorStock);

                    CantidadArticulos++;
                    AcumuladorTotal += ValorStock;
                }
                ArchivoArticulos.Close();
                lblCantiArticulos.Text = CantidadArticulos.ToString();
                lblTotalStock.Text = "$" + AcumuladorTotal.ToString();
            }


        }
    }
}
