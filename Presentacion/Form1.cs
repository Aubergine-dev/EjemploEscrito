using EjemploEscrito.Persistencia;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace EjemploEscrito
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            propiedad prop = new propiedad(Convert.ToInt32(textBoxIDProp1.Text), comboBoxTipo.Text, textBoxDireccion.Text, Convert.ToInt32(textBoxM2.Text), Convert.ToInt32(textBoxPrecioProp.Text));
            prop.BajaPropiedad();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            propiedad prop = new propiedad(Convert.ToInt32(textBoxIDProp1.Text), comboBoxTipo.Text, textBoxDireccion.Text, Convert.ToInt32(textBoxM2.Text), Convert.ToInt32(textBoxPrecioProp.Text));
            prop.ConsultaPropiedad(dataGridViewPropiedad);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            propiedad prop = new propiedad();
            prop.ListarPropiedad(dataGridViewPropiedad);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            venta venta = new venta();
            venta.ListarVenta(dataGridViewVenta);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            propiedad prop = new propiedad(Convert.ToInt32(textBoxIDProp1.Text), comboBoxTipo.Text, textBoxDireccion.Text, Convert.ToInt32(textBoxM2.Text), Convert.ToInt32(textBoxPrecioProp.Text));
            prop.IngresarPropiedad();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            propiedad prop = new propiedad(Convert.ToInt32(textBoxIDProp1.Text), comboBoxTipo.Text, textBoxDireccion.Text, Convert.ToInt32(textBoxM2.Text), Convert.ToInt32(textBoxPrecioProp.Text));
            prop.ModificacionPropiedad();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            venta venta = new venta(Convert.ToInt32(textBoxIDVenta.Text), Convert.ToInt32(textBoxPrecioVen.Text), Convert.ToInt32(textBoxIdProp.Text));
            venta.ConsultaVenta(dataGridViewVenta);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            venta venta = new venta(Convert.ToInt32(textBoxIDVenta.Text), Convert.ToInt32(textBoxPrecioVen.Text), Convert.ToInt32(textBoxIdProp.Text));
            venta.IngresarVenta();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            venta venta = new venta(Convert.ToInt32(textBoxIDVenta.Text), Convert.ToInt32(textBoxPrecioVen.Text), Convert.ToInt32(textBoxIdProp.Text));
            venta.BajaVenta();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPrecioProp_TextChanged(object sender, EventArgs e)
        {

        }

        private void NOOO_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string camino = "C:\\Users\\Usuario\\OneDrive\\Escritorio\\Venta.pdf";
            Document doc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(doc, new System.IO.FileStream(camino, System.IO.FileMode.Create));
            doc.Open();
            doc.Add(new Paragraph("Boleta de Venta:"));
            doc.Add(new Paragraph("Precio Sin Descuento: " + dataGridViewVenta.Rows[0].Cells[5].Value.ToString()));
            doc.Add(new Paragraph("Precio Total: " + dataGridViewVenta.Rows[0].Cells[3].Value.ToString()));
            doc.Add(new Paragraph("Id de la Casa Comprada: " + dataGridViewVenta.Rows[0].Cells[1].Value.ToString()));
            doc.Close();
            writer.Close();
        }
    }
}