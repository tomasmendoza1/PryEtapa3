namespace PryEtapa3
{
    partial class FrmPrincipal
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
            this.BtnCrearAuto = new System.Windows.Forms.Button();
            this.BtnCrearAvion = new System.Windows.Forms.Button();
            this.BtnCrearBarco = new System.Windows.Forms.Button();
            this.LblVehiculoSeleccionado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCrearAuto
            // 
            this.BtnCrearAuto.Location = new System.Drawing.Point(12, 292);
            this.BtnCrearAuto.Name = "BtnCrearAuto";
            this.BtnCrearAuto.Size = new System.Drawing.Size(153, 43);
            this.BtnCrearAuto.TabIndex = 0;
            this.BtnCrearAuto.Text = "Auto ";
            this.BtnCrearAuto.UseVisualStyleBackColor = true;
            this.BtnCrearAuto.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnCrearAvion
            // 
            this.BtnCrearAvion.Location = new System.Drawing.Point(171, 292);
            this.BtnCrearAvion.Name = "BtnCrearAvion";
            this.BtnCrearAvion.Size = new System.Drawing.Size(153, 43);
            this.BtnCrearAvion.TabIndex = 1;
            this.BtnCrearAvion.Text = "Avión ";
            this.BtnCrearAvion.UseVisualStyleBackColor = true;
            this.BtnCrearAvion.Click += new System.EventHandler(this.BtnCrearAvion_Click);
            // 
            // BtnCrearBarco
            // 
            this.BtnCrearBarco.Location = new System.Drawing.Point(328, 292);
            this.BtnCrearBarco.Name = "BtnCrearBarco";
            this.BtnCrearBarco.Size = new System.Drawing.Size(153, 43);
            this.BtnCrearBarco.TabIndex = 2;
            this.BtnCrearBarco.Text = "Barco";
            this.BtnCrearBarco.UseVisualStyleBackColor = true;
            this.BtnCrearBarco.Click += new System.EventHandler(this.BtnCrearBarco_Click);
            // 
            // LblVehiculoSeleccionado
            // 
            this.LblVehiculoSeleccionado.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVehiculoSeleccionado.Location = new System.Drawing.Point(205, 243);
            this.LblVehiculoSeleccionado.Name = "LblVehiculoSeleccionado";
            this.LblVehiculoSeleccionado.Size = new System.Drawing.Size(110, 33);
            this.LblVehiculoSeleccionado.TabIndex = 3;
            this.LblVehiculoSeleccionado.Text = "                      ";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(493, 347);
            this.Controls.Add(this.LblVehiculoSeleccionado);
            this.Controls.Add(this.BtnCrearBarco);
            this.Controls.Add(this.BtnCrearAvion);
            this.Controls.Add(this.BtnCrearAuto);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etapa 3 - CREAR OBJETOS POR CÓDIGO";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCrearAuto;
        private System.Windows.Forms.Button BtnCrearAvion;
        private System.Windows.Forms.Button BtnCrearBarco;
        private System.Windows.Forms.Label LblVehiculoSeleccionado;
    }
}

