using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChatBotApp
{
    public partial class miniskal : Form
    {
        public miniskal()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.pnlChatDisplay = new System.Windows.Forms.Panel();
            this.txtUserInput = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlChatDisplay
            // 
            this.pnlChatDisplay.AutoScroll = true;
            this.pnlChatDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChatDisplay.Location = new System.Drawing.Point(12, 12);
            this.pnlChatDisplay.Name = "pnlChatDisplay";
            this.pnlChatDisplay.Size = new System.Drawing.Size(360, 200);
            this.pnlChatDisplay.TabIndex = 0;
            // 
            // txtUserInput
            // 
            this.txtUserInput.Location = new System.Drawing.Point(12, 230);
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(270, 20);
            this.txtUserInput.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(297, 228);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Miniskal
            // 
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtUserInput);
            this.Controls.Add(this.pnlChatDisplay);
            this.Name = "Miniskal";
            this.Text = "Chat Bot";
            this.Load += new System.EventHandler(this.Miniskal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel pnlChatDisplay;
        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.Button btnSend;

        private void btnSend_Click(object sender, EventArgs e)
        {
            string userMessage = txtUserInput.Text;
            if (!string.IsNullOrWhiteSpace(userMessage))
            {
                AddMessage("You: " + userMessage, true);
                txtUserInput.Clear();
                HandleUserInput(userMessage);
            }
        }

        private void AddMessage(string message, bool isUser)
        {
            Label lblMessage = new Label();
            lblMessage.AutoSize = true;
            lblMessage.MaximumSize = new Size(pnlChatDisplay.Width - 20, 0);
            lblMessage.Text = message;
            lblMessage.BackColor = isUser ? Color.LightBlue : Color.LightGreen;
            lblMessage.Padding = new Padding(5);
            lblMessage.Margin = new Padding(3);

            pnlChatDisplay.Controls.Add(lblMessage);
            lblMessage.Location = new Point(5, pnlChatDisplay.Controls.Count > 1 ? pnlChatDisplay.Controls[pnlChatDisplay.Controls.Count - 2].Bottom + 10 : 10);

            pnlChatDisplay.VerticalScroll.Value = pnlChatDisplay.VerticalScroll.Maximum;
            pnlChatDisplay.PerformLayout();
        }

        private void HandleUserInput(string userInput)
        {
            string botResponse = string.Empty;

            // Lógica del flujo de conversación
            if (userInput.ToLower().Contains("hola"))
            {
                botResponse = "Hola soy tu chat bot. Ingresa tus síntomas.";
            }
            else if (userInput.ToLower().Contains("asfixia") || userInput.ToLower().Contains("gripa") || userInput.ToLower().Contains("dolor en pecho"))
            {
                botResponse = "¿Qué días de este mes tienes disponibles?";
            }
            else if (userInput.Contains("12") || userInput.Contains("13") || userInput.Contains("14") || userInput.Contains("15") || userInput.Contains("16"))
            {
                botResponse = "Cita agendada con el doctor el día " + userInput + " de manera presencial en el consultorio.";
            }
            else
            {
                botResponse = "No entendí tu mensaje. Por favor ingresa tus síntomas o disponibilidad.";
            }

            AddMessage("Bot: " + botResponse, false);
        }

        private void Miniskal_Load(object sender, EventArgs e)
        {
            AddMessage("Bot: Hola soy tu chat bot. Ingresa tus síntomas.", false);
        }
    }
}
