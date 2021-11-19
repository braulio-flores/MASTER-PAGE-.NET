using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Entregable4
{
    public partial class Peliculas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                Globales.peliculas = new ArrayList();
                Globales.peliculas.Add(new Pelicula(1, "Star Wars", "México"));
                

                foreach (Pelicula p in Globales.peliculas)
                {
                    contPeliculas.Text += "<tr>";
                    contPeliculas.Text += "<td>" + p.Id + "</ td >";
                    contPeliculas.Text += "<td>" + p.Nombre + "</ td >";
                    contPeliculas.Text += "<td>" + p.Pais + "</ td >";
                    contPeliculas.Text += "</tr>";
                }
            }
        }

        protected void agregarPeli(object sender, EventArgs e)
        {
            Pelicula id = (Pelicula)Globales.peliculas[Globales.peliculas.Count - 1];
            int idn = id.Id +1 ;
            string pais = dropPais.SelectedValue;
            string nombreP = lblNewPeli.Text;

            Globales.peliculas.Add(new Pelicula(idn, nombreP, pais));

            Pelicula añadido = (Pelicula)Globales.peliculas[Globales.peliculas.Count - 1];
            contPeliculas.Text += "<tr>";
            contPeliculas.Text += "<td>" + añadido.Id + "</ td >";
            contPeliculas.Text += "<td>" + añadido.Nombre + "</ td >";
            contPeliculas.Text += "<td>" + añadido.Pais + "</ td >";
            contPeliculas.Text += "</tr>";
        }
    }
}