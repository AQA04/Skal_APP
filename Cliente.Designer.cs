namespace Skal_APP
{
    partial class Cliente
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
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Pendientes = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChatBot = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cerrarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(71, 81);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(174, 55);
            this.lblNombreUsuario.TabIndex = 3;
            this.lblNombreUsuario.Text = "Usuario";
            this.lblNombreUsuario.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenido";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Pendientes
            // 
            this.Pendientes.AutoSize = true;
            this.Pendientes.BackColor = System.Drawing.Color.Yellow;
            this.Pendientes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pendientes.Location = new System.Drawing.Point(198, 241);
            this.Pendientes.Name = "Pendientes";
            this.Pendientes.Size = new System.Drawing.Size(17, 19);
            this.Pendientes.TabIndex = 9;
            this.Pendientes.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(185, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Entrar a llamada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(187, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 73);
            this.label4.TabIndex = 7;
            this.label4.Text = "🎥";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Entrar a MiniSKAL";
            // 
            // btnChatBot
            // 
            this.btnChatBot.AutoSize = true;
            this.btnChatBot.BackColor = System.Drawing.Color.Transparent;
            this.btnChatBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChatBot.ForeColor = System.Drawing.Color.Black;
            this.btnChatBot.Location = new System.Drawing.Point(42, 232);
            this.btnChatBot.Name = "btnChatBot";
            this.btnChatBot.Size = new System.Drawing.Size(103, 73);
            this.btnChatBot.TabIndex = 10;
            this.btnChatBot.Text = "👾";
            this.btnChatBot.Click += new System.EventHandler(this.label6_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.monthCalendar1.Location = new System.Drawing.Point(42, 356);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 13;
            this.monthCalendar1.TabStop = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Proximas consultas";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Completadas",
            "Pendientes",
            "Proximas"});
            this.comboBox1.Location = new System.Drawing.Point(42, 548);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.Text = "Filtrar";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox1.Location = new System.Drawing.Point(42, 525);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(155, 17);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Doctor: Victor Frankenstein";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // cerrarSesion
            // 
            this.cerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarSesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cerrarSesion.Location = new System.Drawing.Point(272, 10);
            this.cerrarSesion.Name = "cerrarSesion";
            this.cerrarSesion.Size = new System.Drawing.Size(35, 23);
            this.cerrarSesion.TabIndex = 17;
            this.cerrarSesion.Text = "✖️";
            this.cerrarSesion.UseVisualStyleBackColor = false;
            this.cerrarSesion.Click += new System.EventHandler(this.cerrarSesion_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Skal_APP.Properties.Resources.Fondo_Skal2;
            this.ClientSize = new System.Drawing.Size(319, 598);
            this.Controls.Add(this.cerrarSesion);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnChatBot);
            this.Controls.Add(this.Pendientes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.label1);
            this.Name = "Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Pendientes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label btnChatBot;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button cerrarSesion;
    }
}