namespace UDP
{
    partial class UDP_Client
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.b_Send = new System.Windows.Forms.Button();
            this.rMessages = new System.Windows.Forms.RichTextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIPRemoteHost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 177);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "Message";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(442, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "IP Remote Host";
            // 
            // b_Send
            // 
            this.b_Send.AccessibleName = "b_Send";
            this.b_Send.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.b_Send.BackColor = System.Drawing.Color.White;
            this.b_Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Send.Location = new System.Drawing.Point(290, 496);
            this.b_Send.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.b_Send.Name = "b_Send";
            this.b_Send.Size = new System.Drawing.Size(158, 55);
            this.b_Send.TabIndex = 17;
            this.b_Send.Text = "Send";
            this.b_Send.UseVisualStyleBackColor = false;
            // 
            // rMessages
            // 
            this.rMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rMessages.Location = new System.Drawing.Point(117, 227);
            this.rMessages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rMessages.Name = "rMessages";
            this.rMessages.Size = new System.Drawing.Size(488, 224);
            this.rMessages.TabIndex = 16;
            this.rMessages.Text = "";
            // 
            // txtPort
            // 
            this.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPort.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(450, 120);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(156, 47);
            this.txtPort.TabIndex = 15;
            // 
            // txtIPRemoteHost
            // 
            this.txtIPRemoteHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIPRemoteHost.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPRemoteHost.Location = new System.Drawing.Point(117, 120);
            this.txtIPRemoteHost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIPRemoteHost.Name = "txtIPRemoteHost";
            this.txtIPRemoteHost.Size = new System.Drawing.Size(276, 47);
            this.txtIPRemoteHost.TabIndex = 14;
            // 
            // UDP_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 625);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.b_Send);
            this.Controls.Add(this.rMessages);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIPRemoteHost);
            this.Name = "UDP_Client";
            this.Text = "UDP_Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button b_Send;
        private System.Windows.Forms.RichTextBox rMessages;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIPRemoteHost;
    }
}