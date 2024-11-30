namespace BTbuoi4
{
    partial class Nhan_vien
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
            this.txtluong = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.yes = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtms = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtluong
            // 
            this.txtluong.Location = new System.Drawing.Point(185, 245);
            this.txtluong.Name = "txtluong";
            this.txtluong.Size = new System.Drawing.Size(333, 22);
            this.txtluong.TabIndex = 2;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(185, 176);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(333, 22);
            this.txtten.TabIndex = 3;
            // 
            // yes
            // 
            this.yes.Location = new System.Drawing.Point(185, 326);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(99, 34);
            this.yes.TabIndex = 4;
            this.yes.Text = "dong y";
            this.yes.UseVisualStyleBackColor = true;
            this.yes.Click += new System.EventHandler(this.yes_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(415, 326);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(103, 34);
            this.close.TabIndex = 5;
            this.close.Text = "bo qua";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "MS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "luong";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "ten";
            // 
            // txtms
            // 
            this.txtms.Location = new System.Drawing.Point(185, 81);
            this.txtms.Name = "txtms";
            this.txtms.Size = new System.Drawing.Size(333, 22);
            this.txtms.TabIndex = 9;
            // 
            // Nhan_vien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtms);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.yes);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.txtluong);
            this.Name = "Nhan_vien";
            this.Text = "Nhan_vien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtluong;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Button yes;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtms;
    }
}