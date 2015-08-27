namespace MSMQTester
{
    partial class Form1
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
            this.btnSend = new System.Windows.Forms.Button();
            this.btnReceive = new System.Windows.Forms.Button();
            this.tbMessageList = new System.Windows.Forms.TextBox();
            this.lblQueueTitle = new System.Windows.Forms.Label();
            this.tbQueueName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbQueues = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectQueue = new System.Windows.Forms.Button();
            this.tbMessageText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(12, 167);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(104, 24);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send Message";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(330, 227);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(104, 23);
            this.btnReceive.TabIndex = 1;
            this.btnReceive.Text = "Receive Message";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // tbMessageList
            // 
            this.tbMessageList.Location = new System.Drawing.Point(330, 92);
            this.tbMessageList.Multiline = true;
            this.tbMessageList.Name = "tbMessageList";
            this.tbMessageList.Size = new System.Drawing.Size(279, 129);
            this.tbMessageList.TabIndex = 2;
            // 
            // lblQueueTitle
            // 
            this.lblQueueTitle.AutoSize = true;
            this.lblQueueTitle.Location = new System.Drawing.Point(327, 63);
            this.lblQueueTitle.Name = "lblQueueTitle";
            this.lblQueueTitle.Size = new System.Drawing.Size(104, 13);
            this.lblQueueTitle.TabIndex = 3;
            this.lblQueueTitle.Text = "Messages in Queue:";
            // 
            // tbQueueName
            // 
            this.tbQueueName.Location = new System.Drawing.Point(330, 13);
            this.tbQueueName.Name = "tbQueueName";
            this.tbQueueName.Size = new System.Drawing.Size(121, 20);
            this.tbQueueName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Queue :";
            // 
            // cbQueues
            // 
            this.cbQueues.FormattingEnabled = true;
            this.cbQueues.Location = new System.Drawing.Point(89, 13);
            this.cbQueues.Name = "cbQueues";
            this.cbQueues.Size = new System.Drawing.Size(121, 21);
            this.cbQueues.TabIndex = 6;
            this.cbQueues.SelectedIndexChanged += new System.EventHandler(this.cbQueues_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "or enter queue name:";
            // 
            // btnSelectQueue
            // 
            this.btnSelectQueue.Location = new System.Drawing.Point(468, 10);
            this.btnSelectQueue.Name = "btnSelectQueue";
            this.btnSelectQueue.Size = new System.Drawing.Size(72, 23);
            this.btnSelectQueue.TabIndex = 8;
            this.btnSelectQueue.Text = "OK";
            this.btnSelectQueue.UseVisualStyleBackColor = true;
            this.btnSelectQueue.Click += new System.EventHandler(this.btnSelectQueue_Click);
            // 
            // tbMessageText
            // 
            this.tbMessageText.Location = new System.Drawing.Point(12, 92);
            this.tbMessageText.Multiline = true;
            this.tbMessageText.Name = "tbMessageText";
            this.tbMessageText.Size = new System.Drawing.Size(258, 69);
            this.tbMessageText.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Message Text:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 275);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMessageText);
            this.Controls.Add(this.btnSelectQueue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbQueues);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbQueueName);
            this.Controls.Add(this.lblQueueTitle);
            this.Controls.Add(this.tbMessageList);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.btnSend);
            this.Name = "Form1";
            this.Text = "MSMQ Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.TextBox tbMessageList;
        private System.Windows.Forms.Label lblQueueTitle;
        private System.Windows.Forms.TextBox tbQueueName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbQueues;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectQueue;
        private System.Windows.Forms.TextBox tbMessageText;
        private System.Windows.Forms.Label label3;
    }
}

