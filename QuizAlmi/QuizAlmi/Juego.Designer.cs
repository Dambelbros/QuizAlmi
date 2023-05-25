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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.botnCoSP = new QuizAlmi.Botn();
            this.botnCo50 = new QuizAlmi.Botn();
            this.botnCoTE = new QuizAlmi.Botn();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.panelPregunta = new System.Windows.Forms.Panel();
            this.botnResp4 = new QuizAlmi.Botn();
            this.botnResp3 = new QuizAlmi.Botn();
            this.botnResp2 = new QuizAlmi.Botn();
            this.botnResp1 = new QuizAlmi.Botn();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.panelAclaracion = new System.Windows.Forms.Panel();
            this.pbResultado = new System.Windows.Forms.PictureBox();
            this.botnSiguiente = new QuizAlmi.Botn();
            this.lblAclaracion = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.contraReloj = new System.Windows.Forms.Timer(this.components);
            this.panelFinal = new System.Windows.Forms.Panel();
            this.botnVolver = new QuizAlmi.Botn();
            this.dvgResultados = new System.Windows.Forms.DataGridView();
            this.preg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.res = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFinalPuntos = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.timerRespuesta = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panelPregunta.SuspendLayout();
            this.panelAclaracion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResultado)).BeginInit();
            this.panelFinal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.botnCoSP);
            this.panel1.Controls.Add(this.botnCo50);
            this.panel1.Controls.Add(this.botnCoTE);
            this.panel1.Controls.Add(this.lblNivel);
            this.panel1.Controls.Add(this.lblPuntos);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 45);
            this.panel1.TabIndex = 0;
            // 
            // botnCoSP
            // 
            this.botnCoSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.botnCoSP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.botnCoSP.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botnCoSP.BorderRadius = 10;
            this.botnCoSP.BorderSize = 0;
            this.botnCoSP.FlatAppearance.BorderSize = 0;
            this.botnCoSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botnCoSP.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botnCoSP.ForeColor = System.Drawing.Color.White;
            this.botnCoSP.Location = new System.Drawing.Point(490, 8);
            this.botnCoSP.Name = "botnCoSP";
            this.botnCoSP.Size = new System.Drawing.Size(137, 28);
            this.botnCoSP.TabIndex = 4;
            this.botnCoSP.Text = "Saltar Pregunta";
            this.botnCoSP.TextColor = System.Drawing.Color.White;
            this.botnCoSP.UseVisualStyleBackColor = false;
            this.botnCoSP.Click += new System.EventHandler(this.botnCoSP_Click);
            // 
            // botnCo50
            // 
            this.botnCo50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.botnCo50.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.botnCo50.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botnCo50.BorderRadius = 10;
            this.botnCo50.BorderSize = 0;
            this.botnCo50.FlatAppearance.BorderSize = 0;
            this.botnCo50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botnCo50.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botnCo50.ForeColor = System.Drawing.Color.White;
            this.botnCo50.Location = new System.Drawing.Point(419, 8);
            this.botnCo50.Name = "botnCo50";
            this.botnCo50.Size = new System.Drawing.Size(65, 28);
            this.botnCo50.TabIndex = 4;
            this.botnCo50.Text = "50%";
            this.botnCo50.TextColor = System.Drawing.Color.White;
            this.botnCo50.UseVisualStyleBackColor = false;
            this.botnCo50.Click += new System.EventHandler(this.botnCo50_Click);
            // 
            // botnCoTE
            // 
            this.botnCoTE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.botnCoTE.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.botnCoTE.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botnCoTE.BorderRadius = 10;
            this.botnCoTE.BorderSize = 0;
            this.botnCoTE.FlatAppearance.BorderSize = 0;
            this.botnCoTE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botnCoTE.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botnCoTE.ForeColor = System.Drawing.Color.White;
            this.botnCoTE.Location = new System.Drawing.Point(263, 8);
            this.botnCoTE.Name = "botnCoTE";
            this.botnCoTE.Size = new System.Drawing.Size(150, 28);
            this.botnCoTE.TabIndex = 4;
            this.botnCoTE.Text = "Tiempo Extra";
            this.botnCoTE.TextColor = System.Drawing.Color.White;
            this.botnCoTE.UseVisualStyleBackColor = false;
            this.botnCoTE.Click += new System.EventHandler(this.botnCoTE_Click);
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.ForeColor = System.Drawing.Color.White;
            this.lblNivel.Location = new System.Drawing.Point(742, 12);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(82, 21);
            this.lblNivel.TabIndex = 3;
            this.lblNivel.Text = "Pregunta";
            this.lblNivel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntos.ForeColor = System.Drawing.Color.White;
            this.lblPuntos.Location = new System.Drawing.Point(110, 12);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(64, 21);
            this.lblPuntos.TabIndex = 1;
            this.lblPuntos.Text = "Puntos";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(11, 10);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 21);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.Font = new System.Drawing.Font("Cascadia Mono", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundos.ForeColor = System.Drawing.Color.White;
            this.lblSegundos.Location = new System.Drawing.Point(720, -19);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(151, 85);
            this.lblSegundos.TabIndex = 2;
            this.lblSegundos.Text = "Seg";
            this.lblSegundos.Visible = false;
            // 
            // panelPregunta
            // 
            this.panelPregunta.Controls.Add(this.botnResp4);
            this.panelPregunta.Controls.Add(this.botnResp3);
            this.panelPregunta.Controls.Add(this.botnResp2);
            this.panelPregunta.Controls.Add(this.botnResp1);
            this.panelPregunta.Controls.Add(this.lblSegundos);
            this.panelPregunta.Controls.Add(this.lblPregunta);
            this.panelPregunta.Location = new System.Drawing.Point(12, 52);
            this.panelPregunta.Name = "panelPregunta";
            this.panelPregunta.Size = new System.Drawing.Size(870, 677);
            this.panelPregunta.TabIndex = 2;
            this.panelPregunta.Visible = false;
            // 
            // botnResp4
            // 
            this.botnResp4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.botnResp4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.botnResp4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botnResp4.BorderRadius = 40;
            this.botnResp4.BorderSize = 0;
            this.botnResp4.FlatAppearance.BorderSize = 0;
            this.botnResp4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botnResp4.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botnResp4.ForeColor = System.Drawing.Color.White;
            this.botnResp4.Location = new System.Drawing.Point(487, 434);
            this.botnResp4.Name = "botnResp4";
            this.botnResp4.Size = new System.Drawing.Size(311, 189);
            this.botnResp4.TabIndex = 10;
            this.botnResp4.TextColor = System.Drawing.Color.White;
            this.botnResp4.UseVisualStyleBackColor = false;
            this.botnResp4.Click += new System.EventHandler(this.btnResp4_Click);
            // 
            // botnResp3
            // 
            this.botnResp3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.botnResp3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.botnResp3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botnResp3.BorderRadius = 40;
            this.botnResp3.BorderSize = 0;
            this.botnResp3.FlatAppearance.BorderSize = 0;
            this.botnResp3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botnResp3.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botnResp3.ForeColor = System.Drawing.Color.White;
            this.botnResp3.Location = new System.Drawing.Point(58, 434);
            this.botnResp3.Name = "botnResp3";
            this.botnResp3.Size = new System.Drawing.Size(311, 189);
            this.botnResp3.TabIndex = 9;
            this.botnResp3.TextColor = System.Drawing.Color.White;
            this.botnResp3.UseVisualStyleBackColor = false;
            this.botnResp3.Click += new System.EventHandler(this.btnResp3_Click);
            // 
            // botnResp2
            // 
            this.botnResp2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.botnResp2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.botnResp2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botnResp2.BorderRadius = 40;
            this.botnResp2.BorderSize = 0;
            this.botnResp2.FlatAppearance.BorderSize = 0;
            this.botnResp2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botnResp2.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botnResp2.ForeColor = System.Drawing.Color.White;
            this.botnResp2.Location = new System.Drawing.Point(487, 214);
            this.botnResp2.Name = "botnResp2";
            this.botnResp2.Size = new System.Drawing.Size(311, 189);
            this.botnResp2.TabIndex = 8;
            this.botnResp2.TextColor = System.Drawing.Color.White;
            this.botnResp2.UseVisualStyleBackColor = false;
            this.botnResp2.Click += new System.EventHandler(this.btnResp2_Click);
            // 
            // botnResp1
            // 
            this.botnResp1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.botnResp1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.botnResp1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botnResp1.BorderRadius = 40;
            this.botnResp1.BorderSize = 0;
            this.botnResp1.FlatAppearance.BorderSize = 0;
            this.botnResp1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botnResp1.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botnResp1.ForeColor = System.Drawing.Color.White;
            this.botnResp1.Location = new System.Drawing.Point(58, 214);
            this.botnResp1.Name = "botnResp1";
            this.botnResp1.Size = new System.Drawing.Size(311, 189);
            this.botnResp1.TabIndex = 7;
            this.botnResp1.TextColor = System.Drawing.Color.White;
            this.botnResp1.UseVisualStyleBackColor = false;
            this.botnResp1.Click += new System.EventHandler(this.btnResp1_Click);
            // 
            // lblPregunta
            // 
            this.lblPregunta.Font = new System.Drawing.Font("Cascadia Mono", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta.ForeColor = System.Drawing.Color.White;
            this.lblPregunta.Location = new System.Drawing.Point(3, 66);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(867, 107);
            this.lblPregunta.TabIndex = 0;
            this.lblPregunta.Text = "¿?";
            this.lblPregunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAclaracion
            // 
            this.panelAclaracion.Controls.Add(this.pbResultado);
            this.panelAclaracion.Controls.Add(this.botnSiguiente);
            this.panelAclaracion.Controls.Add(this.lblAclaracion);
            this.panelAclaracion.Controls.Add(this.lblResultado);
            this.panelAclaracion.Location = new System.Drawing.Point(12, 52);
            this.panelAclaracion.Name = "panelAclaracion";
            this.panelAclaracion.Size = new System.Drawing.Size(870, 677);
            this.panelAclaracion.TabIndex = 7;
            this.panelAclaracion.Visible = false;
            // 
            // pbResultado
            // 
            this.pbResultado.BackgroundImage = global::QuizAlmi.Properties.Resources.acierto;
            this.pbResultado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbResultado.Location = new System.Drawing.Point(368, 75);
            this.pbResultado.Name = "pbResultado";
            this.pbResultado.Size = new System.Drawing.Size(70, 70);
            this.pbResultado.TabIndex = 0;
            this.pbResultado.TabStop = false;
            // 
            // botnSiguiente
            // 
            this.botnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.botnSiguiente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.botnSiguiente.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botnSiguiente.BorderRadius = 40;
            this.botnSiguiente.BorderSize = 0;
            this.botnSiguiente.FlatAppearance.BorderSize = 0;
            this.botnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botnSiguiente.Font = new System.Drawing.Font("Cascadia Mono", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botnSiguiente.ForeColor = System.Drawing.Color.White;
            this.botnSiguiente.Location = new System.Drawing.Point(478, 214);
            this.botnSiguiente.Name = "botnSiguiente";
            this.botnSiguiente.Size = new System.Drawing.Size(300, 300);
            this.botnSiguiente.TabIndex = 3;
            this.botnSiguiente.Text = ">";
            this.botnSiguiente.TextColor = System.Drawing.Color.White;
            this.botnSiguiente.UseVisualStyleBackColor = false;
            this.botnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // lblAclaracion
            // 
            this.lblAclaracion.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAclaracion.ForeColor = System.Drawing.Color.White;
            this.lblAclaracion.Location = new System.Drawing.Point(152, 224);
            this.lblAclaracion.Name = "lblAclaracion";
            this.lblAclaracion.Size = new System.Drawing.Size(303, 290);
            this.lblAclaracion.TabIndex = 1;
            this.lblAclaracion.Text = "Aclaracion";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.White;
            this.lblResultado.Location = new System.Drawing.Point(444, 98);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(120, 28);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "Resultado";
            // 
            // contraReloj
            // 
            this.contraReloj.Tick += new System.EventHandler(this.contraReloj_Tick);
            // 
            // panelFinal
            // 
            this.panelFinal.Controls.Add(this.botnVolver);
            this.panelFinal.Controls.Add(this.dvgResultados);
            this.panelFinal.Controls.Add(this.lblFinalPuntos);
            this.panelFinal.Controls.Add(this.lblFinal);
            this.panelFinal.Location = new System.Drawing.Point(12, 52);
            this.panelFinal.Name = "panelFinal";
            this.panelFinal.Size = new System.Drawing.Size(870, 677);
            this.panelFinal.TabIndex = 3;
            this.panelFinal.Visible = false;
            // 
            // botnVolver
            // 
            this.botnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.botnVolver.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.botnVolver.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botnVolver.BorderRadius = 10;
            this.botnVolver.BorderSize = 0;
            this.botnVolver.FlatAppearance.BorderSize = 0;
            this.botnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botnVolver.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botnVolver.ForeColor = System.Drawing.Color.White;
            this.botnVolver.Location = new System.Drawing.Point(11, 13);
            this.botnVolver.Name = "botnVolver";
            this.botnVolver.Size = new System.Drawing.Size(89, 40);
            this.botnVolver.TabIndex = 3;
            this.botnVolver.Text = "Volver";
            this.botnVolver.TextColor = System.Drawing.Color.White;
            this.botnVolver.UseVisualStyleBackColor = false;
            this.botnVolver.Click += new System.EventHandler(this.botnVolver_Click);
            // 
            // dvgResultados
            // 
            this.dvgResultados.AllowUserToAddRows = false;
            this.dvgResultados.AllowUserToDeleteRows = false;
            this.dvgResultados.AllowUserToResizeColumns = false;
            this.dvgResultados.AllowUserToResizeRows = false;
            this.dvgResultados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(16)))), ((int)(((byte)(22)))));
            this.dvgResultados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgResultados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dvgResultados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dvgResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgResultados.ColumnHeadersVisible = false;
            this.dvgResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.preg,
            this.res});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(16)))), ((int)(((byte)(22)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(16)))), ((int)(((byte)(22)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgResultados.DefaultCellStyle = dataGridViewCellStyle1;
            this.dvgResultados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(16)))), ((int)(((byte)(22)))));
            this.dvgResultados.Location = new System.Drawing.Point(58, 209);
            this.dvgResultados.Name = "dvgResultados";
            this.dvgResultados.ReadOnly = true;
            this.dvgResultados.RowHeadersVisible = false;
            this.dvgResultados.ShowCellErrors = false;
            this.dvgResultados.ShowCellToolTips = false;
            this.dvgResultados.ShowEditingIcon = false;
            this.dvgResultados.ShowRowErrors = false;
            this.dvgResultados.Size = new System.Drawing.Size(740, 433);
            this.dvgResultados.TabIndex = 2;
            // 
            // preg
            // 
            this.preg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.preg.HeaderText = "preg";
            this.preg.Name = "preg";
            this.preg.ReadOnly = true;
            // 
            // res
            // 
            this.res.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.res.HeaderText = "res";
            this.res.Name = "res";
            this.res.ReadOnly = true;
            this.res.Width = 5;
            // 
            // lblFinalPuntos
            // 
            this.lblFinalPuntos.AutoSize = true;
            this.lblFinalPuntos.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalPuntos.ForeColor = System.Drawing.Color.White;
            this.lblFinalPuntos.Location = new System.Drawing.Point(260, 148);
            this.lblFinalPuntos.Name = "lblFinalPuntos";
            this.lblFinalPuntos.Size = new System.Drawing.Size(100, 25);
            this.lblFinalPuntos.TabIndex = 1;
            this.lblFinalPuntos.Text = "Puntos: ";
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Font = new System.Drawing.Font("Cascadia Mono", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinal.ForeColor = System.Drawing.Color.White;
            this.lblFinal.Location = new System.Drawing.Point(256, 96);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(308, 49);
            this.lblFinal.TabIndex = 0;
            this.lblFinal.Text = "Juego Acabado";
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(150, 100);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(623, 413);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 1;
            this.pbImagen.TabStop = false;
            this.pbImagen.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pbImagen_LoadCompleted);
            // 
            // timerRespuesta
            // 
            this.timerRespuesta.Interval = 3000;
            this.timerRespuesta.Tick += new System.EventHandler(this.timerRespuesta_Tick);
            // 
            // Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(16)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(889, 741);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.panelPregunta);
            this.Controls.Add(this.panelFinal);
            this.Controls.Add(this.panelAclaracion);
            this.MaximizeBox = false;
            this.Name = "Juego";
            this.Text = "Juego";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Juego_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelPregunta.ResumeLayout(false);
            this.panelPregunta.PerformLayout();
            this.panelAclaracion.ResumeLayout(false);
            this.panelAclaracion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResultado)).EndInit();
            this.panelFinal.ResumeLayout(false);
            this.panelFinal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
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
        private System.Windows.Forms.Timer contraReloj;
        private System.Windows.Forms.Panel panelAclaracion;
        private System.Windows.Forms.Label lblAclaracion;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Panel panelFinal;
        private System.Windows.Forms.Label lblFinal;
        private Botn botnResp4;
        private Botn botnResp3;
        private Botn botnResp2;
        private Botn botnResp1;
        private Botn botnSiguiente;
        private System.Windows.Forms.PictureBox pbResultado;
        private System.Windows.Forms.Label lblFinalPuntos;
        private System.Windows.Forms.DataGridViewTextBoxColumn preg;
        private System.Windows.Forms.DataGridViewTextBoxColumn res;
        private System.Windows.Forms.DataGridView dvgResultados;
        private Botn botnCoSP;
        private Botn botnCo50;
        private Botn botnCoTE;
        private System.Windows.Forms.Timer timerRespuesta;
        private Botn botnVolver;
    }
}