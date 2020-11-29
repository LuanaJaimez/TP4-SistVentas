using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Entidades
{
    public class DatosBD
    {
        SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-HN6S3DK\\SQLEXPRESS; Database = Producto; Trusted_Connection=True;");
        public DataTable MostrarPrendas()
        {
            SqlDataAdapter datos = new SqlDataAdapter("SELECT * FROM PrendaBD", conexion);
            DataTable tabla = new DataTable();

            datos.SelectCommand.CommandType = CommandType.Text;
            datos.Fill(tabla);

            return tabla;
        }

        public DataTable MostrarAccesorios()
        {
            SqlDataAdapter datos = new SqlDataAdapter("SELECT * FROM AccesorioBD", conexion);
            DataTable tabla = new DataTable();

            datos.SelectCommand.CommandType = CommandType.Text;
            datos.Fill(tabla);

            return tabla;
        }

        public DataTable AgregarPrenda()
        {
            SqlDataAdapter datos = new SqlDataAdapter("INSERT INTO PrendaBD VALUES (@Tipo, @Marca, @Precio, @Cantidad)", conexion);
            datos.SelectCommand.CommandType = CommandType.Text;
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            return tabla;
        }
        
        
        /*datos = new SqlCommand();
        datos.UpdateCommand = new SqlCommand("UPDATE PrendaBD SET Tipo = @Tipo, Marca = @Marca, Precio = @Precio, Cantidad = @Cantidad WHERE ID = @PID", conexion);
        this.datos.DeleteCommand = new SqlCommand("DELETE FROM clientes WHERE PID = @PID", conexion);

        this.datos.InsertCommand.Parameters.Add("@Tipo", SqlDbType.NVarChar, 50, "Tipo");
        this.datos.InsertCommand.Parameters.Add("@Marca", SqlDbType.NVarChar, 50, "Marca");
        this.datos.InsertCommand.Parameters.Add("@Precio", SqlDbType.Float, 20, "Precio");
        this.datos.InsertCommand.Parameters.Add("@Cantidad", SqlDbType.Int, 200, "Cantidad");

        this.datos.UpdateCommand.Parameters.Add("@Tipo", SqlDbType.NVarChar, 50, "Tipo");
        this.datos.UpdateCommand.Parameters.Add("@Marca", SqlDbType.NVarChar, 50, "Marca");
        this.datos.UpdateCommand.Parameters.Add("@Precio", SqlDbType.Float, 20, "Precio");
        this.datos.UpdateCommand.Parameters.Add("@Cantidad", SqlDbType.Int, 200, "Cantidad");

        this.datos.DeleteCommand.Parameters.Add("@PID", SqlDbType.Int, 10, "PID");*/
    }
}
