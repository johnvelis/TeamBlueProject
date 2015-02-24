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
            this.lblConfirmCancelText = new System.Windows.Forms.Label();
            this.pictureBoxBanner = new System.Windows.Forms.PictureBox();
            this.btnYesPlease = new System.Windows.Forms.Button();
            this.btnNoWay = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConfirmCancelText
            // 
            this.lblConfirmCancelText.AutoSize = true;
            this.lblConfirmCancelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmCancelText.Location = new System.Drawing.Point(91, 79);
            this.lblConfirmCancelText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirmCancelText.Name = "lblConfirmCancelText";
            this.lblConfirmCancelText.Size = new System.Drawing.Size(284, 156);
            this.lblConfirmCancelText.TabIndex = 2;
            this.lblConfirmCancelText.Text = "You have chosen to cancel \r\nyour current order.\r\n\r\nDo you really want to cancel\r\n" +
    "your order and not have a \r\npizza to eat tonight?";
            this.lblConfirmCancelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxBanner
            // 
            this.pictureBoxBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBoxBanner.Location = new System.Drawing.Point(10, 10);
            this.pictureBoxBanner.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxBanner.Name = "pictureBoxBanner";
            this.pictureBoxBanner.Size = new System.Drawing.Size(428, 60);
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
            this.btnYesPlease.Location = new System.Drawing.Point(22, 245);
            this.btnYesPlease.Name = "btnYesPlease";
            this.btnYesPlease.Padding = new System.Windows.Forms.Padding(0, 2, 2, 0);
            this.btnYesPlease.Size = new System.Drawing.Size(173, 52);
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
            this.btnNoWay.Location = new System.Drawing.Point(254, 245);
            this.btnNoWay.Name = "btnNoWay";
            this.btnNoWay.Padding = new System.Windows.Forms.Padding(0, 2, 2, 0);
            this.btnNoWay.Size = new System.Drawing.Size(173, 52);
            this.btnNoWay.TabIndex = 0;
            this.btnNoWay.Text = "&No Way!!!";
            this.btnNoWay.UseVisualStyleBackColor = false;
            this.btnNoWay.Click += new System.EventHandler(this.btnNoWay_Click);
            this.btnNoWay.MouseEnter += new System.EventHandler(this.StandardButtonEnter);
            this.btnNoWay.MouseLeave += new System.EventHandler(this.StandardButtonLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Verdana", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(39, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bazinga Pizzeria";
            // 
            // FormConfirmCancel
            // 
            this.AcceptButton = this.btnNoWay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnYesPlease;
            this.ClientSize = new System.Drawing.Size(448, 323);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNoWay);
            this.Controls.Add(this.btnYesPlease);
            this.Controls.Add(this.lblConfirmCancelText);
            this.Controls.Add(this.pictureBoxBanner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label label2;

    }
}