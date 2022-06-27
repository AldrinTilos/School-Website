namespace practice_contact_tracing_
{
    partial class Form2
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
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.btn_date = new System.Windows.Forms.Button();
            this.lbl_all = new System.Windows.Forms.Label();
            this.btn_all = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(53, 44);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(206, 23);
            this.dtp_date.TabIndex = 0;
            // 
            // btn_date
            // 
            this.btn_date.Location = new System.Drawing.Point(61, 86);
            this.btn_date.Name = "btn_date";
            this.btn_date.Size = new System.Drawing.Size(133, 47);
            this.btn_date.TabIndex = 1;
            this.btn_date.Text = "Submit";
            this.btn_date.UseVisualStyleBackColor = true;
            this.btn_date.Click += new System.EventHandler(this.btn_date_Click);
            // 
            // lbl_all
            // 
            this.lbl_all.AutoSize = true;
            this.lbl_all.Location = new System.Drawing.Point(363, 77);
            this.lbl_all.Name = "lbl_all";
            this.lbl_all.Size = new System.Drawing.Size(53, 15);
            this.lbl_all.TabIndex = 2;
            this.lbl_all.Text = "Show All";
            // 
            // btn_all
            // 
            this.btn_all.Location = new System.Drawing.Point(346, 107);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(133, 47);
            this.btn_all.TabIndex = 3;
            this.btn_all.Text = "Submit";
            this.btn_all.UseVisualStyleBackColor = true;
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_all);
            this.Controls.Add(this.lbl_all);
            this.Controls.Add(this.btn_date);
            this.Controls.Add(this.dtp_date);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dtp_date;
        private Button btn_date;
        private Label lbl_all;
        private Button btn_all;
    }
}