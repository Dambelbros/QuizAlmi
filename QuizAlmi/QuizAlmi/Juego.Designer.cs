namespace QuizAlmi
{
    partial class Juego
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.panelPregunta = new System.Windows.Forms.Panel();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.btnResp1 = new System.Windows.Forms.Button();
            this.btnResp3 = new System.Windows.Forms.Button();
            this.btnResp2 = new System.Windows.Forms.Button();
            this.btnResp4 = new System.Windows.Forms.Button();
            this.contraReloj = new System.Windows.Forms.Timer(this.components);
            this.panelAclaracion = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblAclaracion = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.panelPregunta.SuspendLayout();
            this.panelAclaracion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNivel);
            this.panel1.Controls.Add(this.lblSegundos);
            this.panel1.Controls.Add(this.lblPuntos);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 45);
            this.panel1.TabIndex = 0;
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Location = new System.Drawing.Point(924, 18);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(50, 13);
            this.lblNivel.TabIndex = 3;
            this.lblNivel.Text = "Pregunta";
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.Location = new System.Drawing.Point(1009, 18);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(26, 13);
            this.lblSegundos.TabIndex = 2;
            this.lblSegundos.Text = "Seg";
            this.lblSegundos.Visible = false;
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Location = new System.Drawing.Point(84, 18);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(40, 13);
            this.lblPuntos.TabIndex = 1;
            this.lblPuntos.Text = "Puntos";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(11, 18);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(898, 68);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(288, 219);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbImagen.TabIndex = 1;
            this.pbImagen.TabStop = false;
            // 
            // panelPregunta
            // 
            this.panelPregunta.Controls.Add(this.panelAclaracion);
            this.panelPregunta.Controls.Add(this.btnResp4);
            this.panelPregunta.Controls.Add(this.btnResp2);
            this.panelPregunta.Controls.Add(this.btnResp3);
            this.panelPregunta.Controls.Add(this.btnResp1);
            this.panelPregunta.Controls.Add(this.lblPregunta);
            this.panelPregunta.Location = new System.Drawing.Point(38, 81);
            this.panelPregunta.Name = "panelPregunta";
            this.panelPregunta.Size = new System.Drawing.Size(997, 448);
            this.panelPregunta.TabIndex = 2;
            this.panelPregunta.Visible = false;
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Location = new System.Drawing.Point(183, 48);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(199, 13);
            this.lblPregunta.TabIndex = 0;
            this.lblPregunta.Text = "¿333333333333333333333333333333?";
            // 
            // btnResp1
            // 
            this.btnResp1.Location = new System.Drawing.Point(40, 118);
            this.btnResp1.Name = "btnResp1";
            this.btnResp1.Size = new System.Drawing.Size(367, 128);
            this.btnResp1.TabIndex = 3;
            this.btnResp1.UseVisualStyleBackColor = true;
            this.btnResp1.Click += new System.EventHandler(this.btnResp1_Click);
            // 
            // btnResp3
            // 
            this.btnResp3.Location = new System.Drawing.Point(40, 268);
            this.btnResp3.Name = "btnResp3";
            this.btnResp3.Size = new System.Drawing.Size(367, 132);
            this.btnResp3.TabIndex = 4;
            this.btnResp3.UseVisualStyleBackColor = true;
            this.btnResp3.Click += new System.EventHandler(this.btnResp3_Click);
            // 
            // btnResp2
            // 
            this.btnResp2.Location = new System.Drawing.Point(487, 118);
            this.btnResp2.Name = "btnResp2";
            this.btnResp2.Size = new System.Drawing.Size(367, 128);
            this.btnResp2.TabIndex = 5;
            this.btnResp2.UseVisualStyleBackColor = true;
            this.btnResp2.Click += new System.EventHandler(this.btnResp2_Click);
            // 
            // btnResp4
            // 
            this.btnResp4.Location = new System.Drawing.Point(487, 270);
            this.btnResp4.Name = "btnResp4";
            this.btnResp4.Size = new System.Drawing.Size(367, 128);
            this.btnResp4.TabIndex = 6;
            this.btnResp4.UseVisualStyleBackColor = true;
            this.btnResp4.Click += new System.EventHandler(this.btnResp4_Click);
            // 
            // contraReloj
            // 
            this.contraReloj.Tick += new System.EventHandler(this.contraReloj_Tick);
            // 
            // panelAclaracion
            // 
            this.panelAclaracion.Controls.Add(this.btnSiguiente);
            this.panelAclaracion.Controls.Add(this.lblAclaracion);
            this.panelAclaracion.Controls.Add(this.lblResultado);
            this.panelAclaracion.Location = new System.Drawing.Point(0, 0);
            this.panelAclaracion.Name = "panelAclaracion";
            this.panelAclaracion.Size = new System.Drawing.Size(967, 491);
            this.panelAclaracion.TabIndex = 7;
            this.panelAclaracion.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(155, 76);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(35, 13);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "label1";
            // 
            // lblAclaracion
            // 
            this.lblAclaracion.AutoSize = true;
            this.lblAclaracion.Location = new System.Drawing.Point(155, 205);
            this.lblAclaracion.Name = "lblAclaracion";
            this.lblAclaracion.Size = new System.Drawing.Size(35, 13);
            this.lblAclaracion.TabIndex = 1;
            this.lblAclaracion.Text = "label1";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(779, 387);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(158, 48);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 584);
            this.Controls.Add(this.panelPregunta);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.panel1);
            this.Name = "Juego";
            this.Text = "Juegp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.panelPregunta.ResumeLayout(false);
            this.panelPregunta.PerformLayout();
            this.panelAclaracion.ResumeLayout(false);
            this.panelAclaracion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Panel panelPregunta;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.Button btnResp4;
        private System.Windows.Forms.Button btnResp2;
        private System.Windows.Forms.Button btnResp3;
        private System.Windows.Forms.Button btnResp1;
        private System.Windows.Forms.Timer contraReloj;
        private System.Windows.Forms.Panel panelAclaracion;
        private System.Windows.Forms.Label lblAclaracion;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnSiguiente;
    }
}