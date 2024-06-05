namespace Skal_APP
{
    partial class Medico
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
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Pendientes = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cerrarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "Doctor";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.monthCalendar1.Location = new System.Drawing.Point(48, 229);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Favor marcar horario disponible";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(197, 477);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 55);
            this.label4.TabIndex = 4;
            this.label4.Text = "🎥";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(179, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Entrar a llamada";
            // 
            // Pendientes
            // 
            this.Pendientes.AutoSize = true;
            this.Pendientes.BackColor = System.Drawing.Color.Yellow;
            this.Pendientes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pendientes.Location = new System.Drawing.Point(203, 477);
            this.Pendientes.Name = "Pendientes";
            this.Pendientes.Size = new System.Drawing.Size(17, 19);
            this.Pendientes.TabIndex = 6;
            this.Pendientes.Text = "1";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.checkedListBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Neumonia - Andrea",
            "Gripa - Juanita",
            "Rinitis - Andres",
            "Contusion - Ares",
            "PostOp - Demeter",
            "Neumonia - Juanita"});
            this.checkedListBox1.Location = new System.Drawing.Point(29, 454);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(135, 116);
            this.checkedListBox1.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Pendientes";
            // 
            // cerrarSesion
            // 
            this.cerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarSesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cerrarSesion.Location = new System.Drawing.Point(272, 12);
            this.cerrarSesion.Name = "cerrarSesion";
            this.cerrarSesion.Size = new System.Drawing.Size(35, 23);
            this.cerrarSesion.TabIndex = 9;
            this.cerrarSesion.Text = "✖️";
            this.cerrarSesion.UseVisualStyleBackColor = false;
            this.cerrarSesion.Click += new System.EventHandler(this.cerrarSesion_Click);
            // 
            // Medico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Skal_APP.Properties.Resources.Fondo_Skal2;
            this.ClientSize = new System.Drawing.Size(319, 598);
            this.Controls.Add(this.cerrarSesion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.Pendientes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Medico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medico";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Pendientes;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cerrarSesion;
    }
}