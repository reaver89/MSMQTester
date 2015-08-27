using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Windows.Forms;

namespace MSMQTester
{
    public partial class Form1 : Form
    {
        private const string QueueFormat = @"ReaverPC\Private$\{0}";
        private const string MachineName = "ReaverPC";        
        private string QueuePath { get; set; }

        public MessageQueue CurrentMessageQueue
        {
            get
            {
                if (!string.IsNullOrEmpty(QueuePath))
                {
                    return MessageQueue.Exists(QueuePath) ? new MessageQueue(QueuePath) : MessageQueue.Create(QueuePath);
                }
                return null;
            }
        }

    

        public IList<MessageQueue> PrivateMessageQueues { get; set; }

        public Form1()
        {
            InitializeComponent();            
            PrivateMessageQueues = MessageQueue.GetPrivateQueuesByMachine(MachineName).ToList();
            tbMessageText.Text = "SimpleMessage";
            cbQueues.DataSource = PrivateMessageQueues.Select(x => $"{x.MachineName}\\{x.QueueName}").ToList();
            QueuePath = cbQueues.SelectedValue.ToString();
            UpdateMessageList();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var message = new System.Messaging.Message();
            message.Body = tbMessageText.Text;
            message.Label = string.Format("Message {0} ",Guid.NewGuid());
            CurrentMessageQueue.Send(message);
            UpdateMessageList();
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            var receivedMessage = CurrentMessageQueue.Receive();
            if (receivedMessage != null)
            {
                receivedMessage.Formatter = new XmlMessageFormatter(new String[] {"System.String,mscorlib"});
                MessageBox.Show(receivedMessage.Body.ToString());
                UpdateMessageList();
            }
        }

        private void btnSelectQueue_Click(object sender, EventArgs e)
        {
            QueuePath = string.Format(QueueFormat, tbQueueName.Text.Trim());
            UpdateMessageList();
        }


        private void cbQueues_SelectedIndexChanged(object sender, EventArgs e)
        {
            QueuePath = cbQueues.SelectedValue.ToString();
            UpdateMessageList();
        }

        public void UpdateMessageList()
        {
            tbMessageList.Clear();

            foreach (var message in CurrentMessageQueue.GetAllMessages())
            {
                message.Formatter =  new XmlMessageFormatter(new String[] { "System.String,mscorlib" });                

                tbMessageList.AppendText(message.Body.ToString()+Environment.NewLine);
            }
        }
    }
}
