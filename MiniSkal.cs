using Skal_APP;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ChatBotApp
{
    public partial class MiniSkal : Form
    {
        private string currentStep = "greeting";  // Variable para controlar el paso actual de la conversación
        private string symptoms = "";
        public string availableDays = "";

        public MiniSkal()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.pnlChatDisplay = new System.Windows.Forms.Panel();
            this.txtUserInput = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.vScrollBar = new System.Windows.Forms.VScrollBar();
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
            this.btnSend.Size = new System.Drawing.Size(45, 25);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "➤";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // vScrollBar
            // 
            this.vScrollBar.Location = new System.Drawing.Point(355, 12);
            this.vScrollBar.Name = "vScrollBar";
            this.vScrollBar.Size = new System.Drawing.Size(17, 200);
            this.vScrollBar.TabIndex = 3;
            this.vScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar_Scroll);
            // 
            // ChatForm
            // 
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.vScrollBar);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtUserInput);
            this.Controls.Add(this.pnlChatDisplay);
            this.Name = "MiniSKal";
            this.Text = "MiniSKal";
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel pnlChatDisplay;
        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.VScrollBar vScrollBar;

        private void ChatForm_Load(object sender, EventArgs e)
        {
            AddMessage("Hola, MiniSkal, tu asistente medico personal.Cuentame, ¿Cuales son tus sintomas?", false);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string userMessage = txtUserInput.Text;
            if (!string.IsNullOrWhiteSpace(userMessage))
            {
                AddMessage("You: " + userMessage, true);
                txtUserInput.Clear();
                HandleConversation(userMessage);
            }
        }

        public void HandleConversation(string userMessage)
        {
            switch (currentStep)
            {
                case "greeting":
                    symptoms = userMessage;
                    AddMessage("No parece algo muy grave, pero mejor prevenir. ¿Que dias tienes disponibles para una consulta?.", false);
                    currentStep = "askForAvailability";
                    break;
                case "askForAvailability":
                    availableDays = userMessage;
                    string[] days = availableDays.Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
                    if (days.Length > 0)
                    {
                        AddMessage($"Cita agendada con el doctor Victor el día {days[0]} de manera presencial en la clínica.", false);
                        AddMessage("Envia 'Salir' para volver a la interfaz", false);
                        currentStep = "appointmentScheduled";
                    }
                    else
                    {
                        AddMessage("Por favor, ingresa al menos un día disponible.", false);
                    }
                    break;

                case "appointmentScheduled":
                    AddMessage("Tu cita ya ha sido agendada. Si necesitas algo más, no dudes en preguntar.", false);


                    Cliente interfaz_cliente = new Cliente();

                    interfaz_cliente.Show();
                    this.Hide();

                    break;
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

        private void vScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            pnlChatDisplay.VerticalScroll.Value = vScrollBar.Value;
            pnlChatDisplay.PerformLayout();
        }
    }
}
