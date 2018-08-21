namespace ReproductorMp3
{
    partial class PantallaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPrincipal));
            this.ReproductorMp3 = new AxWMPLib.AxWindowsMediaPlayer();
            this.listBoxCanciones = new System.Windows.Forms.ListBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ReproductorMp3)).BeginInit();
            this.SuspendLayout();
            // 
            // ReproductorMp3
            // 
            this.ReproductorMp3.Enabled = true;
            this.ReproductorMp3.Location = new System.Drawing.Point(51, 294);
            this.ReproductorMp3.Name = "ReproductorMp3";
            this.ReproductorMp3.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("ReproductorMp3.OcxState")));
            this.ReproductorMp3.Size = new System.Drawing.Size(405, 144);
            this.ReproductorMp3.TabIndex = 0;
            // 
            // listBoxCanciones
            // 
            this.listBoxCanciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCanciones.FormattingEnabled = true;
            this.listBoxCanciones.ItemHeight = 16;
            this.listBoxCanciones.Location = new System.Drawing.Point(51, 22);
            this.listBoxCanciones.Name = "listBoxCanciones";
            this.listBoxCanciones.Size = new System.Drawing.Size(405, 148);
            this.listBoxCanciones.TabIndex = 1;
            this.listBoxCanciones.Click += new System.EventHandler(this.listBoxCanciones_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.AutoSize = true;
            this.buttonAgregar.Location = new System.Drawing.Point(75, 234);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(131, 37);
            this.buttonAgregar.TabIndex = 2;
            this.buttonAgregar.Text = "Agregar Canciones";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(301, 234);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(131, 37);
            this.buttonEliminar.TabIndex = 4;
            this.buttonEliminar.Text = "Eliminar Canciones";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 450);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.listBoxCanciones);
            this.Controls.Add(this.ReproductorMp3);
            this.MaximizeBox = false;
            this.Name = "PantallaPrincipal";
            this.Text = "Reproductor";
            this.Load += new System.EventHandler(this.PantallaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReproductorMp3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer ReproductorMp3;
        private System.Windows.Forms.ListBox listBoxCanciones;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEliminar;        
    }
}

