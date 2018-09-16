namespace ResoflexClientFeedBackSystem
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
            this.components = new System.ComponentModel.Container();
            this.msgTxtBox = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.notifyIconMailSuccessful = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxTV = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // msgTxtBox
            // 
            this.msgTxtBox.Location = new System.Drawing.Point(73, 42);
            this.msgTxtBox.Multiline = true;
            this.msgTxtBox.Name = "msgTxtBox";
            this.msgTxtBox.Size = new System.Drawing.Size(372, 67);
            this.msgTxtBox.TabIndex = 0;
            // 
            // sendBtn
            // 
            this.sendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.Location = new System.Drawing.Point(73, 180);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(126, 33);
            this.sendBtn.TabIndex = 1;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // notifyIconMailSuccessful
            // 
            this.notifyIconMailSuccessful.Text = "Email Sent Successfully";
            this.notifyIconMailSuccessful.Visible = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Issue";
            // 
            // checkBoxTV
            // 
            this.checkBoxTV.AutoSize = true;
            this.checkBoxTV.Location = new System.Drawing.Point(73, 136);
            this.checkBoxTV.Name = "checkBoxTV";
            this.checkBoxTV.Size = new System.Drawing.Size(108, 21);
            this.checkBoxTV.TabIndex = 3;
            this.checkBoxTV.Text = "TeamViewer";
            this.checkBoxTV.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(197, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "RFS is Online!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxTV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.msgTxtBox);
            this.Name = "Form1";
            this.Text = "Bug Reporter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox msgTxtBox;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.NotifyIcon notifyIconMailSuccessful;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxTV;
        private System.Windows.Forms.Label label2;
    }
}

