namespace WindowsFormsApp2
{
    partial class Sever
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
            this.lbConnections = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbConnections
            // 
            this.lbConnections.FormattingEnabled = true;
            this.lbConnections.ItemHeight = 20;
            this.lbConnections.Location = new System.Drawing.Point(106, 32);
            this.lbConnections.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbConnections.Name = "lbConnections";
            this.lbConnections.Size = new System.Drawing.Size(1124, 544);
            this.lbConnections.TabIndex = 1;
            // 
            // Sever
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 631);
            this.Controls.Add(this.lbConnections);
            this.Name = "Sever";
            this.Text = "Sever";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbConnections;
    }
}

