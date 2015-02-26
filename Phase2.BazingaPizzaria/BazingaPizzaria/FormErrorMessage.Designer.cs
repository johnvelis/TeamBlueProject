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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.lbl_TG_ErrorMessage = new System.Windows.Forms.Label();
            this.btn_TG_OkayEmailMess = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label24);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 60);
            this.panel1.TabIndex = 6;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Verdana", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(32, 8);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(363, 45);
            this.label24.TabIndex = 1;
            this.label24.Text = "Bazinga Pizzeria";
            // 
            // lbl_TG_ErrorMessage
            // 
            this.lbl_TG_ErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TG_ErrorMessage.Location = new System.Drawing.Point(77, 94);
            this.lbl_TG_ErrorMessage.Name = "lbl_TG_ErrorMessage";
            this.lbl_TG_ErrorMessage.Size = new System.Drawing.Size(285, 120);
            this.lbl_TG_ErrorMessage.TabIndex = 5;
            this.lbl_TG_ErrorMessage.Text = "I will update with new text depending on what field is left empty";
            this.lbl_TG_ErrorMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_TG_OkayEmailMess
            // 
            this.btn_TG_OkayEmailMess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_TG_OkayEmailMess.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TG_OkayEmailMess.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_TG_OkayEmailMess.Location = new System.Drawing.Point(136, 256);
            this.btn_TG_OkayEmailMess.Name = "btn_TG_OkayEmailMess";
            this.btn_TG_OkayEmailMess.Size = new System.Drawing.Size(173, 52);
            this.btn_TG_OkayEmailMess.TabIndex = 4;
            this.btn_TG_OkayEmailMess.Text = "Okay!";
            this.btn_TG_OkayEmailMess.UseVisualStyleBackColor = false;
            this.btn_TG_OkayEmailMess.Click += new System.EventHandler(this.btn_TG_OkayEmailMess_Click);
            // 
            // FormErrorMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 323);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_TG_ErrorMessage);
            this.Controls.Add(this.btn_TG_OkayEmailMess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormErrorMessage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lbl_TG_ErrorMessage;
        private System.Windows.Forms.Button btn_TG_OkayEmailMess;
    }
}