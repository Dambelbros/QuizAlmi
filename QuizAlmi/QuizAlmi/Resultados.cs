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
    public partial class Resultados : Form
    {
        private Newtonsoft.Json.Linq.JObject preguntas;
        private TopTen tt;

        public Resultados(TopTen tt, string idPartida)
        {
            InitializeComponent();

            this.tt = tt;

            String url = "http://192.168.0.120:8080/api/partida/partidaCompleta/" + idPartida;

            HttpWebRequest pet = WebRequest.Create(url) as HttpWebRequest;
            pet.Method = "GET";

            HttpWebResponse res = pet.GetResponse() as HttpWebResponse;

            using (StreamReader reader = new StreamReader(res.GetResponseStream()))
            {
                string json = reader.ReadToEnd();
                preguntas = (Newtonsoft.Json.Linq.JObject)Newtonsoft.Json.JsonConvert.DeserializeObject(json);

                int tamano = preguntas["data"][0]["preguntas"].Count();
                string nombre_jugador = preguntas["data"][0]["jugador"].ToString();

                lblNombre.Text += nombre_jugador;

                for (int i = 0; i < tamano; i++) {
                    string titulo, resultado;
                    titulo = preguntas["data"][0]["preg"][i]["titulo"].ToString();
                    resultado = preguntas["data"][0]["preguntas"][i]["acertado"].ToString() == "True" ? "Acertado" : "Fallado";

                    dvgResultados.Rows.Add(titulo, resultado);
                }
            }
        }

        private void Resultados_FormClosed(object sender, FormClosedEventArgs e)
        {
            tt.ventanaRAbierta = false;
        }
    }
}
