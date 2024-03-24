namespace BancoApp
{
    partial class Loguin
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
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LinkRegister = new System.Windows.Forms.LinkLabel();
            this.NextBoton = new System.Windows.Forms.LinkLabel();
            this.btnLoguin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(129, 61);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 20);
            this.TxtName.TabIndex = 0;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(129, 101);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(100, 20);
            this.TxtPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "password";
            // 
            // LinkRegister
            // 
            this.LinkRegister.AutoSize = true;
            this.LinkRegister.Location = new System.Drawing.Point(126, 150);
            this.LinkRegister.Name = "LinkRegister";
            this.LinkRegister.Size = new System.Drawing.Size(46, 13);
            this.LinkRegister.TabIndex = 4;
            this.LinkRegister.TabStop = true;
            this.LinkRegister.Text = "Register";
            this.LinkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkRegister_LinkClicked);
            // 
            // NextBoton
            // 
            this.NextBoton.AutoSize = true;
            this.NextBoton.Location = new System.Drawing.Point(178, 150);
            this.NextBoton.Name = "NextBoton";
            this.NextBoton.Size = new System.Drawing.Size(68, 13);
            this.NextBoton.TabIndex = 5;
            this.NextBoton.TabStop = true;
            this.NextBoton.Text = "Otra Funcion";
            this.NextBoton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NextBoton_LinkClicked);
            // 
            // btnLoguin
            // 
            this.btnLoguin.Location = new System.Drawing.Point(144, 126);
            this.btnLoguin.Name = "btnLoguin";
            this.btnLoguin.Size = new System.Drawing.Size(75, 23);
            this.btnLoguin.TabIndex = 6;
            this.btnLoguin.Text = "Loguin";
            this.btnLoguin.UseVisualStyleBackColor = true;
            this.btnLoguin.Click += new System.EventHandler(this.btnLoguin_Click);
            // 
            // Loguin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 188);
            this.Controls.Add(this.btnLoguin);
            this.Controls.Add(this.NextBoton);
            this.Controls.Add(this.LinkRegister);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtName);
            this.Name = "Loguin";
            this.Text = "loguin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel LinkRegister;
        private System.Windows.Forms.LinkLabel NextBoton;
        private System.Windows.Forms.Button btnLoguin;
    }
}

