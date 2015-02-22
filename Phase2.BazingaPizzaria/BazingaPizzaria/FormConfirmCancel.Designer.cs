namespace BazingaPizzaria
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
            this.pictureBoxBanner = new System.Windows.Forms.PictureBox();
            this.btnYesPlease = new System.Windows.Forms.Button();
            this.btnNoWay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConfirmCancelText
            // 
            this.lblConfirmCancelText.AutoSize = true;
            this.lblConfirmCancelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmCancelText.Location = new System.Drawing.Point(121, 97);
            this.lblConfirmCancelText.Name = "lblConfirmCancelText";
            this.lblConfirmCancelText.Size = new System.Drawing.Size(353, 186);
            this.lblConfirmCancelText.TabIndex = 2;
            this.lblConfirmCancelText.Text = "You have chosen to cancel \r\nyour current order.\r\n\r\nDo you really want to cancel\r\n" +
    "your order and not have a \r\npizza to eat tonight?";
            this.lblConfirmCancelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxBanner
            // 
            this.pictureBoxBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBoxBanner.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBanner.Image")));
            this.pictureBoxBanner.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxBanner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxBanner.Name = "pictureBoxBanner";
            this.pictureBoxBanner.Size = new System.Drawing.Size(571, 74);
            this.pictureBoxBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBanner.TabIndex = 0;
            this.pictureBoxBanner.TabStop = false;
            // 
            // btnYesPlease
            // 
            this.btnYesPlease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnYesPlease.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnYesPlease.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYesPlease.ForeColor = System.Drawing.Color.White;
            this.btnYesPlease.Location = new System.Drawing.Point(29, 302);
            this.btnYesPlease.Margin = new System.Windows.Forms.Padding(4);
            this.btnYesPlease.Name = "btnYesPlease";
            this.btnYesPlease.Padding = new System.Windows.Forms.Padding(0, 2, 3, 0);
            this.btnYesPlease.Size = new System.Drawing.Size(231, 64);
            this.btnYesPlease.TabIndex = 1;
            this.btnYesPlease.Text = "&Yes, Please";
            this.btnYesPlease.UseVisualStyleBackColor = false;
            this.btnYesPlease.Click += new System.EventHandler(this.btnYesPlease_Click);
            this.btnYesPlease.MouseEnter += new System.EventHandler(this.StandardButtonEnter);
            this.btnYesPlease.MouseLeave += new System.EventHandler(this.StandardButtonLeave);
            // 
            // btnNoWay
            // 
            this.btnNoWay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNoWay.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNoWay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(195)))), ((int)(((byte)(232)))));
            this.btnNoWay.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoWay.ForeColor = System.Drawing.Color.White;
            this.btnNoWay.Location = new System.Drawing.Point(339, 302);
            this.btnNoWay.Margin = new System.Windows.Forms.Padding(4);
            this.btnNoWay.Name = "btnNoWay";
            this.btnNoWay.Padding = new System.Windows.Forms.Padding(0, 2, 3, 0);
            this.btnNoWay.Size = new System.Drawing.Size(231, 64);
            this.btnNoWay.TabIndex = 0;
            this.btnNoWay.Text = "&No Way!!!";
            this.btnNoWay.UseVisualStyleBackColor = false;
            this.btnNoWay.Click += new System.EventHandler(this.btnNoWay_Click);
            this.btnNoWay.MouseEnter += new System.EventHandler(this.StandardButtonEnter);
            this.btnNoWay.MouseLeave += new System.EventHandler(this.StandardButtonLeave);
            // 
            // FormConfirmCancel
            // 
            this.AcceptButton = this.btnNoWay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnYesPlease;
            this.ClientSize = new System.Drawing.Size(598, 398);
            this.ControlBox = false;
            this.Controls.Add(this.btnNoWay);
            this.Controls.Add(this.btnYesPlease);
            this.Controls.Add(this.lblConfirmCancelText);
            this.Controls.Add(this.pictureBoxBanner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormConfirmCancel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBanner;
        private System.Windows.Forms.Label lblConfirmCancelText;
        private System.Windows.Forms.Button btnYesPlease;
        private System.Windows.Forms.Button btnNoWay;

    }
}