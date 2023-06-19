namespace UDP
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
            this.b_UDP_Server = new System.Windows.Forms.Button();
            this.b_UDP_Client = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_UDP_Server
            // 
            this.b_UDP_Server.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_UDP_Server.Location = new System.Drawing.Point(596, 102);
            this.b_UDP_Server.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.b_UDP_Server.Name = "b_UDP_Server";
            this.b_UDP_Server.Size = new System.Drawing.Size(177, 72);
            this.b_UDP_Server.TabIndex = 3;
            this.b_UDP_Server.Text = "UDP Server";
            this.b_UDP_Server.UseVisualStyleBackColor = true;
            // 
            // b_UDP_Client
            // 
            this.b_UDP_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_UDP_Client.Location = new System.Drawing.Point(304, 102);
            this.b_UDP_Client.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.b_UDP_Client.Name = "b_UDP_Client";
            this.b_UDP_Client.Size = new System.Drawing.Size(177, 72);
            this.b_UDP_Client.TabIndex = 2;
            this.b_UDP_Client.Text = "UDP Client";
            this.b_UDP_Client.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 272);
            this.Controls.Add(this.b_UDP_Server);
            this.Controls.Add(this.b_UDP_Client);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_UDP_Server;
        private System.Windows.Forms.Button b_UDP_Client;
    }
}

