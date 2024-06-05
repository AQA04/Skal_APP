namespace Skal_APP
{
    partial class Bienvenido
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Titulo_SKAL
            // 
            this.Titulo_SKAL.AutoSize = true;
            this.Titulo_SKAL.BackColor = System.Drawing.Color.Transparent;
            this.Titulo_SKAL.Font = new System.Drawing.Font("Modern No. 20", 47.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_SKAL.LinkColor = System.Drawing.Color.White;
            this.Titulo_SKAL.Location = new System.Drawing.Point(70, 201);
            this.Titulo_SKAL.Name = "Titulo_SKAL";
            this.Titulo_SKAL.Size = new System.Drawing.Size(196, 65);
            this.Titulo_SKAL.TabIndex = 1;
            this.Titulo_SKAL.TabStop = true;
            this.Titulo_SKAL.Text = "SKAL";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogin.Location = new System.Drawing.Point(102, 348);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(125, 46);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRegistrar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistrar.Location = new System.Drawing.Point(102, 420);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(125, 46);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "No Tienes cuenta?";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // Bienvenido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::Skal_APP.Properties.Resources.Fondo_Skal_JPG;
            this.ClientSize = new System.Drawing.Size(319, 598);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.Titulo_SKAL);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "Bienvenido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido";
            this.Load += new System.EventHandler(this.Bienvenido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel Titulo_SKAL;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegistrar;
    }
}

