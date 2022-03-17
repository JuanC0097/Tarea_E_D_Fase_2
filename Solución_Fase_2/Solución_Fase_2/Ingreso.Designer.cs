namespace Solución_Fase_2
{
    partial class Ingreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ingreso));
            this.lblautor = new System.Windows.Forms.Label();
            this.lbldias = new System.Windows.Forms.Label();
            this.lblidentificacion = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtmas = new System.Windows.Forms.RadioButton();
            this.rbtfem = new System.Windows.Forms.RadioButton();
            this.cmbhabitacion = new System.Windows.Forms.ComboBox();
            this.txtnombreu = new System.Windows.Forms.TextBox();
            this.txtident = new System.Windows.Forms.TextBox();
            this.txthab = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lblcosto = new System.Windows.Forms.Label();
            this.txtcosto = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblautor
            // 
            this.lblautor.AutoSize = true;
            this.lblautor.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblautor.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblautor.Location = new System.Drawing.Point(162, 198);
            this.lblautor.Name = "lblautor";
            this.lblautor.Size = new System.Drawing.Size(152, 18);
            this.lblautor.TabIndex = 1;
            this.lblautor.Text = "Tipo de Habitación";
            // 
            // lbldias
            // 
            this.lbldias.AutoSize = true;
            this.lbldias.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbldias.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldias.Location = new System.Drawing.Point(161, 248);
            this.lbldias.Name = "lbldias";
            this.lbldias.Size = new System.Drawing.Size(162, 19);
            this.lbldias.TabIndex = 2;
            this.lbldias.Text = "Dias de Hospedaje";
            // 
            // lblidentificacion
            // 
            this.lblidentificacion.AutoSize = true;
            this.lblidentificacion.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblidentificacion.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidentificacion.Location = new System.Drawing.Point(162, 153);
            this.lblidentificacion.Name = "lblidentificacion";
            this.lblidentificacion.Size = new System.Drawing.Size(200, 18);
            this.lblidentificacion.TabIndex = 3;
            this.lblidentificacion.Text = "Numero de Identificacíon";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblnombre.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(162, 104);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(128, 18);
            this.lblnombre.TabIndex = 4;
            this.lblnombre.Text = "Nombre Completo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtmas);
            this.groupBox1.Controls.Add(this.rbtfem);
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(165, 374);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 61);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "&Genero";
            // 
            // rbtmas
            // 
            this.rbtmas.AutoSize = true;
            this.rbtmas.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtmas.Location = new System.Drawing.Point(127, 23);
            this.rbtmas.Name = "rbtmas";
            this.rbtmas.Size = new System.Drawing.Size(88, 19);
            this.rbtmas.TabIndex = 1;
            this.rbtmas.TabStop = true;
            this.rbtmas.Text = "Masculino";
            this.rbtmas.UseVisualStyleBackColor = true;
            // 
            // rbtfem
            // 
            this.rbtfem.AutoSize = true;
            this.rbtfem.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtfem.Location = new System.Drawing.Point(7, 23);
            this.rbtfem.Name = "rbtfem";
            this.rbtfem.Size = new System.Drawing.Size(81, 19);
            this.rbtfem.TabIndex = 0;
            this.rbtfem.TabStop = true;
            this.rbtfem.Text = "Femenino";
            this.rbtfem.UseVisualStyleBackColor = true;
            // 
            // cmbhabitacion
            // 
            this.cmbhabitacion.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmbhabitacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbhabitacion.FormattingEnabled = true;
            this.cmbhabitacion.Items.AddRange(new object[] {
            "Hab.Sencilla",
            "Hab.Doble",
            "Hab.Especial"});
            this.cmbhabitacion.Location = new System.Drawing.Point(439, 193);
            this.cmbhabitacion.Name = "cmbhabitacion";
            this.cmbhabitacion.Size = new System.Drawing.Size(152, 23);
            this.cmbhabitacion.TabIndex = 6;
            this.cmbhabitacion.SelectedIndexChanged += new System.EventHandler(this.cmbhabitacion_SelectedIndexChanged);
            // 
            // txtnombreu
            // 
            this.txtnombreu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtnombreu.Location = new System.Drawing.Point(439, 99);
            this.txtnombreu.Name = "txtnombreu";
            this.txtnombreu.Size = new System.Drawing.Size(179, 23);
            this.txtnombreu.TabIndex = 7;
            // 
            // txtident
            // 
            this.txtident.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtident.Location = new System.Drawing.Point(439, 148);
            this.txtident.Name = "txtident";
            this.txtident.Size = new System.Drawing.Size(179, 23);
            this.txtident.TabIndex = 8;
            // 
            // txthab
            // 
            this.txthab.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txthab.Location = new System.Drawing.Point(439, 244);
            this.txthab.Name = "txthab";
            this.txthab.Size = new System.Drawing.Size(152, 23);
            this.txthab.TabIndex = 9;
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.Location = new System.Drawing.Point(809, 325);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 10;
            this.btnguardar.Text = "&Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.Location = new System.Drawing.Point(809, 423);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 11;
            this.btnsalir.Text = "&Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btncalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncalcular.Location = new System.Drawing.Point(809, 374);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 12;
            this.btncalcular.Text = "&Calcular";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lblcosto
            // 
            this.lblcosto.AutoSize = true;
            this.lblcosto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblcosto.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcosto.Location = new System.Drawing.Point(161, 313);
            this.lblcosto.Name = "lblcosto";
            this.lblcosto.Size = new System.Drawing.Size(180, 19);
            this.lblcosto.TabIndex = 13;
            this.lblcosto.Text = "Costo de Habitacíon";
            // 
            // txtcosto
            // 
            this.txtcosto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtcosto.Enabled = false;
            this.txtcosto.Location = new System.Drawing.Point(439, 309);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.Size = new System.Drawing.Size(152, 23);
            this.txtcosto.TabIndex = 14;
            // 
            // Ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.txtcosto);
            this.Controls.Add(this.lblcosto);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txthab);
            this.Controls.Add(this.txtident);
            this.Controls.Add(this.txtnombreu);
            this.Controls.Add(this.cmbhabitacion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblidentificacion);
            this.Controls.Add(this.lbldias);
            this.Controls.Add(this.lblautor);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ingreso";
            this.Text = "Ingreso";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblautor;
        private System.Windows.Forms.Label lbldias;
        private System.Windows.Forms.Label lblidentificacion;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtmas;
        private System.Windows.Forms.RadioButton rbtfem;
        private System.Windows.Forms.ComboBox cmbhabitacion;
        private System.Windows.Forms.TextBox txtnombreu;
        private System.Windows.Forms.TextBox txtident;
        private System.Windows.Forms.TextBox txthab;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lblcosto;
        private System.Windows.Forms.TextBox txtcosto;
    }
}