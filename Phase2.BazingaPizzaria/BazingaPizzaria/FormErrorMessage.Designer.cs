namespace BazingaPizzaria
{
    partial class FormErrorMessage
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
            this.btn_TG_Okay = new System.Windows.Forms.Button();
            this.pictureBoxBanner = new System.Windows.Forms.PictureBox();
            this.lbl_TG_ErrorMessage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_TG_Okay
            // 
            this.btn_TG_Okay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_TG_Okay.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TG_Okay.ForeColor = System.Drawing.Color.White;
            this.btn_TG_Okay.Location = new System.Drawing.Point(141, 245);
            this.btn_TG_Okay.Name = "btn_TG_Okay";
            this.btn_TG_Okay.Size = new System.Drawing.Size(173, 52);
            this.btn_TG_Okay.TabIndex = 0;
            this.btn_TG_Okay.Text = "&Okay";
            this.btn_TG_Okay.UseVisualStyleBackColor = false;
            this.btn_TG_Okay.Click += new System.EventHandler(this.btn_TG_Okay_Click);
            // 
            // pictureBoxBanner
            // 
            this.pictureBoxBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBoxBanner.Location = new System.Drawing.Point(10, 10);
            this.pictureBoxBanner.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxBanner.Name = "pictureBoxBanner";
            this.pictureBoxBanner.Size = new System.Drawing.Size(428, 60);
            this.pictureBoxBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBanner.TabIndex = 1;
            this.pictureBoxBanner.TabStop = false;
            // 
            // lbl_TG_ErrorMessage
            // 
            this.lbl_TG_ErrorMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TG_ErrorMessage.Location = new System.Drawing.Point(80, 72);
            this.lbl_TG_ErrorMessage.Name = "lbl_TG_ErrorMessage";
            this.lbl_TG_ErrorMessage.Size = new System.Drawing.Size(296, 170);
            this.lbl_TG_ErrorMessage.TabIndex = 2;
            this.lbl_TG_ErrorMessage.Text = "I will update with new text depending on what textbox is left empty.";
            this.lbl_TG_ErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.label2.TabIndex = 3;
            this.label2.Text = "Bazinga Pizzeria";
            // 
            // FormErrorMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 323);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_TG_ErrorMessage);
            this.Controls.Add(this.pictureBoxBanner);
            this.Controls.Add(this.btn_TG_Okay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormErrorMessage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_TG_Okay;
        private System.Windows.Forms.PictureBox pictureBoxBanner;
        private System.Windows.Forms.Label lbl_TG_ErrorMessage;
        private System.Windows.Forms.Label label2;
    }
}