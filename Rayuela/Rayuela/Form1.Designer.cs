
namespace Rayuela
{
    partial class FormRayuela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRayuela));
            this.tabCursos = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // tabCursos
            // 
            this.tabCursos.Location = new System.Drawing.Point(22, 12);
            this.tabCursos.Name = "tabCursos";
            this.tabCursos.SelectedIndex = 0;
            this.tabCursos.Size = new System.Drawing.Size(766, 392);
            this.tabCursos.TabIndex = 0;
            this.tabCursos.SelectedIndexChanged += new System.EventHandler(this.tabCursos_SelectedIndexChanged);
            // 
            // FormRayuela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 484);
            this.Controls.Add(this.tabCursos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRayuela";
            this.Text = "Rayuela";
            this.Load += new System.EventHandler(this.FormRayuela_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCursos;
    }
}

