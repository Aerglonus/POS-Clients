using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
namespace splash
{
    class Datos
    {
        static SqlConnection conx = new SqlConnection(@"Data Source= CALEB-PC\SQLEXPRESS; Initial Catalog = Facturacion; Integrated Security= true");
        //---------------------Datos Generales---------------//
        static public DataTable misDatos(string consulta)
        {
            Conectar();
            DataTable t = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(consulta, conx);
            da.Fill(t);
            Desconectar();
            return t;
        }
        static public bool Conectar()
        {
            try
            {
                conx.Open();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        static public bool Desconectar()
        {
            try
            {
                conx.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        //-----------------------------------Articulos-------------------//
        static public Articulo leerArticulo(string cod)
        {
            Conectar();
            Articulo a = new Articulo();
            SqlCommand cmd = new SqlCommand("select *from articulos where codigo =@codigo", conx);
            cmd.Parameters.AddWithValue("@codigo", cod);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                a.Codigo = dr["codigo"].ToString(); //dr.GetString (0);
                a.Descripcion = dr["descripcion"].ToString(); //dr.GetString(1);
                a.Precio = double.Parse(dr["precio"].ToString()); //dr.GetDouble(3);
                a.Costo = double.Parse(dr["costo"].ToString());//dr.GetDouble(2);
                a.Iva = int.Parse(dr["iva"].ToString());//dr.GetInt32(4);
                a.Ieps = int.Parse(dr["ieps"].ToString());//dr.GetInt32(5);
            }
            else
                a = null;
            Desconectar();
            return a;
        }
        static public bool grabarArticulo(Articulo a)
        {
            try
            {
                Conectar();
                SqlCommand cmd = new SqlCommand("iuarticulos", conx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", a.Codigo);
                cmd.Parameters.AddWithValue("@descripcion", a.Descripcion);
                cmd.Parameters.AddWithValue("@precio", a.Precio);
                cmd.Parameters.AddWithValue("@costo", a.Costo);
                cmd.Parameters.AddWithValue("@iva", a.Iva);
                cmd.Parameters.AddWithValue("@ieps", a.Ieps);

                cmd.ExecuteNonQuery();


                Desconectar();
                return true;
            }
            catch (Exception e)
            {
                Desconectar();
                MessageBox.Show(e.Message);
                return false;
            }
        }
        static public void eliminoArticulo(string cod)
        {

            try
            {
                Conectar();
                SqlCommand cmd = new SqlCommand("delete from articulos where codigo = @codigo", conx);
                cmd.Parameters.AddWithValue("@codigo", cod);


                cmd.ExecuteNonQuery();


                Desconectar();
            }
            catch (Exception e)
            {
                Desconectar();
                MessageBox.Show(e.Message);
            }
        }

        //------------------------------------------CLIENTES-----------------------------------

        static public DataTable misClientes()
        {
            Conectar();
            DataTable t = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("select * from clientes", conx);

            da.Fill(t);
            Desconectar();
            return t;
        }
    }
}

