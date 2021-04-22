using MVCCrudApi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace FormPost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:44381/api/Tb_PersonasFisicas";

            Tb_PersonasFisicas oPersona = new Tb_PersonasFisicas();
            
            oPersona.FechaRegistro = Convert.ToDateTime(txtFR.Text);
            oPersona.FechaActualizacion = Convert.ToDateTime(txtFA.Text);
            oPersona.Nombre = txtNom.Text;
            oPersona.ApellidoPaterno = txtAP.Text;
            oPersona.ApellidoMaterno = txtAM.Text;
            oPersona.RFC = txtRFC.Text;
            oPersona.FechaNacimiento = Convert.ToDateTime(txtFN.Text);
            oPersona.UsuarioAgrega = int.Parse(txtUA.Text);
            oPersona.Activo = bool.Parse(txtAct.Text);

            string resultado = Send<Tb_PersonasFisicas>(url, oPersona, "POST");
        }

        public string Send<T>(string url, T objectRequest, string method = "POST")
        {
            string result = "";
            try
            {
                JavaScriptSerializer js = new JavaScriptSerializer();

                //serializamos el objeto
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(objectRequest);

                //peticion
                WebRequest request = WebRequest.Create(url);
                //headers
                request.Method = method;
                request.PreAuthenticate = true;
                request.ContentType = "application/json;charset=utf-8'";
                request.Timeout = 10000;

                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(json);
                    streamWriter.Flush();
                }

                var httpResponse = (HttpWebResponse)request.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }
            }
            catch (Exception e)
            {

                result = e.Message;
            }

            return result;
        }
    }
}
