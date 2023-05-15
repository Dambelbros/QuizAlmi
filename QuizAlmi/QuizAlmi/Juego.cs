using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        public Juego(Newtonsoft.Json.Linq.JObject preguntas, Principal principal)
        {
            InitializeComponent();

            this.preguntas = preguntas;
            this.principal = principal;

            lblPuntos.Text = puntos.ToString() + " puntos";
            lblNivel.Text = "Pregunta: " + (nivel + 1).ToString();
            lblNombre.Text = principal.nombre.ToString();

            /*Configuracion Timer*/
            cambioImagen.Interval = 2000;
            cambioImagen.Tick += new EventHandler(tickTimerCambioImagen);

            contraReloj.Interval = 1000;

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
                pbImagen.ImageLocation = "http://192.168.0.120" + preguntas["data"][nivel]["foto"].ToString();
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
                if (acertado)
                {
                   if( preguntas["data"][nivel]["dificultad"].ToString()== "Facil")
                   {
                        puntos += 100 + segundos;
                   }else if (preguntas["data"][nivel]["dificultad"].ToString() == "Media")
                   {
                        puntos += 200 + segundos*2;
                   }else if (preguntas["data"][nivel]["dificultad"].ToString() == "Dificil")
                   {
                        puntos += 300 + segundos*3;
                   }
                    lblResultado.Text = "Has Acertado";
                    pbResultado.BackgroundImage = global::QuizAlmi.Properties.Resources.acierto;
                }
                else
                {
                    lblResultado.Text = "Has Fallado";
                    pbResultado.BackgroundImage = global::QuizAlmi.Properties.Resources.fallo;
                }
                lblAclaracion.Text = preguntas["data"][nivel]["aclaracion"].ToString();
                lblPuntos.Text = puntos.ToString() + " puntos";
            } else if(estado == 3)
            {
                nivel++;
                if (nivel >= preguntas["data"].Count())
                {
                    Console.WriteLine("Ultimo nivel");
                    siguienteEstado();
                } else
                {
                    estado = -1;
                    siguienteEstado();
                }
            } else if (estado == 4)
            {
                panelFinal.Visible = true;
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
            siguienteEstado();
        }

        private void Juego_FormClosed(object sender, FormClosedEventArgs e)
        {
            principal.Dispose();
        }

        private void pbImagen_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Console.WriteLine("Cargado");
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
