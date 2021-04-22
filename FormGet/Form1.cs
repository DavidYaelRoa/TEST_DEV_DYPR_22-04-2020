using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using MVCCrudApi.Models;

namespace FormGet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string respuesta = await GetHttp();
            List<Tb_PersonasFisicas> lst = 
                JsonConvert.DeserializeObject<List<Tb_PersonasFisicas>>(respuesta);
            dataGridView1.DataSource = lst;
        }

        private async Task<string> GetHttp()
        {
            WebRequest oRequest = WebRequest.Create("https://localhost:44381/api/Tb_PersonasFisicas");
            WebResponse oResponse = oRequest.GetResponse();

            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }


    }
}
