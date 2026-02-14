namespace CinemaTicketsSellOtomation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbldate = new Label();
            btnnext = new Button();
            btnprevious = new Button();
            SuspendLayout();
            // 
            // lbldate
            // 
            lbldate.AutoSize = true;
            lbldate.Font = new Font("Segoe UI", 18F);
            lbldate.Location = new Point(531, 27);
            lbldate.Name = "lbldate";
            lbldate.Size = new Size(0, 41);
            lbldate.TabIndex = 0;
            // 
            // btnnext
            // 
            btnnext.Location = new Point(924, 37);
            btnnext.Name = "btnnext";
            btnnext.Size = new Size(163, 48);
            btnnext.TabIndex = 1;
            btnnext.Text = "Next =>";
            btnnext.UseVisualStyleBackColor = true;
            btnnext.Click += btnnext_Click;
            // 
            // btnprevious
            // 
            btnprevious.Enabled = false;
            btnprevious.Location = new Point(41, 37);
            btnprevious.Name = "btnprevious";
            btnprevious.Size = new Size(163, 48);
            btnprevious.TabIndex = 1;
            btnprevious.Text = "<= Previous";
            btnprevious.UseVisualStyleBackColor = true;
            btnprevious.Click += btnprevious_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 673);
            Controls.Add(btnprevious);
            Controls.Add(btnnext);
            Controls.Add(lbldate);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbldate;
        private Button btnnext;
        private Button btnprevious;
    }
}
