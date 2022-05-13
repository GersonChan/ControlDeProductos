using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlDeProductos
{
    public partial class Update : System.Web.UI.Page
    {
        static List<Electronico> electronicos = new List<Electronico>();

        static string codigo;

        protected void Page_Load(object sender, EventArgs e)
        {
            leer();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            codigo = txtCodigo.Text; 
            bool electronicoEncontrado = false;
            Electronico el = electronicos.Find(c => c.codigo == codigo);
            if (el != null)
            {
                txtNombre.Text = el.nombre;
                txtDescripcion.Text = el.descripcion;
                txtCompra.Text = Convert.ToString(el.precioCompra);
                txtVenta.Text = Convert.ToString(el.precioVenta);
                txtGarantia.Text = el.tiempoGarantia;
                electronicoEncontrado = true;
            }
            
            
            if (!electronicoEncontrado)
            {
                Response.Write("<script>alert('No se encotro al alumno')</script>");
                txtNombre.Text = "";
                txtDescripcion.Text = "";
                txtCompra.Text = "";
                txtVenta.Text = "";
                txtGarantia.Text = "";
            }
        }

        private void leer()
        {
            string archivo = Server.MapPath("~/producto.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            electronicos = JsonConvert.DeserializeObject<List<Electronico>>(json);
        }

        protected void btnAcutualizar_Click(object sender, EventArgs e)
        {
            int actualizarElectronico = electronicos.FindIndex(c => c.codigo == codigo);
            if (actualizarElectronico > -1)
            {
                electronicos[actualizarElectronico].nombre = txtNombre.Text;
                electronicos[actualizarElectronico].descripcion = txtDescripcion.Text;
                electronicos[actualizarElectronico].precioCompra = Convert.ToInt16(txtCompra.Text);
                electronicos[actualizarElectronico].precioVenta = Convert.ToInt16(txtVenta.Text);
                electronicos[actualizarElectronico].tiempoGarantia = txtGarantia.Text;

                guardar();
            }
        }

        private void guardar()
        {
            string archivo = Server.MapPath("~/producto.json");
            string json = JsonConvert.SerializeObject(electronicos);
            System.IO.File.WriteAllText(archivo, json);
        }
    }
}