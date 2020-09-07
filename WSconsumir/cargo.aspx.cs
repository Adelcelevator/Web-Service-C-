using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace WSconsumir
{
    public partial class cargo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargardatos();
                cargarempelados();
            }
        }
        protected void cargardatos()
        {
            WSdeber.WebServiceSoapClient ws = new WSdeber.WebServiceSoapClient();
            DataSet ds = ws.Listacargoxempelado();
            Grv_car.DataSource = ds;
            Grv_car.DataBind();
        }
        protected void cargarempelados()
        {
            WSdeber.WebServiceSoapClient ws = new WSdeber.WebServiceSoapClient();
            Dr_emp.DataSource = ws.Listarempleado();
            Dr_emp.DataTextField = "nombreEmpl";
            Dr_emp.DataValueField = "idEmpleados";
            Dr_emp.DataBind();
            Dr_emp.Items.Insert(0, new ListItem("seleccione", "0"));
        }
        public void limpiar()
        {
            Txt_des.Text = "";
            Dr_emp.SelectedValue = "0";
            hdf_car.Value = "";
        }
        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            WSdeber.WebServiceSoapClient ws = new WSdeber.WebServiceSoapClient();
            DataSet ds = ws.WsInsertarcargo(Txt_des.Text, Convert.ToInt32(Dr_emp.SelectedValue));
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('datos guardados')", true);
            cargardatos();
            limpiar();
        }

        protected void Lnk_Seleccionar_Click(object sender, EventArgs e)
        {
            int carid = Convert.ToInt32((sender as LinkButton).CommandArgument);
            WSdeber.WebServiceSoapClient ws = new WSdeber.WebServiceSoapClient();
            DataSet ds = ws.Listacargon(carid);
            hdf_car.Value = carid.ToString();
            XmlDocument docum = new XmlDocument();
            docum.LoadXml(ds.GetXml());
            XmlNodeList eleent = docum.GetElementsByTagName("descripcionCar");
            Txt_des.Text = eleent[0].InnerXml;
        }

        protected void btn_actulizar_Click(object sender, EventArgs e)
        {
            WSdeber.WebServiceSoapClient ws = new WSdeber.WebServiceSoapClient();
            DataSet ds = ws.Wseditarcargo(Convert.ToInt32(hdf_car.Value),Txt_des.Text, Convert.ToInt32(Dr_emp.SelectedValue));
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('datos actualizados')", true);
            cargardatos();
            limpiar();
        }

        protected void btn_eliminar_Click(object sender, EventArgs e)
        {
            WSdeber.WebServiceSoapClient ws = new WSdeber.WebServiceSoapClient();
            DataSet ds = ws.eliminarcargo(Convert.ToInt32(hdf_car.Value));
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('datos eliminados')", true);
            cargardatos();
            limpiar();
        }
    }
}