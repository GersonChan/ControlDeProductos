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
    public partial class _Default : Page
    {
        static List<Electronico> electronicos = new List<Electronico>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                leer();
            }
        }

        protected void btnElectronico_Click(object sender, EventArgs e)
        {
            Electronico electronicoTemp = new Electronico();
            electronicoTemp.codigo = txtCodigo.Text;
            electronicoTemp.nombre = txtNombre.Text;
            electronicoTemp.descripcion = txtDescripcion.Text;
            electronicoTemp.precioCompra = Convert.ToInt16(txtCompra.Text);
            electronicoTemp.precioVenta = Convert.ToInt16(txtVenta.Text);
            electronicoTemp.tiempoGarantia = txtGarantia.Text;
            electronicoTemp.voltaje = txtVoltaje.Text;

            electronicos.Add(electronicoTemp);
            guardar();
        }

        private void guardar()
        {
            string archivo = Server.MapPath("~/producto.json");
            string json = JsonConvert.SerializeObject(electronicos);
            System.IO.File.WriteAllText(archivo, json);
        }

        private void leer()
        {
            string archivo = Server.MapPath("~/producto.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            electronicos = JsonConvert.DeserializeObject<List<Electronico>>(json);
        }
    }
}