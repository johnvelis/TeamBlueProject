namespace BazingaPizzaria
{
    partial class FormCompletedOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompletedOrder));
            this.btn_JV_ReturnMainMenu = new System.Windows.Forms.Button();
            this.lblConfirmCancelText = new System.Windows.Forms.Label();
            this.pictureBoxBanner = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_JV_ReturnMainMenu
            // 
            this.btn_JV_ReturnMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_JV_ReturnMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_JV_ReturnMainMenu.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_JV_ReturnMainMenu.ForeColor = System.Drawing.Color.White;
            this.btn_JV_ReturnMainMenu.Location = new System.Drawing.Point(70, 241);
            this.btn_JV_ReturnMainMenu.Name = "btn_JV_ReturnMainMenu";
            this.btn_JV_ReturnMainMenu.Padding = new System.Windows.Forms.Padding(0, 2, 2, 0);
            this.btn_JV_ReturnMainMenu.Size = new System.Drawing.Size(309, 64);
            this.btn_JV_ReturnMainMenu.TabIndex = 4;
            this.btn_JV_ReturnMainMenu.Text = "&Return to Main Menu";
            this.btn_JV_ReturnMainMenu.UseVisualStyleBackColor = false;
            this.btn_JV_ReturnMainMenu.Click += new System.EventHandler(this.btn_JV_ReturnMainMenu_Click);
            this.btn_JV_ReturnMainMenu.MouseEnter += new System.EventHandler(this.btn_JV_ReturnMainMenu_MouseEnter);
            this.btn_JV_ReturnMainMenu.MouseLeave += new System.EventHandler(this.btn_JV_ReturnMainMenu_MouseLeave);
            // 
            // lblConfirmCancelText
            // 
            this.lblConfirmCancelText.AutoSize = true;
            this.lblConfirmCancelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmCancelText.Location = new System.Drawing.Point(11, 82);
            this.lblConfirmCancelText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirmCancelText.Name = "lblConfirmCancelText";
            this.lblConfirmCancelText.Size = new System.Drawing.Size(427, 156);
            this.lblConfirmCancelText.TabIndex = 5;
            this.lblConfirmCancelText.Text = "Bazinga Pizzeria thanks you for your order.\r\nYour pizza will be ready in approxim" +
    "ately \r\n20 minutes and your order number is 14.\r\n\r\nClick the button below \r\nto r" +
    "eturn to the starting menu.";
            this.lblConfirmCancelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblConfirmCancelText.Click += new System.EventHandler(this.lblConfirmCancelText_Click);
            // 
            // pictureBoxBanner
            // 
            this.pictureBoxBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBoxBanner.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBanner.Image")));
            this.pictureBoxBanner.Location = new System.Drawing.Point(11, 9);
            this.pictureBoxBanner.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxBanner.Name = "pictureBoxBanner";
            this.pictureBoxBanner.Size = new System.Drawing.Size(428, 60);
            this.pictureBoxBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBanner.TabIndex = 3;
            this.pictureBoxBanner.TabStop = false;
            // 
            // FormCompletedOrder
            // 
            this.AcceptButton = this.btn_JV_ReturnMainMenu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(448, 323);
            this.ControlBox = false;
            this.Controls.Add(this.btn_JV_ReturnMainMenu);
            this.Controls.Add(this.lblConfirmCancelText);
            this.Controls.Add(this.pictureBoxBanner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCompletedOrder";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_JV_ReturnMainMenu;
        private System.Windows.Forms.Label lblConfirmCancelText;
        private System.Windows.Forms.PictureBox pictureBoxBanner;
    }
}