namespace DailyBrew
{
    partial class FormHistory
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
            this.btnnew = new System.Windows.Forms.Button();
            this.lbhistory = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnnew
            // 
            this.btnnew.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnnew.Location = new System.Drawing.Point(637, 12);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(151, 49);
            this.btnnew.TabIndex = 0;
            this.btnnew.Text = "새로고침";
            this.btnnew.UseVisualStyleBackColor = true;
            // 
            // lbhistory
            // 
            this.lbhistory.FormattingEnabled = true;
            this.lbhistory.ItemHeight = 12;
            this.lbhistory.Location = new System.Drawing.Point(12, 80);
            this.lbhistory.Name = "lbhistory";
            this.lbhistory.Size = new System.Drawing.Size(776, 352);
            this.lbhistory.TabIndex = 1;
            // 
            // FormHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbhistory);
            this.Controls.Add(this.btnnew);
            this.Name = "FormHistory";
            this.Text = "FormHistory";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.ListBox lbhistory;
    }
}