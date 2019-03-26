namespace Client
{
    partial class ClientForm
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
            this.StartInput = new System.Windows.Forms.Button();
            this.PortInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HostInput = new System.Windows.Forms.TextBox();
            this.MessageInput = new System.Windows.Forms.RichTextBox();
            this.SendMessageInput = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.RichTextBox();
            this.NameInput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // StartInput
            // 
            this.StartInput.Location = new System.Drawing.Point(307, 6);
            this.StartInput.Name = "StartInput";
            this.StartInput.Size = new System.Drawing.Size(75, 20);
            this.StartInput.TabIndex = 9;
            this.StartInput.Text = "START";
            this.StartInput.UseVisualStyleBackColor = true;
            this.StartInput.Click += new System.EventHandler(this.StartInput_Click);
            // 
            // PortInput
            // 
            this.PortInput.Location = new System.Drawing.Point(201, 6);
            this.PortInput.Name = "PortInput";
            this.PortInput.Size = new System.Drawing.Size(100, 20);
            this.PortInput.TabIndex = 8;
            this.PortInput.Text = "8910";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "PORT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "HOST";
            // 
            // HostInput
            // 
            this.HostInput.Location = new System.Drawing.Point(52, 6);
            this.HostInput.Name = "HostInput";
            this.HostInput.Size = new System.Drawing.Size(100, 20);
            this.HostInput.TabIndex = 5;
            this.HostInput.Text = "127.0.0.1";
            // 
            // MessageInput
            // 
            this.MessageInput.Location = new System.Drawing.Point(14, 70);
            this.MessageInput.Name = "MessageInput";
            this.MessageInput.Size = new System.Drawing.Size(287, 36);
            this.MessageInput.TabIndex = 10;
            this.MessageInput.Text = "";
            // 
            // SendMessageInput
            // 
            this.SendMessageInput.Location = new System.Drawing.Point(307, 32);
            this.SendMessageInput.Name = "SendMessageInput";
            this.SendMessageInput.Size = new System.Drawing.Size(75, 74);
            this.SendMessageInput.TabIndex = 11;
            this.SendMessageInput.Text = "SEND";
            this.SendMessageInput.UseVisualStyleBackColor = true;
            this.SendMessageInput.Click += new System.EventHandler(this.SendMessageInput_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(12, 112);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(371, 116);
            this.txtStatus.TabIndex = 12;
            this.txtStatus.Text = "";
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(14, 32);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(287, 32);
            this.NameInput.TabIndex = 13;
            this.NameInput.Text = "Name";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 240);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.SendMessageInput);
            this.Controls.Add(this.MessageInput);
            this.Controls.Add(this.StartInput);
            this.Controls.Add(this.PortInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HostInput);
            this.Name = "ClientForm";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartInput;
        private System.Windows.Forms.TextBox PortInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HostInput;
        private System.Windows.Forms.RichTextBox MessageInput;
        private System.Windows.Forms.Button SendMessageInput;
        private System.Windows.Forms.RichTextBox txtStatus;
        private System.Windows.Forms.RichTextBox NameInput;
    }
}

