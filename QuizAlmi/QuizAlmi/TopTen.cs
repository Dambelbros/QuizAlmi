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
    public partial class TopTen : Form
    {
        private Newtonsoft.Json.Linq.JObject partidas;
        private Resultados r;
        public Boolean ventanaRAbierta = false;
        private Principal p;

        public TopTen(Principal p)
        {
            InitializeComponent();
            
            this.p = p;

            String url = "http://192.168.0.120:8080/api/partida/topJugadas";

            HttpWebRequest pet = WebRequest.Create(url) as HttpWebRequest;
            pet.Method = "GET";

            HttpWebResponse res = pet.GetResponse() as HttpWebResponse;

            using (StreamReader reader = new StreamReader(res.GetResponseStream()))
            {
                string json = reader.ReadToEnd();
                partidas = (Newtonsoft.Json.Linq.JObject)Newtonsoft.Json.JsonConvert.DeserializeObject(json);

                int pos = 1;
                foreach (var partida in partidas["data"])
                {
                    Console.WriteLine(partida);
                    dvgRecord.Rows.Add(pos.ToString() + "º", partida["jugador"], partida["puntos"] + " puntos", partida["_id"]);
                    pos++;
                }
            }
        }

        private void dvgRecord_DoubleClick(object sender, EventArgs e)
        {
            if (!ventanaRAbierta)
            {
                ventanaRAbierta = true;
                string idPartida = dvgRecord.Rows[dvgRecord.CurrentCell.RowIndex].Cells[3].Value.ToString();

                r = new Resultados(this, idPartida);
                r.Show();
            }
        }

        private void TopTen_FormClosed(object sender, FormClosedEventArgs e)
        {
            p.ventanaTtAbierta = false;
            if (!(r is null))
            {
                r.Dispose();
            }
        }
    }
}
