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
    public partial class departamento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargardatos();
                cargarempresa();
            }
        }
        protected void cargardatos()
        {
            WSdeber.WebServiceSoapClient ws = new WSdeber.WebServiceSoapClient();
            DataSet ds = ws.Listardepartamentosxempresa();
            Grv_dep.DataSource = ds;
            Grv_dep.DataBind();
        }
        protected void cargarempresa()
        {
            WSdeber.WebServiceSoapClient ws = new WSdeber.WebServiceSoapClient();
            Dr_emp.DataSource = ws.Listarempresas();
            Dr_emp.DataTextField = "nombreEmp";
            Dr_emp.DataValueField = "idEmpresa";
            Dr_emp.DataBind();
            Dr_emp.Items.Insert(0, new ListItem("seleccione", "0"));
        }
        public void limpiar()
        {
            Txt_des.Text = "";
            Dr_emp.SelectedValue = "0";
            hdf_dep.Value = "";
        }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            WSdeber.WebServiceSoapClient ws = new WSdeber.WebServiceSoapClient();
            DataSet ds = ws.Insertardep(Txt_des.Text, Convert.ToInt32(Dr_emp.SelectedValue));
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('datos guardados')", true);
            cargardatos();
            limpiar();
        }

        protected void btn_actulizar_Click(object sender, EventArgs e)
        {
            WSdeber.WebServiceSoapClient ws = new WSdeber.WebServiceSoapClient();
            DataSet ds = ws.editardep(Convert.ToInt32(hdf_dep.Value), Txt_des.Text, Convert.ToInt32(Dr_emp.SelectedValue));
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('datos actualizados')", true);
            cargardatos();
            limpiar();
        }

        protected void btn_eliminar_Click(object sender, EventArgs e)
        {
            WSdeber.WebServiceSoapClient ws = new WSdeber.WebServiceSoapClient();
            DataSet ds = ws.eliminardep(Convert.ToInt32(hdf_dep.Value));
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('datos eliminados')", true);
            cargardatos();
            limpiar();
        }

        protected void Lnk_Seleccionar_Click(object sender, EventArgs e)
        {
            int depid = Convert.ToInt32((sender as LinkButton).CommandArgument);
            WSdeber.WebServiceSoapClient ws = new WSdeber.WebServiceSoapClient();
            DataSet ds = ws.ListadepaN(depid);
            hdf_dep.Value = depid.ToString();
            XmlDocument docum = new XmlDocument();
            docum.LoadXml(ds.GetXml());
            XmlNodeList eleent = docum.GetElementsByTagName("descripcionDep");
            Txt_des.Text = eleent[0].InnerXml;
        }
    }
}