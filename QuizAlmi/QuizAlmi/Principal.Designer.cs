using System.Drawing;

namespace QuizAlmi
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelIniciar = new System.Windows.Forms.Panel();
            this.botnTopTen = new QuizAlmi.Botn();
            this.txtRedonNombre = new QuizAlmi.TextRedon();
            this.botnJugar = new QuizAlmi.Botn();
            this.panelTemas = new System.Windows.Forms.Panel();
            this.botnTemaCultu = new QuizAlmi.Botn();
            this.botnTemaInfor = new QuizAlmi.Botn();
            this.panelIniciar.SuspendLayout();
            this.panelTemas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelIniciar
            // 
            this.panelIniciar.Controls.Add(this.botnTopTen);
            this.panelIniciar.Controls.Add(this.txtRedonNombre);
            this.panelIniciar.Controls.Add(this.botnJugar);
            this.panelIniciar.Location = new System.Drawing.Point(12, 12);
            this.panelIniciar.Name = "panelIniciar";
            this.panelIniciar.Size = new System.Drawing.Size(870, 717);
            this.panelIniciar.TabIndex = 0;
            // 
            // botnTopTen
            // 
            this.botnTopTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.botnTopTen.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.botnTopTen.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botnTopTen.BorderRadius = 10;
            this.botnTopTen.BorderSize = 0;
            this.botnTopTen.FlatAppearance.BorderSize = 0;
            this.botnTopTen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botnTopTen.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold);
            this.botnTopTen.ForeColor = System.Drawing.Color.White;
            this.botnTopTen.Location = new System.Drawing.Point(779, 682);
            this.botnTopTen.Name = "botnTopTen";
            this.botnTopTen.Size = new System.Drawing.Size(88, 32);
            this.botnTopTen.TabIndex = 5;
            this.botnTopTen.Text = "Top 10";
            this.botnTopTen.TextColor = System.Drawing.Color.White;
            this.botnTopTen.UseVisualStyleBackColor = false;
            this.botnTopTen.Click += new System.EventHandler(this.botnTopTen_Click);
            // 
            // txtRedonNombre
            // 
            this.txtRedonNombre.AutoScroll = true;
            this.txtRedonNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.txtRedonNombre.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtRedonNombre.BorderRadius = 10;
            this.txtRedonNombre.BorderSize = 4;
            this.txtRedonNombre.Location = new System.Drawing.Point(389, 350);
            this.txtRedonNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtRedonNombre.Multiline = false;
            this.txtRedonNombre.Name = "txtRedonNombre";
            this.txtRedonNombre.Padding = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.txtRedonNombre.PasswordChar = false;
            this.txtRedonNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtRedonNombre.PlaceholderText = "";
            this.txtRedonNombre.Size = new System.Drawing.Size(132, 39);
            this.txtRedonNombre.TabIndex = 4;
            this.txtRedonNombre.Texts = "";
            this.txtRedonNombre.UnderlinedStyle = false;
            // 
            // botnJugar
            // 
            this.botnJugar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.botnJugar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.botnJugar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botnJugar.BorderRadius = 10;
            this.botnJugar.BorderSize = 0;
            this.botnJugar.FlatAppearance.BorderSize = 0;
            this.botnJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botnJugar.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botnJugar.ForeColor = System.Drawing.Color.White;
            this.botnJugar.Location = new System.Drawing.Point(389, 396);
            this.botnJugar.Name = "botnJugar";
            this.botnJugar.Size = new System.Drawing.Size(132, 30);
            this.botnJugar.TabIndex = 3;
            this.botnJugar.Text = "Jugar";
            this.botnJugar.TextColor = System.Drawing.Color.White;
            this.botnJugar.UseVisualStyleBackColor = false;
            this.botnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // panelTemas
            // 
            this.panelTemas.Controls.Add(this.botnTemaCultu);
            this.panelTemas.Controls.Add(this.botnTemaInfor);
            this.panelTemas.Location = new System.Drawing.Point(12, 12);
            this.panelTemas.Name = "panelTemas";
            this.panelTemas.Size = new System.Drawing.Size(870, 717);
            this.panelTemas.TabIndex = 1;
            this.panelTemas.Visible = false;
            // 
            // botnTemaCultu
            // 
            this.botnTemaCultu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.botnTemaCultu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.botnTemaCultu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botnTemaCultu.BorderRadius = 10;
            this.botnTemaCultu.BorderSize = 0;
            this.botnTemaCultu.FlatAppearance.BorderSize = 0;
            this.botnTemaCultu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botnTemaCultu.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botnTemaCultu.ForeColor = System.Drawing.Color.White;
            this.botnTemaCultu.Location = new System.Drawing.Point(364, 396);
            this.botnTemaCultu.Name = "botnTemaCultu";
            this.botnTemaCultu.Size = new System.Drawing.Size(182, 30);
            this.botnTemaCultu.TabIndex = 1;
            this.botnTemaCultu.Text = "Cultura General";
            this.botnTemaCultu.TextColor = System.Drawing.Color.White;
            this.botnTemaCultu.UseVisualStyleBackColor = false;
            this.botnTemaCultu.Click += new System.EventHandler(this.btnTemaCultura_Click);
            // 
            // botnTemaInfor
            // 
            this.botnTemaInfor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.botnTemaInfor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.botnTemaInfor.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botnTemaInfor.BorderRadius = 10;
            this.botnTemaInfor.BorderSize = 0;
            this.botnTemaInfor.FlatAppearance.BorderSize = 0;
            this.botnTemaInfor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botnTemaInfor.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botnTemaInfor.ForeColor = System.Drawing.Color.White;
            this.botnTemaInfor.Location = new System.Drawing.Point(364, 354);
            this.botnTemaInfor.Name = "botnTemaInfor";
            this.botnTemaInfor.Size = new System.Drawing.Size(182, 30);
            this.botnTemaInfor.TabIndex = 1;
            this.botnTemaInfor.Text = "Informática";
            this.botnTemaInfor.TextColor = System.Drawing.Color.White;
            this.botnTemaInfor.UseVisualStyleBackColor = false;
            this.botnTemaInfor.Click += new System.EventHandler(this.btnTemaInformatica_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(16)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(894, 741);
            this.Controls.Add(this.panelIniciar);
            this.Controls.Add(this.panelTemas);
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.Text = "Menu";
            this.panelIniciar.ResumeLayout(false);
            this.panelTemas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelIniciar;
        private System.Windows.Forms.Panel panelTemas;
        private Botn botnJugar;
        private TextRedon txtRedonNombre;
        private Botn botnTemaInfor;
        private Botn botnTemaCultu;
        private Botn botnTopTen;
    }
}

