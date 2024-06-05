namespace Skal_APP
{
    partial class Login
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
            this.Titulo_SKAL = new System.Windows.Forms.LinkLabel();
            this.User = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Ingresar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Titulo_SKAL
            // 
            this.Titulo_SKAL.AutoSize = true;
            this.Titulo_SKAL.BackColor = System.Drawing.Color.Transparent;
            this.Titulo_SKAL.Font = new System.Drawing.Font("Modern No. 20", 47.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_SKAL.LinkColor = System.Drawing.Color.White;
            this.Titulo_SKAL.Location = new System.Drawing.Point(67, 124);
            this.Titulo_SKAL.Name = "Titulo_SKAL";
            this.Titulo_SKAL.Size = new System.Drawing.Size(196, 65);
            this.Titulo_SKAL.TabIndex = 2;
            this.Titulo_SKAL.TabStop = true;
            this.Titulo_SKAL.Text = "SKAL";
            // 
            // User
            // 
            this.User.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.Location = new System.Drawing.Point(68, 244);
            this.User.Multiline = true;
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(183, 47);
            this.User.TabIndex = 3;
            this.User.Text = "Usuario";
            this.User.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(68, 344);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(183, 47);
            this.Password.TabIndex = 4;
            this.Password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Ingresar
            // 
            this.Ingresar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Ingresar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingresar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ingresar.Location = new System.Drawing.Point(180, 431);
            this.Ingresar.Name = "Ingresar";
            this.Ingresar.Size = new System.Drawing.Size(71, 38);
            this.Ingresar.TabIndex = 5;
            this.Ingresar.Text = "Ingresar";
            this.Ingresar.UseVisualStyleBackColor = false;
            this.Ingresar.Click += new System.EventHandler(this.Ingresar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCancelar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Location = new System.Drawing.Point(68, 431);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(71, 38);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Skal_APP.Properties.Resources.Fondo_Skal_JPG;
            this.ClientSize = new System.Drawing.Size(319, 598);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.Ingresar);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.User);
            this.Controls.Add(this.Titulo_SKAL);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel Titulo_SKAL;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button Ingresar;
        private System.Windows.Forms.Button btnCancelar;
    }
}