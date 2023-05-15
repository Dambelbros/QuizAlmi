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
using System.Windows.Forms;

namespace QuizAlmi
{
    public partial class Principal : Form
    {
        public String nombre;
        private Juego juegoVentana;
        private Newtonsoft.Json.Linq.JObject objeto;
        public Principal()
        {
            InitializeComponent();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            if (txtRedonNombre.textBox1.Text.Length > 0)
            {
                nombre = txtRedonNombre.textBox1.Text;
                panelIniciar.Visible = false;
                panelTemas.Visible = true;
            }
        }

        private void btnTemaInformatica_Click(object sender, EventArgs e)
        {
            pasarAlJuego("informatica");
        }

        private void btnTemaCultura_Click(object sender, EventArgs e)
        {
            pasarAlJuego("cultura");
        }

        private void pasarAlJuego(String tema)
        {
            String url = "http://192.168.0.120:8080/api/juego/preguntas/" + tema;

            HttpWebRequest pet = WebRequest.Create(url) as HttpWebRequest;
            pet.Method = "GET";

            HttpWebResponse res = pet.GetResponse() as HttpWebResponse;

            using (StreamReader reader = new StreamReader(res.GetResponseStream()))
            {
                string json = reader.ReadToEnd();
                objeto = (Newtonsoft.Json.Linq.JObject)Newtonsoft.Json.JsonConvert.DeserializeObject(json);
                juegoVentana = new Juego(objeto, this);
                this.Hide();
                juegoVentana.Show();
            }
        }
    }
}
