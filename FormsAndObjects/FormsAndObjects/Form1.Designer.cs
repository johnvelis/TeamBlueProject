namespace FormsAndObjects
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.lblTestFirstName = new System.Windows.Forms.Label();
            this.lblTestLastName = new System.Windows.Forms.Label();
            this.lblTestOrderDate = new System.Windows.Forms.Label();
            this.textBoxOrderDate = new System.Windows.Forms.TextBox();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            this.btnNextForm = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageStart = new System.Windows.Forms.TabPage();
            this.tabPageSecond = new System.Windows.Forms.TabPage();
            this.lblSecondFirstName = new System.Windows.Forms.Label();
            this.tabPageThird = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPageStart.SuspendLayout();
            this.tabPageSecond.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(33, 28);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(76, 17);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(133, 28);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 22);
            this.textBoxFirstName.TabIndex = 1;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(33, 68);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 17);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(133, 68);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 22);
            this.textBoxLastName.TabIndex = 5;
            // 
            // lblTestFirstName
            // 
            this.lblTestFirstName.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblTestFirstName.Location = new System.Drawing.Point(422, 28);
            this.lblTestFirstName.Name = "lblTestFirstName";
            this.lblTestFirstName.Size = new System.Drawing.Size(100, 22);
            this.lblTestFirstName.TabIndex = 2;
            // 
            // lblTestLastName
            // 
            this.lblTestLastName.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblTestLastName.Location = new System.Drawing.Point(422, 71);
            this.lblTestLastName.Name = "lblTestLastName";
            this.lblTestLastName.Size = new System.Drawing.Size(100, 22);
            this.lblTestLastName.TabIndex = 6;
            // 
            // lblTestOrderDate
            // 
            this.lblTestOrderDate.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblTestOrderDate.Location = new System.Drawing.Point(422, 115);
            this.lblTestOrderDate.Name = "lblTestOrderDate";
            this.lblTestOrderDate.Size = new System.Drawing.Size(100, 22);
            this.lblTestOrderDate.TabIndex = 9;
            // 
            // textBoxOrderDate
            // 
            this.textBoxOrderDate.Location = new System.Drawing.Point(133, 112);
            this.textBoxOrderDate.Name = "textBoxOrderDate";
            this.textBoxOrderDate.Size = new System.Drawing.Size(100, 22);
            this.textBoxOrderDate.TabIndex = 8;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(33, 112);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(79, 17);
            this.lblOrderDate.TabIndex = 7;
            this.lblOrderDate.Text = "Order Date";
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.Location = new System.Drawing.Point(36, 168);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(150, 32);
            this.btnUpdateInfo.TabIndex = 10;
            this.btnUpdateInfo.Text = "Update Information";
            this.btnUpdateInfo.UseVisualStyleBackColor = true;
            this.btnUpdateInfo.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // btnNextForm
            // 
            this.btnNextForm.Location = new System.Drawing.Point(213, 168);
            this.btnNextForm.Name = "btnNextForm";
            this.btnNextForm.Size = new System.Drawing.Size(150, 32);
            this.btnNextForm.TabIndex = 11;
            this.btnNextForm.Text = "Next Form";
            this.btnNextForm.UseVisualStyleBackColor = true;
            this.btnNextForm.Click += new System.EventHandler(this.btnNextForm_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageStart);
            this.tabControl1.Controls.Add(this.tabPageSecond);
            this.tabControl1.Controls.Add(this.tabPageThird);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(782, 269);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPageStart
            // 
            this.tabPageStart.Controls.Add(this.textBoxOrderDate);
            this.tabPageStart.Controls.Add(this.btnNextForm);
            this.tabPageStart.Controls.Add(this.lblFirstName);
            this.tabPageStart.Controls.Add(this.btnUpdateInfo);
            this.tabPageStart.Controls.Add(this.textBoxFirstName);
            this.tabPageStart.Controls.Add(this.lblTestOrderDate);
            this.tabPageStart.Controls.Add(this.lblTestFirstName);
            this.tabPageStart.Controls.Add(this.lblLastName);
            this.tabPageStart.Controls.Add(this.lblOrderDate);
            this.tabPageStart.Controls.Add(this.textBoxLastName);
            this.tabPageStart.Controls.Add(this.lblTestLastName);
            this.tabPageStart.Location = new System.Drawing.Point(4, 25);
            this.tabPageStart.Name = "tabPageStart";
            this.tabPageStart.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStart.Size = new System.Drawing.Size(774, 240);
            this.tabPageStart.TabIndex = 0;
            this.tabPageStart.Text = "Start";
            this.tabPageStart.UseVisualStyleBackColor = true;
            this.tabPageStart.Click += new System.EventHandler(this.tabPageStart_Click);
            // 
            // tabPageSecond
            // 
            this.tabPageSecond.Controls.Add(this.lblSecondFirstName);
            this.tabPageSecond.Location = new System.Drawing.Point(4, 25);
            this.tabPageSecond.Name = "tabPageSecond";
            this.tabPageSecond.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSecond.Size = new System.Drawing.Size(774, 240);
            this.tabPageSecond.TabIndex = 1;
            this.tabPageSecond.Text = "Second";
            this.tabPageSecond.UseVisualStyleBackColor = true;
            this.tabPageSecond.Click += new System.EventHandler(this.tabPage2_Click);
            this.tabPageSecond.Enter += new System.EventHandler(this.tabPage2_Click);
            // 
            // lblSecondFirstName
            // 
            this.lblSecondFirstName.AutoSize = true;
            this.lblSecondFirstName.Location = new System.Drawing.Point(27, 28);
            this.lblSecondFirstName.Name = "lblSecondFirstName";
            this.lblSecondFirstName.Size = new System.Drawing.Size(46, 17);
            this.lblSecondFirstName.TabIndex = 0;
            this.lblSecondFirstName.Text = "label1";
            // 
            // tabPageThird
            // 
            this.tabPageThird.Location = new System.Drawing.Point(4, 25);
            this.tabPageThird.Name = "tabPageThird";
            this.tabPageThird.Size = new System.Drawing.Size(774, 240);
            this.tabPageThird.TabIndex = 2;
            this.tabPageThird.Text = "Third";
            this.tabPageThird.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 567);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPageStart.ResumeLayout(false);
            this.tabPageStart.PerformLayout();
            this.tabPageSecond.ResumeLayout(false);
            this.tabPageSecond.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label lblTestFirstName;
        private System.Windows.Forms.Label lblTestLastName;
        private System.Windows.Forms.Label lblTestOrderDate;
        private System.Windows.Forms.TextBox textBoxOrderDate;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Button btnUpdateInfo;
        private System.Windows.Forms.Button btnNextForm;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageStart;
        private System.Windows.Forms.TabPage tabPageSecond;
        private System.Windows.Forms.Label lblSecondFirstName;
        private System.Windows.Forms.TabPage tabPageThird;
    }
}

