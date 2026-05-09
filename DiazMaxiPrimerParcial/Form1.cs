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
            String linea = ArchivoArticulos.ReadLine();

            while (linea != null)
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
                linea = ArchivoArticulos.ReadLine();
                
            }
            ArchivoArticulos.Close();
            ArchivoArticulos.Dispose();
            lblCantiArticulos.Text = CantidadArticulos.ToString();
            lblTotalStock.Text = "$" + AcumuladorTotal.ToString();


        }

        private void lblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(" Analista de Sistemas\n" +
                "Laboratorio de Programación 2\n" +
                "1º Instancia Evaluativa\n" +
                "Información del Alumno\n" +
                "DNI:40205701 – Diaz Maximiliano");
        }

        private void btnExportarDatos_Click(object sender, EventArgs e)
        {
            String linea;
            string datos;

            float costo;
            int stock;
            float valorStock;


            StreamReader ArchivoRubros = new StreamReader("RUBROS.CSV");
            StreamWriter ArchivoExportar = new StreamWriter("ARTICULOS_EXPORTADOS.CSV", false);
            ArchivoExportar.WriteLine("Codigo;Descripcion;Costo;Rubro;Stock;ValorStock");
            linea = ArchivoRubros.ReadLine();

            while(linea != null)
            {
                string[] datosRubro = linea.Split(';');
                string rubro = datosRubro[0];
                StreamReader ArchivoArticulos = new StreamReader("ARTICULOS.CSV");
                String lineaArticulo = ArchivoArticulos.ReadLine();
                while (lineaArticulo != null)
                {
                    string[] datosArticulo = lineaArticulo.Split(';');
                    if (datosArticulo[3] == rubro)
                    {
                        string codigo = datosArticulo[0];
                        string descripcion = datosArticulo[1];
                        costo = Convert.ToInt32(datosArticulo[2]);
                        stock = Convert.ToInt32(datosArticulo[4]);
                        valorStock = costo * stock;
                        datos = codigo + ";" + descripcion + ";" + costo + ";" + rubro + ";" + stock + ";" + valorStock;
                        ArchivoExportar.WriteLine(datos);
                    }
                    lineaArticulo = ArchivoArticulos.ReadLine();
                }
                ArchivoArticulos.Close();
                ArchivoArticulos.Dispose();
                linea = ArchivoRubros.ReadLine();

            }
            MessageBox.Show("Datos exportados correctamente");
            ArchivoRubros.Close();
            ArchivoRubros.Dispose();
            ArchivoExportar.Close();
            ArchivoExportar.Dispose();
        }
    }
}
