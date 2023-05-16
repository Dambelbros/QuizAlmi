using System;
using System.Collections;
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
    public partial class Juego : Form
    {
        Newtonsoft.Json.Linq.JObject preguntas;
        private int puntos = 0, nivel = 0, estado = -1, segundos;
        private Timer cambioImagen = new Timer();
        private Boolean acertado;
        private Principal principal;
        //private ArrayList resultados = new ArrayList();
        private String[,] resultados;

        public Juego(Newtonsoft.Json.Linq.JObject preguntas, Principal principal)
        {
            InitializeComponent();

            this.preguntas = preguntas;
            this.principal = principal;

            //resultados = new string[15][];

            lblPuntos.Text = puntos.ToString() + " puntos";
            lblNivel.Text = "Pregunta: " + (nivel + 1).ToString();
            lblNombre.Text = principal.nombre.ToString();
            resultados = new string[preguntas["data"].Count(), 3];

            /*Configuracion Timer*/
            cambioImagen.Interval = 500;
            cambioImagen.Tick += new EventHandler(tickTimerCambioImagen);

            contraReloj.Interval = 1000;

            pbImagen.ImageLocation = "http://192.168.0.120" + preguntas["data"][nivel]["foto"].ToString();
            pbImagen.LoadAsync();

            siguienteEstado();
        }

        private void siguienteEstado()
        {
            estado++;

            if (estado == 0)
            {
                lblNivel.Text = "Pregunta: " + (nivel + 1).ToString();
                panelAclaracion.Visible = false;
                pbImagen.Visible = true;
                cambioImagen.Start();
            }
            else if (estado == 1)
            {
                segundos = 30;
                lblSegundos.Text = segundos.ToString();
                lblSegundos.Visible = true;
                contraReloj.Start();
                pbImagen.Visible = false;
                panelPregunta.Visible = true;
                lblPregunta.Text = preguntas["data"][nivel]["titulo"].ToString();
                botnResp1.Text = preguntas["data"][nivel]["respuestas"][0]["frase"].ToString();
                botnResp2.Text = preguntas["data"][nivel]["respuestas"][1]["frase"].ToString();
                botnResp3.Text = preguntas["data"][nivel]["respuestas"][2]["frase"].ToString();
                botnResp4.Text = preguntas["data"][nivel]["respuestas"][3]["frase"].ToString();
            } else if (estado == 2)
            {
                panelPregunta.Visible = false;
                panelAclaracion.Visible = true;
                botnSiguiente.Enabled = false;

                resultados[nivel, 0] = preguntas["data"][nivel]["_id"].ToString();
                resultados[nivel, 1] = preguntas["data"][nivel]["titulo"].ToString();
                resultados[nivel, 2] = acertado ? "Acertado" : "Fallado";

                if (acertado)
                {
                   if( preguntas["data"][nivel]["dificultad"].ToString()== "Facil")
                   {
                        puntos += 100 + segundos;
                   }else if (preguntas["data"][nivel]["dificultad"].ToString() == "Medio")
                   {
                        puntos += 200 + segundos*2;
                   }else if (preguntas["data"][nivel]["dificultad"].ToString() == "Dificil")
                   {
                        puntos += 300 + segundos*3;
                   }
                    lblResultado.Text = "Has Acertado";
                    pbResultado.BackgroundImage = Properties.Resources.acierto;
                }
                else
                {
                    lblResultado.Text = "Has Fallado";
                    pbResultado.BackgroundImage = Properties.Resources.fallo;
                }
                Console.WriteLine(puntos);

                lblAclaracion.Text = preguntas["data"][nivel]["aclaracion"].ToString();
                lblPuntos.Text = puntos.ToString() + " puntos";

                nivel++;

                if (nivel >= preguntas["data"].Count())
                {
                    botnSiguiente.Enabled = true;
                }
                else
                {
                    pbImagen.ImageLocation = "http://192.168.0.120" + preguntas["data"][nivel]["foto"].ToString();
                    pbImagen.LoadAsync();
                }

            } else if(estado == 3)
            {
                lblFinalPuntos.Text += puntos.ToString();

                string json = "{\"nombre\": \"" + lblNombre.Text + "\",\"data\": [";

                for (int i = 0; i < preguntas["data"].Count(); i++)
                {
                    string temp = resultados[i, 2] == "Acertado" ? "true" : "false";
                    if (i == preguntas["data"].Count() - 1)
                    {
                        json += "[\"" + resultados[i, 0] + "\", " + temp + "]";
                    }
                    else
                    {
                        json += "[\"" + resultados[i, 0] + "\"," + temp +"],";
                    }
                    dvgResultados.Rows.Add(resultados[i, 1], resultados[i, 2]);
                }
                json += "]}";

                Console.WriteLine(json);

                panelFinal.Visible = true;

                String url = "http://192.168.0.120:8080/api/partida";

                
                HttpWebRequest pet = WebRequest.Create(url) as HttpWebRequest;
                pet.ContentType = "application/json";
                pet.Method = "POST";

                using (var streamWriter = new StreamWriter(pet.GetRequestStream()))
                {
                    streamWriter.Write(json);
                }

                var httpResponse = (HttpWebResponse)pet.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                }
                
            }
        }

        private void btnResp1_Click(object sender, EventArgs e)
        {
            comprobarGanador(0);
        }

        private void btnResp2_Click(object sender, EventArgs e)
        {
            comprobarGanador(1);
        }

        private void btnResp3_Click(object sender, EventArgs e)
        {
            comprobarGanador(2);
        }

        private void btnResp4_Click(object sender, EventArgs e)
        {
            comprobarGanador(3);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (nivel >= preguntas["data"].Count())
            {
                siguienteEstado();
            } else
            {
                estado = -1;
                siguienteEstado();
            }
        }

        private void Juego_FormClosed(object sender, FormClosedEventArgs e)
        {
            principal.Dispose();
        }

        private void pbImagen_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Console.WriteLine("Entra");
            if (nivel == 0)
            {
                principal.cambioVentanas();
            } else
            {
                botnSiguiente.Enabled = true;
            }
        }

        private void contraReloj_Tick(object sender, EventArgs e)
        {
            segundos--;
            lblSegundos.Text = segundos.ToString();
            if (segundos == 0)
            {
                acertado = false;
                siguienteEstado();
                contraReloj.Stop();
            }
        }

        private void tickTimerCambioImagen(object sender, EventArgs e)
        {
            cambioImagen.Stop();
            siguienteEstado();
        }

        private void comprobarGanador(int idRespuesta)
        {
            acertado = preguntas["data"][nivel]["respuestas"][idRespuesta]["correcta"].ToString() == "True" ? true : false;
            contraReloj.Stop();
            siguienteEstado();
        }
    }
}
