namespace WindowsFormsApp2
{
    partial class Form1
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
            this.gpBoxId = new System.Windows.Forms.GroupBox();
            this.btntxtBoxApll = new System.Windows.Forms.TextBox();
            this.lblApll = new System.Windows.Forms.Label();
            this.btntxtBoxNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.btntxtBoxId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.gpBoxContacto = new System.Windows.Forms.GroupBox();
            this.btntxtBoxTel = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.btntxtBoxCorreo = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gpBoxId.SuspendLayout();
            this.gpBoxContacto.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpBoxId
            // 
            this.gpBoxId.Controls.Add(this.btntxtBoxApll);
            this.gpBoxId.Controls.Add(this.lblApll);
            this.gpBoxId.Controls.Add(this.btntxtBoxNom);
            this.gpBoxId.Controls.Add(this.lblNom);
            this.gpBoxId.Controls.Add(this.btntxtBoxId);
            this.gpBoxId.Controls.Add(this.lblId);
            this.gpBoxId.Location = new System.Drawing.Point(191, 33);
            this.gpBoxId.Name = "gpBoxId";
            this.gpBoxId.Size = new System.Drawing.Size(411, 163);
            this.gpBoxId.TabIndex = 0;
            this.gpBoxId.TabStop = false;
            this.gpBoxId.Text = "IdPersonal.";
            this.gpBoxId.Enter += new System.EventHandler(this.gpBoxId_Enter);
            // 
            // btntxtBoxApll
            // 
            this.btntxtBoxApll.Location = new System.Drawing.Point(100, 110);
            this.btntxtBoxApll.Name = "btntxtBoxApll";
            this.btntxtBoxApll.Size = new System.Drawing.Size(215, 20);
            this.btntxtBoxApll.TabIndex = 5;
            this.btntxtBoxApll.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btntxtBoxApll_KeyPress);
            // 
            // lblApll
            // 
            this.lblApll.AutoSize = true;
            this.lblApll.Location = new System.Drawing.Point(27, 118);
            this.lblApll.Name = "lblApll";
            this.lblApll.Size = new System.Drawing.Size(44, 13);
            this.lblApll.TabIndex = 4;
            this.lblApll.Text = "Apellido";
            // 
            // btntxtBoxNom
            // 
            this.btntxtBoxNom.Location = new System.Drawing.Point(100, 64);
            this.btntxtBoxNom.Name = "btntxtBoxNom";
            this.btntxtBoxNom.Size = new System.Drawing.Size(215, 20);
            this.btntxtBoxNom.TabIndex = 3;
            this.btntxtBoxNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btntxtBoxNom_KeyPress);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(27, 72);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(44, 13);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nombre";
            // 
            // btntxtBoxId
            // 
            this.btntxtBoxId.Location = new System.Drawing.Point(100, 31);
            this.btntxtBoxId.Name = "btntxtBoxId";
            this.btntxtBoxId.Size = new System.Drawing.Size(215, 20);
            this.btntxtBoxId.TabIndex = 1;
            this.btntxtBoxId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btntxtBoxId_KeyPress);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(27, 38);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id.";
            // 
            // gpBoxContacto
            // 
            this.gpBoxContacto.Controls.Add(this.btntxtBoxCorreo);
            this.gpBoxContacto.Controls.Add(this.lblCorreo);
            this.gpBoxContacto.Controls.Add(this.btntxtBoxTel);
            this.gpBoxContacto.Controls.Add(this.lblTel);
            this.gpBoxContacto.Location = new System.Drawing.Point(191, 228);
            this.gpBoxContacto.Name = "gpBoxContacto";
            this.gpBoxContacto.Size = new System.Drawing.Size(411, 119);
            this.gpBoxContacto.TabIndex = 1;
            this.gpBoxContacto.TabStop = false;
            this.gpBoxContacto.Text = "Contacto.";
            this.gpBoxContacto.Enter += new System.EventHandler(this.gpBoxContacto_Enter);
            // 
            // btntxtBoxTel
            // 
            this.btntxtBoxTel.Location = new System.Drawing.Point(100, 33);
            this.btntxtBoxTel.Name = "btntxtBoxTel";
            this.btntxtBoxTel.Size = new System.Drawing.Size(215, 20);
            this.btntxtBoxTel.TabIndex = 1;
            this.btntxtBoxTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btntxtBoxTel_KeyPress);
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(27, 33);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(52, 13);
            this.lblTel.TabIndex = 0;
            this.lblTel.Text = "Telefono.";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(30, 75);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(41, 13);
            this.lblCorreo.TabIndex = 2;
            this.lblCorreo.Text = "Correo.";
            // 
            // btntxtBoxCorreo
            // 
            this.btntxtBoxCorreo.Location = new System.Drawing.Point(100, 67);
            this.btntxtBoxCorreo.Name = "btntxtBoxCorreo";
            this.btntxtBoxCorreo.Size = new System.Drawing.Size(215, 20);
            this.btntxtBoxCorreo.TabIndex = 3;
            this.btntxtBoxCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btntxtBoxCorreo_KeyPress);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(191, 392);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(122, 32);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar.";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(466, 392);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(136, 31);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar.";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gpBoxContacto);
            this.Controls.Add(this.gpBoxId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpBoxId.ResumeLayout(false);
            this.gpBoxId.PerformLayout();
            this.gpBoxContacto.ResumeLayout(false);
            this.gpBoxContacto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpBoxId;
        private System.Windows.Forms.TextBox btntxtBoxId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox btntxtBoxNom;
        private System.Windows.Forms.Label lblApll;
        private System.Windows.Forms.TextBox btntxtBoxApll;
        private System.Windows.Forms.GroupBox gpBoxContacto;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox btntxtBoxTel;
        private System.Windows.Forms.TextBox btntxtBoxCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}

