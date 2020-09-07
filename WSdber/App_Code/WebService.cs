using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Descripción breve de WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{

    public WebService()
    {

        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }

    [WebMethod]
    public DataSet Listacargoxempelado()
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"Data Source=PANCHITO\PANCHITO;Initial Catalog=webservice;Integrated Security=True";
        SqlDataAdapter da = new SqlDataAdapter("Select c.*, e.nombreEmpl from Cargos c ,Empleados e where c.idEmpleados=e.idEmpleados", con);
        DataSet dc = new DataSet();
        da.Fill(dc);
        return dc;
    }
 
    [WebMethod]
    public DataSet Listacargon(int id)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"Data Source=PANCHITO\PANCHITO;Initial Catalog=webservice;Integrated Security=True";
        SqlDataAdapter da = new SqlDataAdapter("Select descripcionCar from Cargos   where idCargos='" + id + "'", con);
        DataSet dc = new DataSet();
        da.Fill(dc);
        return dc;
    }

    [WebMethod]
    public DataSet WsInsertarcargo(string descripcion, int empleado)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"Data Source=PANCHITO\PANCHITO;Initial Catalog=webservice;Integrated Security=True";
        SqlDataAdapter da = new SqlDataAdapter("Insert into Cargos values('" + descripcion + "'" + ",'A'" + ",'" + empleado + "')", con);
        DataSet dc = new DataSet();
        da.Fill(dc);
        return dc;
    }
    [WebMethod]
    public DataSet Wseditarcargo(int id, string descripcion, int empleado)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"Data Source=PANCHITO\PANCHITO;Initial Catalog=webservice;Integrated Security=True";
        SqlDataAdapter da = new SqlDataAdapter("update Cargos set descripcionCar='" + descripcion + "',estadoCar='C', idEmpleados='" + empleado + "' where idCargos='" + id + "'", con);
        DataSet dc = new DataSet();
        da.Fill(dc);
        return dc;
    }
    [WebMethod]
    public DataSet eliminarcargo(int id)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"Data Source=PANCHITO\PANCHITO;Initial Catalog=webservice;Integrated Security=True";
        SqlDataAdapter da = new SqlDataAdapter("delete from Cargos where idCargos='" + id + "'", con);
        DataSet dc = new DataSet();
        da.Fill(dc);
        return dc;
    }
    [WebMethod]
    public DataSet Listarempleado()
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"Data Source=PANCHITO\PANCHITO;Initial Catalog=webservice;Integrated Security=True";
        SqlDataAdapter da = new SqlDataAdapter("Select * from Empleados", con);
        DataSet dc = new DataSet();
        da.Fill(dc);
        return dc;
    }
 
    [WebMethod]
    public DataSet Listarempresas()
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"Data Source=PANCHITO\PANCHITO;Initial Catalog=webservice;Integrated Security=True";
        SqlDataAdapter da = new SqlDataAdapter("Select * from Empresa", con);
        DataSet dc = new DataSet();
        da.Fill(dc);
        return dc;
    }
    [WebMethod]
    public DataSet Listardepartamentosxempresa()
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"Data Source=PANCHITO\PANCHITO;Initial Catalog=webservice;Integrated Security=True";
        SqlDataAdapter da = new SqlDataAdapter("Select d.*,e.nombreEmp from departamentos d, Empresa e", con);
        DataSet dc = new DataSet();
        da.Fill(dc);
        return dc;
    }
    [WebMethod]
    public DataSet ListadepaN(int id)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"Data Source=PANCHITO\PANCHITO;Initial Catalog=webservice;Integrated Security=True";
        SqlDataAdapter da = new SqlDataAdapter("Select descripcionDep from Departamentos   where idDepartamento='" + id + "'", con);
        DataSet dc = new DataSet();
        da.Fill(dc);
        return dc;
    }
    [WebMethod]
    public DataSet Insertardep(string descripcion, int empresa)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"Data Source=PANCHITO\PANCHITO;Initial Catalog=webservice;Integrated Security=True";
        SqlDataAdapter da = new SqlDataAdapter("Insert into Departamentos values('" + descripcion + "'" + ",'A'" + ",'" + empresa + "')", con);
        DataSet dc = new DataSet();
        da.Fill(dc);
        return dc;
    }
    [WebMethod]
    public DataSet editardep(int id, string descripcion, int empresa)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"Data Source=PANCHITO\PANCHITO;Initial Catalog=webservice;Integrated Security=True";
        SqlDataAdapter da = new SqlDataAdapter("update Departamentos set descripcionDep='" + descripcion + "',estadoDep='C', idEmpresa='" + empresa + "' where idDepartamento='" + id + "'", con);
        DataSet dc = new DataSet();
        da.Fill(dc);
        return dc;
    }
    [WebMethod]
    public DataSet eliminardep(int id)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"Data Source=PANCHITO\PANCHITO;Initial Catalog=webservice;Integrated Security=True";
        SqlDataAdapter da = new SqlDataAdapter("delete from Departamentos where idDepartamento='" + id + "'", con);
        DataSet dc = new DataSet();
        da.Fill(dc);
        return dc;
    }

}
