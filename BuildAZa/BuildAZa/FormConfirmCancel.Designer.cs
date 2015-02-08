namespace BuildAZa
{
    public partial class FormConfirmCancel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfirmCancel));
            this.lblConfirmCancelText = new System.Windows.Forms.Label();
            this.pictureBoxNo = new System.Windows.Forms.PictureBox();
            this.pictureBoxYes = new System.Windows.Forms.PictureBox();
            this.pictureBoxBanner = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConfirmCancelText
            // 
            this.lblConfirmCancelText.AutoSize = true;
            this.lblConfirmCancelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmCancelText.Location = new System.Drawing.Point(119, 105);
            this.lblConfirmCancelText.Name = "lblConfirmCancelText";
            this.lblConfirmCancelText.Size = new System.Drawing.Size(353, 155);
            this.lblConfirmCancelText.TabIndex = 1;
            this.lblConfirmCancelText.Text = "Warning Will Robinson...\r\nDanger!...Danger!\r\nDo you really want to cancel\r\nyour o" +
    "rder and not have a \r\npizza to eat tonight?";
            this.lblConfirmCancelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxNo
            // 
            this.pictureBoxNo.Image = global::BuildAZa.Properties.Resources.btnNo;
            this.pictureBoxNo.Location = new System.Drawing.Point(345, 282);
            this.pictureBoxNo.Name = "pictureBoxNo";
            this.pictureBoxNo.Size = new System.Drawing.Size(201, 82);
            this.pictureBoxNo.TabIndex = 3;
            this.pictureBoxNo.TabStop = false;
            this.pictureBoxNo.Click += new System.EventHandler(this.pictureBoxNo_Click);
            // 
            // pictureBoxYes
            // 
            this.pictureBoxYes.Image = global::BuildAZa.Properties.Resources.btnYes;
            this.pictureBoxYes.Location = new System.Drawing.Point(44, 282);
            this.pictureBoxYes.Name = "pictureBoxYes";
            this.pictureBoxYes.Size = new System.Drawing.Size(202, 82);
            this.pictureBoxYes.TabIndex = 2;
            this.pictureBoxYes.TabStop = false;
            this.pictureBoxYes.Click += new System.EventHandler(this.pictureBoxYes_Click);
            // 
            // pictureBoxBanner
            // 
            this.pictureBoxBanner.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBanner.Image")));
            this.pictureBoxBanner.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxBanner.Name = "pictureBoxBanner";
            this.pictureBoxBanner.Size = new System.Drawing.Size(558, 74);
            this.pictureBoxBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBanner.TabIndex = 0;
            this.pictureBoxBanner.TabStop = false;
            // 
            // FormConfirmCancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(598, 398);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBoxNo);
            this.Controls.Add(this.pictureBoxYes);
            this.Controls.Add(this.lblConfirmCancelText);
            this.Controls.Add(this.pictureBoxBanner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormConfirmCancel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBanner;
        private System.Windows.Forms.Label lblConfirmCancelText;
        private System.Windows.Forms.PictureBox pictureBoxYes;
        private System.Windows.Forms.PictureBox pictureBoxNo;

    }
}