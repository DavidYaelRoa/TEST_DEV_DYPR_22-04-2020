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

namespace FormDelete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:44381/api/Tb_PersonasFisicas/";

            Tb_PersonasFisicas oPersona = new Tb_PersonasFisicas();

            oPersona.IdPersonaFisica = int.Parse(txtID.Text);

            url = url + txtID.Text;

            string resultado = Send<Tb_PersonasFisicas>(url, oPersona, oPersona.IdPersonaFisica, "DELETE");
        }
        public string Send<T>(string url, T objectRequest, int id, string method = "DELETE")
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
