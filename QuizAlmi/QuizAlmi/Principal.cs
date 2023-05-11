﻿using System;
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
        public Principal()
        {
            InitializeComponent();
            /*
            String url = "http://192.168.0.161:8080/api/preguntas/" + "informatica";

            HttpWebRequest pet = WebRequest.Create(url) as HttpWebRequest;
            pet.Method = "GET";

            HttpWebResponse res = pet.GetResponse() as HttpWebResponse;
            Newtonsoft.Json.Linq.JObject objeto;

            using (StreamReader reader = new StreamReader(res.GetResponseStream()))
            {
                string json = reader.ReadToEnd();
                objeto = (Newtonsoft.Json.Linq.JObject)Newtonsoft.Json.JsonConvert.DeserializeObject(json);
                Console.WriteLine(objeto);
            }
            */
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length > 0)
            {
                nombre = txtNombre.Text;
                panelIniciar.Visible = false;
                panelTemas.Visible = true;
            }
        }

        private void btnTemaInformatica_Click(object sender, EventArgs e)
        {
            String url = "http://192.168.0.161:8080/api/preguntas";

            HttpWebRequest pet = WebRequest.Create(url) as HttpWebRequest;
            pet.Method = "GET";

            HttpWebResponse res = pet.GetResponse() as HttpWebResponse;
            Newtonsoft.Json.Linq.JObject objeto;

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
