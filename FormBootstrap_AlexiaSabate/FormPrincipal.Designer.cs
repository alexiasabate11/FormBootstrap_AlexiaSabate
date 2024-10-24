namespace FormBootstrap_AlexiaSabate
{
    partial class FormPrincipal
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
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblCriticity = new System.Windows.Forms.Label();
            this.cmbCriticity = new System.Windows.Forms.ComboBox();
            this.lblEnviorament = new System.Windows.Forms.Label();
            this.chckProd = new System.Windows.Forms.CheckBox();
            this.chckPreprod = new System.Windows.Forms.CheckBox();
            this.chckDemo = new System.Windows.Forms.CheckBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblStrDate = new System.Windows.Forms.Label();
            this.DateInitial = new System.Windows.Forms.DateTimePicker();
            this.lblDuration = new System.Windows.Forms.Label();
            this.numDuration = new System.Windows.Forms.NumericUpDown();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbEstate = new System.Windows.Forms.ComboBox();
            this.lblPercComplet = new System.Windows.Forms.Label();
            this.chckEmail = new System.Windows.Forms.CheckBox();
            this.butEnviar = new System.Windows.Forms.Button();
            this.butCancelar = new System.Windows.Forms.Button();
            this.cmbPercent = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloForm
            // 
            this.lblTituloForm.AutoSize = true;
            this.lblTituloForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloForm.Location = new System.Drawing.Point(13, 13);
            this.lblTituloForm.Name = "lblTituloForm";
            this.lblTituloForm.Size = new System.Drawing.Size(143, 20);
            this.lblTituloForm.TabIndex = 0;
            this.lblTituloForm.Text = "Crear nueva tarea";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(17, 55);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(46, 16);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Titulo";
            // 
            // txtTitle
            // 
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Location = new System.Drawing.Point(20, 75);
            this.txtTitle.MaximumSize = new System.Drawing.Size(225, 24);
            this.txtTitle.MinimumSize = new System.Drawing.Size(225, 24);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(225, 24);
            this.txtTitle.TabIndex = 2;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(261, 55);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(77, 16);
            this.lblLocation.TabIndex = 3;
            this.lblLocation.Text = "Ubicación";
            // 
            // cmbLocation
            // 
            this.cmbLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Items.AddRange(new object[] {
            "Rubí",
            "Barcelona",
            "Terrassa",
            "Sabadell"});
            this.cmbLocation.Location = new System.Drawing.Point(261, 75);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(225, 24);
            this.cmbLocation.TabIndex = 4;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(17, 117);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(39, 16);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "Tipo";
            this.lblType.Click += new System.EventHandler(this.lblType_Click);
            // 
            // cmbType
            // 
            this.cmbType.AllowDrop = true;
            this.cmbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Incidencia",
            "Creación"});
            this.cmbType.Location = new System.Drawing.Point(20, 138);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(139, 24);
            this.cmbType.TabIndex = 6;
            // 
            // lblCriticity
            // 
            this.lblCriticity.AutoSize = true;
            this.lblCriticity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriticity.Location = new System.Drawing.Point(177, 116);
            this.lblCriticity.Name = "lblCriticity";
            this.lblCriticity.Size = new System.Drawing.Size(83, 16);
            this.lblCriticity.TabIndex = 7;
            this.lblCriticity.Text = "Necesidad";
            // 
            // cmbCriticity
            // 
            this.cmbCriticity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCriticity.FormattingEnabled = true;
            this.cmbCriticity.Items.AddRange(new object[] {
            "Menor",
            "Medio",
            "Máximo"});
            this.cmbCriticity.Location = new System.Drawing.Point(180, 137);
            this.cmbCriticity.Name = "cmbCriticity";
            this.cmbCriticity.Size = new System.Drawing.Size(139, 24);
            this.cmbCriticity.TabIndex = 8;
            // 
            // lblEnviorament
            // 
            this.lblEnviorament.AutoSize = true;
            this.lblEnviorament.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnviorament.Location = new System.Drawing.Point(339, 115);
            this.lblEnviorament.Name = "lblEnviorament";
            this.lblEnviorament.Size = new System.Drawing.Size(68, 16);
            this.lblEnviorament.TabIndex = 9;
            this.lblEnviorament.Text = "Entornos";
            // 
            // chckProd
            // 
            this.chckProd.AutoSize = true;
            this.chckProd.Location = new System.Drawing.Point(342, 141);
            this.chckProd.Name = "chckProd";
            this.chckProd.Size = new System.Drawing.Size(58, 20);
            this.chckProd.TabIndex = 10;
            this.chckProd.Text = "Prod";
            this.chckProd.UseVisualStyleBackColor = true;
            // 
            // chckPreprod
            // 
            this.chckPreprod.AutoSize = true;
            this.chckPreprod.Location = new System.Drawing.Point(342, 168);
            this.chckPreprod.Name = "chckPreprod";
            this.chckPreprod.Size = new System.Drawing.Size(78, 20);
            this.chckPreprod.TabIndex = 11;
            this.chckPreprod.Text = "Preprod";
            this.chckPreprod.UseVisualStyleBackColor = true;
            // 
            // chckDemo
            // 
            this.chckDemo.AutoSize = true;
            this.chckDemo.Location = new System.Drawing.Point(342, 195);
            this.chckDemo.Name = "chckDemo";
            this.chckDemo.Size = new System.Drawing.Size(66, 20);
            this.chckDemo.TabIndex = 12;
            this.chckDemo.Text = "Demo";
            this.chckDemo.UseVisualStyleBackColor = true;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(20, 235);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(90, 16);
            this.lblDesc.TabIndex = 13;
            this.lblDesc.Text = "Descripcion";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Location = new System.Drawing.Point(20, 259);
            this.txtDescription.MaximumSize = new System.Drawing.Size(466, 60);
            this.txtDescription.MinimumSize = new System.Drawing.Size(466, 60);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(466, 60);
            this.txtDescription.TabIndex = 14;
            // 
            // lblStrDate
            // 
            this.lblStrDate.AutoSize = true;
            this.lblStrDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrDate.Location = new System.Drawing.Point(21, 344);
            this.lblStrDate.Name = "lblStrDate";
            this.lblStrDate.Size = new System.Drawing.Size(95, 16);
            this.lblStrDate.TabIndex = 15;
            this.lblStrDate.Text = "Fecha inicial";
            // 
            // DateInitial
            // 
            this.DateInitial.Checked = false;
            this.DateInitial.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DateInitial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateInitial.Location = new System.Drawing.Point(20, 363);
            this.DateInitial.Name = "DateInitial";
            this.DateInitial.ShowCheckBox = true;
            this.DateInitial.Size = new System.Drawing.Size(225, 22);
            this.DateInitial.TabIndex = 16;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(262, 344);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(122, 16);
            this.lblDuration.TabIndex = 18;
            this.lblDuration.Text = "Duración (horas)";
            // 
            // numDuration
            // 
            this.numDuration.Location = new System.Drawing.Point(261, 362);
            this.numDuration.Name = "numDuration";
            this.numDuration.Size = new System.Drawing.Size(225, 22);
            this.numDuration.TabIndex = 19;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(24, 412);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 16);
            this.lblStatus.TabIndex = 20;
            this.lblStatus.Text = "Estado";
            // 
            // cmbEstate
            // 
            this.cmbEstate.FormattingEnabled = true;
            this.cmbEstate.Items.AddRange(new object[] {
            "Planeado",
            "En proceso",
            "Pausado"});
            this.cmbEstate.Location = new System.Drawing.Point(20, 432);
            this.cmbEstate.Name = "cmbEstate";
            this.cmbEstate.Size = new System.Drawing.Size(225, 24);
            this.cmbEstate.TabIndex = 21;
            // 
            // lblPercComplet
            // 
            this.lblPercComplet.AutoSize = true;
            this.lblPercComplet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercComplet.Location = new System.Drawing.Point(262, 412);
            this.lblPercComplet.Name = "lblPercComplet";
            this.lblPercComplet.Size = new System.Drawing.Size(168, 16);
            this.lblPercComplet.TabIndex = 22;
            this.lblPercComplet.Text = "Porcentaje completado";
            // 
            // chckEmail
            // 
            this.chckEmail.AutoSize = true;
            this.chckEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckEmail.Location = new System.Drawing.Point(20, 486);
            this.chckEmail.Name = "chckEmail";
            this.chckEmail.Size = new System.Drawing.Size(376, 20);
            this.chckEmail.TabIndex = 24;
            this.chckEmail.Text = "Marque aquí si desea enviar un correo electrónico";
            this.chckEmail.UseVisualStyleBackColor = true;
            this.chckEmail.CheckedChanged += new System.EventHandler(this.chckEmail_CheckedChanged);
            // 
            // butEnviar
            // 
            this.butEnviar.BackColor = System.Drawing.SystemColors.Highlight;
            this.butEnviar.Enabled = false;
            this.butEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEnviar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.butEnviar.Location = new System.Drawing.Point(414, 524);
            this.butEnviar.Name = "butEnviar";
            this.butEnviar.Size = new System.Drawing.Size(85, 30);
            this.butEnviar.TabIndex = 25;
            this.butEnviar.Text = "Enviar";
            this.butEnviar.UseVisualStyleBackColor = false;
            this.butEnviar.Click += new System.EventHandler(this.butEnviar_Click);
            // 
            // butCancelar
            // 
            this.butCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCancelar.Location = new System.Drawing.Point(308, 524);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(92, 30);
            this.butCancelar.TabIndex = 26;
            this.butCancelar.Text = "Cancelar";
            this.butCancelar.UseVisualStyleBackColor = true;
            this.butCancelar.Click += new System.EventHandler(this.butCancelar_Click);
            // 
            // cmbPercent
            // 
            this.cmbPercent.FormattingEnabled = true;
            this.cmbPercent.Items.AddRange(new object[] {
            "0%",
            "5%",
            "10%",
            "15%",
            "20%",
            "25%",
            "30%",
            "35%",
            "40%",
            "45%",
            "50%",
            "55%",
            "60%",
            "65%",
            "70%",
            "75%",
            "80%",
            "85%",
            "90%",
            "95%",
            "100%"});
            this.cmbPercent.Location = new System.Drawing.Point(261, 432);
            this.cmbPercent.Name = "cmbPercent";
            this.cmbPercent.Size = new System.Drawing.Size(225, 24);
            this.cmbPercent.TabIndex = 27;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(511, 566);
            this.Controls.Add(this.cmbPercent);
            this.Controls.Add(this.butCancelar);
            this.Controls.Add(this.butEnviar);
            this.Controls.Add(this.chckEmail);
            this.Controls.Add(this.lblPercComplet);
            this.Controls.Add(this.cmbEstate);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.numDuration);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.DateInitial);
            this.Controls.Add(this.lblStrDate);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.chckDemo);
            this.Controls.Add(this.chckPreprod);
            this.Controls.Add(this.chckProd);
            this.Controls.Add(this.lblEnviorament);
            this.Controls.Add(this.cmbCriticity);
            this.Controls.Add(this.lblCriticity);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cmbLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTituloForm);
            this.Name = "FormPrincipal";
            this.Text = "Form Bootstrap";
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloForm;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.ComboBox cmbLocation;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblCriticity;
        private System.Windows.Forms.ComboBox cmbCriticity;
        private System.Windows.Forms.Label lblEnviorament;
        private System.Windows.Forms.CheckBox chckProd;
        private System.Windows.Forms.CheckBox chckPreprod;
        private System.Windows.Forms.CheckBox chckDemo;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblStrDate;
        private System.Windows.Forms.DateTimePicker DateInitial;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.NumericUpDown numDuration;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbEstate;
        private System.Windows.Forms.Label lblPercComplet;
        private System.Windows.Forms.CheckBox chckEmail;
        private System.Windows.Forms.Button butEnviar;
        private System.Windows.Forms.Button butCancelar;
        private System.Windows.Forms.ComboBox cmbPercent;
    }
}

