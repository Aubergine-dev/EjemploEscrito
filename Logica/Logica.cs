using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp;
using System.Windows.Forms;
namespace EjemploEscrito.Logica
{
    public class Logica
    {
        public static void PDF(DataGridView dgv)
        {
            string camino = "C:\\Users\\Usuario\\OneDrive\\Escritorio\\Venta.pdf";
            Document doc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(doc, new System.IO.FileStream(camino, System.IO.FileMode.Create));
            doc.Open();
            PdfPTable tablelayout = new PdfPTable(6);

            //Se agregan los encabezados de columnas
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell(new Phrase(dgv.Columns[i].HeaderText));
                cell.BackgroundColor = BaseColor.LIGHT_GRAY; // Color de fondo de los encabezados
                tablelayout.AddCell(cell);
            }

            // Agregar filas de datos
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow) // Ignorar la fila nueva
                {
                    for (int i = 0; i < dgv.Columns.Count; i++)
                    {
                        tablelayout.AddCell(row.Cells[i].Value?.ToString() ?? string.Empty);
                    }
                }
            }

            // Agregar la tabla al documento
            doc.Add(tablelayout);
            doc.Close(); // Cerrar el documento
            writer.Close(); // Cerrar el escritor
        }
    }
}
