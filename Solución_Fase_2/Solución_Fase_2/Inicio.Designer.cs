namespace Solución_Fase_2
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.lblautor = new System.Windows.Forms.Label();
            this.lblcontraseña = new System.Windows.Forms.Label();
            this.lblapp = new System.Windows.Forms.Label();
            this.lblhotel = new System.Windows.Forms.Label();
            this.lblestudiante = new System.Windows.Forms.Label();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.btningresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblautor
            // 
            this.lblautor.AutoSize = true;
            this.lblautor.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblautor.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblautor.Location = new System.Drawing.Point(122, 108);
            this.lblautor.Name = "lblautor";
            this.lblautor.Size = new System.Drawing.Size(54, 19);
            this.lblautor.TabIndex = 0;
            this.lblautor.Text = "Autor";
            // 
            // lblcontraseña
            // 
            this.lblcontraseña.AutoSize = true;
            this.lblcontraseña.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblcontraseña.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontraseña.Location = new System.Drawing.Point(122, 215);
            this.lblcontraseña.Name = "lblcontraseña";
            this.lblcontraseña.Size = new System.Drawing.Size(99, 19);
            this.lblcontraseña.TabIndex = 1;
            this.lblcontraseña.Text = "Contraseña";
            // 
            // lblapp
            // 
            this.lblapp.AutoSize = true;
            this.lblapp.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblapp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapp.Location = new System.Drawing.Point(122, 160);
            this.lblapp.Name = "lblapp";
            this.lblapp.Size = new System.Drawing.Size(99, 19);
            this.lblapp.TabIndex = 2;
            this.lblapp.Text = "Aplicación";
            // 
            // lblhotel
            // 
            this.lblhotel.AutoSize = true;
            this.lblhotel.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblhotel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhotel.Location = new System.Drawing.Point(401, 160);
            this.lblhotel.Name = "lblhotel";
            this.lblhotel.Size = new System.Drawing.Size(99, 19);
            this.lblhotel.TabIndex = 3;
            this.lblhotel.Text = "Hotel Unad";
            // 
            // lblestudiante
            // 
            this.lblestudiante.AutoSize = true;
            this.lblestudiante.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblestudiante.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestudiante.Location = new System.Drawing.Point(351, 108);
            this.lblestudiante.Name = "lblestudiante";
            this.lblestudiante.Size = new System.Drawing.Size(252, 19);
            this.lblestudiante.TabIndex = 4;
            this.lblestudiante.Text = "Juan Carlos Villar Quintero";
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtcontraseña.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtcontraseña.Location = new System.Drawing.Point(396, 217);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.PasswordChar = '*';
            this.txtcontraseña.Size = new System.Drawing.Size(95, 20);
            this.txtcontraseña.TabIndex = 5;
            // 
            // btningresar
            // 
            this.btningresar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btningresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btningresar.Location = new System.Drawing.Point(405, 257);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(75, 23);
            this.btningresar.TabIndex = 6;
            this.btningresar.Text = "&Ingresar";
            this.btningresar.UseVisualStyleBackColor = false;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.lblestudiante);
            this.Controls.Add(this.lblhotel);
            this.Controls.Add(this.lblapp);
            this.Controls.Add(this.lblcontraseña);
            this.Controls.Add(this.lblautor);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblautor;
        private System.Windows.Forms.Label lblcontraseña;
        private System.Windows.Forms.Label lblapp;
        private System.Windows.Forms.Label lblhotel;
        private System.Windows.Forms.Label lblestudiante;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.Button btningresar;
    }
}

