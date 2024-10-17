namespace Rayuela
{
    partial class Ficha
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.btnInformar = new System.Windows.Forms.Button();
            this.pctImagen = new System.Windows.Forms.PictureBox();
            this.cmbFaltas = new System.Windows.Forms.ComboBox();
            this.cmbNotas = new System.Windows.Forms.ComboBox();
            this.btnPuntuar = new System.Windows.Forms.Button();
            this.btnAsistencia = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(23, 26);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(100, 23);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "label1";
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(23, 64);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(117, 32);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "label1";
            // 
            // lblNum
            // 
            this.lblNum.Location = new System.Drawing.Point(23, 119);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(59, 24);
            this.lblNum.TabIndex = 2;
            this.lblNum.Text = "label1";
            // 
            // lblCorreo
            // 
            this.lblCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCorreo.Location = new System.Drawing.Point(147, 115);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(179, 28);
            this.lblCorreo.TabIndex = 3;
            this.lblCorreo.Text = "label1";
            // 
            // lblCurso
            // 
            this.lblCurso.Location = new System.Drawing.Point(88, 119);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(52, 24);
            this.lblCurso.TabIndex = 4;
            this.lblCurso.Text = "label1";
            // 
            // btnInformar
            // 
            this.btnInformar.Location = new System.Drawing.Point(191, 26);
            this.btnInformar.Name = "btnInformar";
            this.btnInformar.Size = new System.Drawing.Size(95, 31);
            this.btnInformar.TabIndex = 5;
            this.btnInformar.Text = "Informar";
            this.btnInformar.UseVisualStyleBackColor = true;
            this.btnInformar.Click += new System.EventHandler(this.btnInformar_Click);
            // 
            // pctImagen
            // 
            this.pctImagen.Location = new System.Drawing.Point(54, 168);
            this.pctImagen.Name = "pctImagen";
            this.pctImagen.Size = new System.Drawing.Size(205, 156);
            this.pctImagen.TabIndex = 6;
            this.pctImagen.TabStop = false;
            // 
            // cmbFaltas
            // 
            this.cmbFaltas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFaltas.FormattingEnabled = true;
            this.cmbFaltas.Location = new System.Drawing.Point(24, 347);
            this.cmbFaltas.Name = "cmbFaltas";
            this.cmbFaltas.Size = new System.Drawing.Size(175, 21);
            this.cmbFaltas.TabIndex = 7;
            // 
            // cmbNotas
            // 
            this.cmbNotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNotas.FormattingEnabled = true;
            this.cmbNotas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbNotas.Location = new System.Drawing.Point(24, 398);
            this.cmbNotas.Name = "cmbNotas";
            this.cmbNotas.Size = new System.Drawing.Size(175, 21);
            this.cmbNotas.TabIndex = 8;
            // 
            // btnPuntuar
            // 
            this.btnPuntuar.Location = new System.Drawing.Point(215, 398);
            this.btnPuntuar.Name = "btnPuntuar";
            this.btnPuntuar.Size = new System.Drawing.Size(95, 31);
            this.btnPuntuar.TabIndex = 9;
            this.btnPuntuar.Text = "Puntuar";
            this.btnPuntuar.UseVisualStyleBackColor = true;
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.Location = new System.Drawing.Point(215, 341);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Size = new System.Drawing.Size(95, 31);
            this.btnAsistencia.TabIndex = 10;
            this.btnAsistencia.Text = "No Asiste";
            this.btnAsistencia.UseVisualStyleBackColor = true;
            this.btnAsistencia.Click += new System.EventHandler(this.btnAsistencia_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(12, 451);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(298, 31);
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Ficha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 494);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAsistencia);
            this.Controls.Add(this.btnPuntuar);
            this.Controls.Add(this.cmbNotas);
            this.Controls.Add(this.cmbFaltas);
            this.Controls.Add(this.pctImagen);
            this.Controls.Add(this.btnInformar);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblId);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ficha";
            this.Text = "Ficha";
            this.Load += new System.EventHandler(this.Ficha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Button btnInformar;
        private System.Windows.Forms.PictureBox pctImagen;
        private System.Windows.Forms.ComboBox cmbFaltas;
        private System.Windows.Forms.ComboBox cmbNotas;
        private System.Windows.Forms.Button btnPuntuar;
        private System.Windows.Forms.Button btnAsistencia;
        private System.Windows.Forms.Button btnCerrar;
    }
}