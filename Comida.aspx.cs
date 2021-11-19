using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Entregable4
{
    public partial class Comida : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                Globales.comidas = new ArrayList();
                Globales.comidas.Add(new Platillo(1,"Chilaquiles","México"));
                Globales.comidas.Add(new Platillo(2,"Sushi", "Japon"));
                Globales.comidas.Add(new Platillo(3, "Hot Dog", "EUA"));
                Globales.comidas.Add(new Platillo(4, "Paella", "España"));

                foreach (Platillo c in Globales.comidas) {
                    contentPlatillos.Text += "<tr>";
                    contentPlatillos.Text += "<td>"+ c.Id +"</ td >";
                    contentPlatillos.Text += "<td>" + c.Nombre + "</ td >";
                    contentPlatillos.Text += "<td>" + c.Pais + "</ td >";
                    contentPlatillos.Text += "</tr>";
                }
            }
        }

        protected void agregarCom(object sender, EventArgs e)
        {
            Platillo id = (Platillo)Globales.comidas[Globales.comidas.Count - 1];
            int idn = id.Id + 1;
            string pais = dropPaisComida.SelectedValue;
            string nombreP = platilloName.Text;

            Globales.comidas.Add(new Platillo(idn, nombreP, pais));

            Platillo añadido = (Platillo)Globales.comidas[Globales.comidas.Count - 1];
            contentPlatillos.Text += "<tr>";
            contentPlatillos.Text += "<td>" + añadido.Id + "</ td >";
            contentPlatillos.Text += "<td>" + añadido.Nombre + "</ td >";
            contentPlatillos.Text += "<td>" + añadido.Pais + "</ td >";
            contentPlatillos.Text += "</tr>";
        }
    }
}


