using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ServiceReference1.ServiceSoapClient uno = new ServiceReference1.ServiceSoapClient();
        texton.Text = uno.FechaHora();

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        ServiceReference1.ServiceSoapClient dos = new ServiceReference1.ServiceSoapClient();
        texton.Text = dos.HelloWorld();

    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        ServiceReference1.ServiceSoapClient tres = new ServiceReference1.ServiceSoapClient();
        texton.Text = tres.Saludo(nombren.Text);


    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        ServiceReference1.ServiceSoapClient cuatro = new ServiceReference1.ServiceSoapClient();
        fechan.Text = cuatro.fecha();
        horan.Text = cuatro.hora();

    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        ServiceReference1.ServiceSoapClient cinco = new ServiceReference1.ServiceSoapClient();
        texton.Text = cinco.maquina();

    }
}