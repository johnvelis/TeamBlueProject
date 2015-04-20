namespace BazingaPizzaria
{
    partial class BackOfHouse
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnPrevious_TG = new System.Windows.Forms.Button();
            this.btnNext_TG = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnDone_TG = new System.Windows.Forms.Button();
            this.btnCancelOrder_TG = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(280, 342);
            this.listBox1.TabIndex = 0;
            // 
            // btnPrevious_TG
            // 
            this.btnPrevious_TG.Location = new System.Drawing.Point(12, 383);
            this.btnPrevious_TG.Name = "btnPrevious_TG";
            this.btnPrevious_TG.Size = new System.Drawing.Size(132, 60);
            this.btnPrevious_TG.TabIndex = 2;
            this.btnPrevious_TG.Text = "Previous";
            this.btnPrevious_TG.UseVisualStyleBackColor = true;
            this.btnPrevious_TG.Click += new System.EventHandler(this.btnPrevious_TG_Click);
            // 
            // btnNext_TG
            // 
            this.btnNext_TG.Location = new System.Drawing.Point(160, 383);
            this.btnNext_TG.Name = "btnNext_TG";
            this.btnNext_TG.Size = new System.Drawing.Size(132, 60);
            this.btnNext_TG.TabIndex = 3;
            this.btnNext_TG.Text = "Next";
            this.btnNext_TG.UseVisualStyleBackColor = true;
            this.btnNext_TG.Click += new System.EventHandler(this.btnNext_TG_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(301, 35);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(280, 342);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // btnDone_TG
            // 
            this.btnDone_TG.Location = new System.Drawing.Point(449, 383);
            this.btnDone_TG.Name = "btnDone_TG";
            this.btnDone_TG.Size = new System.Drawing.Size(132, 60);
            this.btnDone_TG.TabIndex = 5;
            this.btnDone_TG.Text = "Done";
            this.btnDone_TG.UseVisualStyleBackColor = true;
            this.btnDone_TG.Click += new System.EventHandler(this.btnDone_TG_Click);
            // 
            // btnCancelOrder_TG
            // 
            this.btnCancelOrder_TG.Location = new System.Drawing.Point(301, 383);
            this.btnCancelOrder_TG.Name = "btnCancelOrder_TG";
            this.btnCancelOrder_TG.Size = new System.Drawing.Size(132, 60);
            this.btnCancelOrder_TG.TabIndex = 6;
            this.btnCancelOrder_TG.Text = "Cancel Order";
            this.btnCancelOrder_TG.UseVisualStyleBackColor = true;
            this.btnCancelOrder_TG.Click += new System.EventHandler(this.btnCancelOrder_TG_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Order Queque";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Order Details";
            // 
            // BackOfHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 455);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelOrder_TG);
            this.Controls.Add(this.btnDone_TG);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnNext_TG);
            this.Controls.Add(this.btnPrevious_TG);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BackOfHouse";
            this.Text = "Order Queque";
            this.Load += new System.EventHandler(this.BackOfHouse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnPrevious_TG;
        private System.Windows.Forms.Button btnNext_TG;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnDone_TG;
        private System.Windows.Forms.Button btnCancelOrder_TG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}