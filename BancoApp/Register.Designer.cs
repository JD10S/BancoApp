namespace BancoApp
{
    partial class Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtLastname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NºCuenta = new System.Windows.Forms.TextBox();
            this.ComboSaldo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese sus datos";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(84, 66);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 20);
            this.TxtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido";
            // 
            // TxtLastname
            // 
            this.TxtLastname.Location = new System.Drawing.Point(84, 101);
            this.TxtLastname.Name = "TxtLastname";
            this.TxtLastname.Size = new System.Drawing.Size(100, 20);
            this.TxtLastname.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nº Cuenta";
            // 
            // NºCuenta
            // 
            this.NºCuenta.Location = new System.Drawing.Point(286, 101);
            this.NºCuenta.Name = "NºCuenta";
            this.NºCuenta.Size = new System.Drawing.Size(100, 20);
            this.NºCuenta.TabIndex = 5;
            // 
            // ComboSaldo
            // 
            this.ComboSaldo.FormattingEnabled = true;
            this.ComboSaldo.Items.AddRange(new object[] {
            "10.000",
            "20.000",
            "30.000",
            "40.000",
            "50.000"});
            this.ComboSaldo.Location = new System.Drawing.Point(286, 65);
            this.ComboSaldo.Name = "ComboSaldo";
            this.ComboSaldo.Size = new System.Drawing.Size(121, 21);
            this.ComboSaldo.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Saldo Apertura";
            // 
            // BtnRegister
            // 
            this.BtnRegister.Location = new System.Drawing.Point(193, 134);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(89, 30);
            this.BtnRegister.TabIndex = 9;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 180);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ComboSaldo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NºCuenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtLastname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtLastname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NºCuenta;
        private System.Windows.Forms.ComboBox ComboSaldo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnRegister;
    }
}