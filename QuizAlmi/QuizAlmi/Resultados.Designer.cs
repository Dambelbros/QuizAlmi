namespace QuizAlmi
{
    partial class Resultados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dvgResultados = new System.Windows.Forms.DataGridView();
            this.preg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.res = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgResultados)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(16)))), ((int)(((byte)(22)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(16)))), ((int)(((byte)(22)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgResultados.DefaultCellStyle = dataGridViewCellStyle3;
            this.dvgResultados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(16)))), ((int)(((byte)(22)))));
            this.dvgResultados.Location = new System.Drawing.Point(12, 132);
            this.dvgResultados.Name = "dvgResultados";
            this.dvgResultados.ReadOnly = true;
            this.dvgResultados.RowHeadersVisible = false;
            this.dvgResultados.ShowCellErrors = false;
            this.dvgResultados.ShowCellToolTips = false;
            this.dvgResultados.ShowEditingIcon = false;
            this.dvgResultados.ShowRowErrors = false;
            this.dvgResultados.Size = new System.Drawing.Size(776, 495);
            this.dvgResultados.TabIndex = 3;
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
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Cascadia Mono", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(12, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(776, 97);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Preguntas de ";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(16)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(800, 639);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dvgResultados);
            this.MaximizeBox = false;
            this.Name = "Resultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultados";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Resultados_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dvgResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn preg;
        private System.Windows.Forms.DataGridViewTextBoxColumn res;
        private System.Windows.Forms.Label lblNombre;
    }
}