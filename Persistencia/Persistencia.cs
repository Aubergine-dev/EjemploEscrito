using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace EjemploEscrito.Persistencia
{
    internal class Persistencia
    {
    }

    class conexion
    {
        public static MySqlConnection conn = new MySqlConnection("Server=localhost;Database=inmobiliaria;Uid=root;Pwd=drag0nf0lly");
        public static bool conectar()
        {

            try
            {
                conn.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }

    public class propiedad
    {
        private int id;
        private string direccion;
        private string tipo;
        private int metroscuadrados;
        private int precio;

        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Metroscuadrados { get; set; }
        public string Precio { get; set; }
        public string Direccion { get; set; }

        public propiedad()
        {
        }

        public propiedad(int id, string tipo, string direccion, int metroscuadrados, int precio)
        {
            this.id = id;
            this.tipo = tipo;
            this.metroscuadrados = metroscuadrados;
            this.precio = precio;
            this.direccion = direccion;
        }

        public void ListarPropiedad(DataGridView dg)
        {
            if (conexion.conectar())
            {
                MySqlCommand comando = new MySqlCommand("SELECT * FROM propiedad", conexion.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dg.DataSource = dt;
                conexion.conn.Close();
            }
            else
            {
                MessageBox.Show("Error de conexion a la base de datos.");
            }
        }

        public void IngresarPropiedad() 
        {
            if (conexion.conectar())
            {
                MySqlCommand comando = new MySqlCommand("INSERT INTO propiedad(id, tipo, direccion, metros_cuadrados, precio) VALUES(@i, @t, @d, @m, @p)", conexion.conn);
                comando.Parameters.AddWithValue("@i", this.id);
                comando.Parameters.AddWithValue("@t", this.tipo);
                comando.Parameters.AddWithValue("@d", this.direccion);
                comando.Parameters.AddWithValue("@m", this.metroscuadrados);
                comando.Parameters.AddWithValue("@p", this.precio);
                comando.ExecuteNonQuery();
                conexion.conn.Close();
            }
            else
            {
                MessageBox.Show("Error de conexion a la base de datos.");
            }
        }

        public void BajaPropiedad() 
        {
            if (conexion.conectar())
            {
                MySqlCommand comando = new MySqlCommand("DELETE FROM propiedad WHERE id=@i", conexion.conn);
                comando.Parameters.AddWithValue("@i", this.id);
                comando.ExecuteNonQuery();
                conexion.conn.Close();
            }
            else
            {
                MessageBox.Show("Error de conexion a la base de datos.");
            }
        }

        public void ConsultaPropiedad(DataGridView dg) 
        {
            if (conexion.conectar()) 
            {
                MySqlCommand comando = new MySqlCommand("SELECT * FROM propiedad WHERE id=@i", conexion.conn);
                comando.Parameters.AddWithValue("@i", this.id);
                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dg.DataSource = dt;
                conexion.conn.Close();
            } 
            else 
            {
                MessageBox.Show("Error de conexion a la base de datos.");
            }
        }

        public void ModificacionPropiedad() 
        {
            if (conexion.conectar())
            {
                MySqlCommand comando = new MySqlCommand("UPDATE propiedad SET tipo=@t, direccion=@d, metros_cuadrados=@m, precio=@p WHERE id=@i", conexion.conn);
                comando.Parameters.AddWithValue("@t", this.tipo);
                comando.Parameters.AddWithValue("@d", this.direccion);
                comando.Parameters.AddWithValue("@m", this.metroscuadrados);
                comando.Parameters.AddWithValue("@p", this.precio);
                comando.Parameters.AddWithValue("@i", this.id);
                comando.ExecuteNonQuery();
                conexion.conn.Close();
            }
            else
            {
                MessageBox.Show("Error de conexion a la base de datos.");
            }
        }
    }

    public class venta
    {
        private int id;
        private int precio;
        private int iva = 22;
        private int descuento;
        private int preciototal;
        private int idpropiedad;

        public string Id { get; set; }
        public string Precio { get; set; }
        public int Iva { get; set; }
        public int Descuento { get; set; }
        public int Preciototal { get; set; }
        public int Idpropiedad { get; set; }

        public venta()
        {
        }

        public venta(int id, int precio, int idpropiedad)
        {
            this.precio = precio;
            this.idpropiedad = idpropiedad;
            this.id = id;
        }

        public void ListarVenta(DataGridView dg)
        {
            if (conexion.conectar())
            {
                MySqlCommand comando = new MySqlCommand("SELECT * FROM venta", conexion.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dg.DataSource = dt;
                conexion.conn.Close();
            }
            else
            {
                MessageBox.Show("Error de conexion a la base de datos.");
            }
        }

        public void IngresarVenta()
        {
            if (conexion.conectar())
            {
                int calculo = (this.precio*this.iva)/100;
                this.preciototal = this.precio+calculo;
                MySqlCommand comando = new MySqlCommand("INSERT INTO venta(id, IVA, descuento, PrecioTotal, id_prop, precio) VALUES(@id, @iva, @d, @pt, @idp, @p)", conexion.conn);
                comando.Parameters.AddWithValue("@id", this.id);
                comando.Parameters.AddWithValue("@iva", this.iva);
                MySqlCommand subcomando = new MySqlCommand($"SELECT propiedad.tipo FROM venta JOIN propiedad ON propiedad.id=venta.id_prop WHERE venta.id_prop={this.idpropiedad}", conexion.conn);
                var value = subcomando.ExecuteScalar();
                MessageBox.Show(Convert.ToString(value));
                if (Convert.ToString(value) == "terreno")
                {
                    comando.Parameters.AddWithValue("@d", 15);
                    int calculo2 = (this.precio*15)/2;
                    this.preciototal = this.preciototal-calculo2;
                }
                else 
                {
                    comando.Parameters.AddWithValue("@d", 0);
                }
                comando.Parameters.AddWithValue("@pt", this.preciototal);
                comando.Parameters.AddWithValue("@idp", this.idpropiedad);
                comando.Parameters.AddWithValue("@p", this.precio);
                comando.ExecuteNonQuery();
                conexion.conn.Close();
            }
            else
            {
                MessageBox.Show("Error de conexion a la base de datos.");
            }
        }

        public void BajaVenta()
        {
            if (conexion.conectar())
            {
                MySqlCommand comando = new MySqlCommand("DELETE FROM venta WHERE id=@i", conexion.conn);
                comando.Parameters.AddWithValue("@i", this.id);
                comando.ExecuteNonQuery();
                conexion.conn.Close();
            }
            else
            {
                MessageBox.Show("Error de conexion a la base de datos.");
            }
        }

        public void ConsultaVenta(DataGridView dg)
        {
            if (conexion.conectar())
            {
                MySqlCommand comando = new MySqlCommand("SELECT * FROM venta WHERE id=@i", conexion.conn);
                comando.Parameters.AddWithValue("@i", this.id);
                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dg.DataSource = dt;
                conexion.conn.Close();
            }
            else
            {
                MessageBox.Show("Error de conexion a la base de datos.");
            }
        }
    }
}
