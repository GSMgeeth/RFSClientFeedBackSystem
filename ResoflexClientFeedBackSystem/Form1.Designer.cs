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
            this.msgTxtBox.Location = new System.Drawing.Point(55, 34);
            this.msgTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.msgTxtBox.Multiline = true;
            this.msgTxtBox.Name = "msgTxtBox";
            this.msgTxtBox.Size = new System.Drawing.Size(280, 55);
            this.msgTxtBox.TabIndex = 0;
            // 
            // sendBtn
            // 
            this.sendBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sendBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.sendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.Location = new System.Drawing.Point(55, 146);
            this.sendBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(94, 27);
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
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Issue";
            // 
            // checkBoxTV
            // 
            this.checkBoxTV.AutoSize = true;
            this.checkBoxTV.Location = new System.Drawing.Point(55, 110);
            this.checkBoxTV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxTV.Name = "checkBoxTV";
            this.checkBoxTV.Size = new System.Drawing.Size(85, 17);
            this.checkBoxTV.TabIndex = 3;
            this.checkBoxTV.Text = "TeamViewer";
            this.checkBoxTV.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(148, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "RFS is Online!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxTV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.msgTxtBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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

