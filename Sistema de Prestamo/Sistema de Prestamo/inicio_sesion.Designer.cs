namespace Sistema_de_Prestamo
{
    partial class inicio_sesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicio_sesion));
            this.TXBSusuario = new System.Windows.Forms.TextBox();
            this.TXTBSpass = new System.Windows.Forms.TextBox();
            this.BTNsesion = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXBSusuario
            // 
            this.TXBSusuario.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXBSusuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.TXBSusuario.Location = new System.Drawing.Point(141, 90);
            this.TXBSusuario.Multiline = true;
            this.TXBSusuario.Name = "TXBSusuario";
            this.TXBSusuario.Size = new System.Drawing.Size(195, 27);
            this.TXBSusuario.TabIndex = 0;
            this.TXBSusuario.Text = "usuario";
            // 
            // TXTBSpass
            // 
            this.TXTBSpass.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBSpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.TXTBSpass.Location = new System.Drawing.Point(141, 136);
            this.TXTBSpass.Multiline = true;
            this.TXTBSpass.Name = "TXTBSpass";
            this.TXTBSpass.PasswordChar = '*';
            this.TXTBSpass.Size = new System.Drawing.Size(195, 24);
            this.TXTBSpass.TabIndex = 1;
            this.TXTBSpass.Text = "contraseña";
            // 
            // BTNsesion
            // 
            this.BTNsesion.Image = ((System.Drawing.Image)(resources.GetObject("BTNsesion.Image")));
            this.BTNsesion.Location = new System.Drawing.Point(141, 177);
            this.BTNsesion.Name = "BTNsesion";
            this.BTNsesion.Size = new System.Drawing.Size(195, 46);
            this.BTNsesion.TabIndex = 2;
            this.BTNsesion.UseVisualStyleBackColor = true;
            this.BTNsesion.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.linkLabel1.Location = new System.Drawing.Point(218, 239);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(35, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Cerrar";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(154)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.label1.Location = new System.Drawing.Point(165, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "BIENVENIDO";
            // 
            // inicio_sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 262);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.BTNsesion);
            this.Controls.Add(this.TXTBSpass);
            this.Controls.Add(this.TXBSusuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "inicio_sesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXBSusuario;
        private System.Windows.Forms.TextBox TXTBSpass;
        private System.Windows.Forms.Button BTNsesion;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
    }
}

