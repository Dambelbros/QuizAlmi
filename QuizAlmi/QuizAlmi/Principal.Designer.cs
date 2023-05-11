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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnJugar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelTemas = new System.Windows.Forms.Panel();
            this.btnTemaInformatica = new System.Windows.Forms.Button();
            this.btnTemaInformaticaIngles = new System.Windows.Forms.Button();
            this.panelIniciar.SuspendLayout();
            this.panelTemas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelIniciar
            // 
            this.panelIniciar.Controls.Add(this.btnSalir);
            this.panelIniciar.Controls.Add(this.btnJugar);
            this.panelIniciar.Controls.Add(this.txtNombre);
            this.panelIniciar.Location = new System.Drawing.Point(39, 12);
            this.panelIniciar.Name = "panelIniciar";
            this.panelIniciar.Size = new System.Drawing.Size(776, 532);
            this.panelIniciar.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(299, 195);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(183, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(350, 221);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(75, 23);
            this.btnJugar.TabIndex = 1;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(350, 261);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // panelTemas
            // 
            this.panelTemas.Controls.Add(this.btnTemaInformaticaIngles);
            this.panelTemas.Controls.Add(this.btnTemaInformatica);
            this.panelTemas.Location = new System.Drawing.Point(15, 28);
            this.panelTemas.Name = "panelTemas";
            this.panelTemas.Size = new System.Drawing.Size(773, 479);
            this.panelTemas.TabIndex = 1;
            this.panelTemas.Visible = false;
            // 
            // btnTemaInformatica
            // 
            this.btnTemaInformatica.Location = new System.Drawing.Point(307, 219);
            this.btnTemaInformatica.Name = "btnTemaInformatica";
            this.btnTemaInformatica.Size = new System.Drawing.Size(150, 23);
            this.btnTemaInformatica.TabIndex = 0;
            this.btnTemaInformatica.Text = "Informatica";
            this.btnTemaInformatica.UseVisualStyleBackColor = true;
            this.btnTemaInformatica.Click += new System.EventHandler(this.btnTemaInformatica_Click);
            // 
            // btnTemaInformaticaIngles
            // 
            this.btnTemaInformaticaIngles.Location = new System.Drawing.Point(307, 248);
            this.btnTemaInformaticaIngles.Name = "btnTemaInformaticaIngles";
            this.btnTemaInformaticaIngles.Size = new System.Drawing.Size(150, 23);
            this.btnTemaInformaticaIngles.TabIndex = 0;
            this.btnTemaInformaticaIngles.Text = "Informatica Ingles";
            this.btnTemaInformaticaIngles.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 556);
            this.Controls.Add(this.panelTemas);
            this.Controls.Add(this.panelIniciar);
            this.Name = "Principal";
            this.Text = "Form1";
            this.panelIniciar.ResumeLayout(false);
            this.panelIniciar.PerformLayout();
            this.panelTemas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelIniciar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel panelTemas;
        private System.Windows.Forms.Button btnTemaInformaticaIngles;
        private System.Windows.Forms.Button btnTemaInformatica;
    }
}

