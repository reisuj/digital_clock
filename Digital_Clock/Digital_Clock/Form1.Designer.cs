namespace Digital_Clock
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnBreak = new System.Windows.Forms.Button();
            this.btnLunch = new System.Windows.Forms.Button();
            this.timeBreak = new System.Windows.Forms.Label();
            this.timeLunch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTime.Location = new System.Drawing.Point(34, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(221, 58);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "00:00:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnBreak
            // 
            this.btnBreak.Location = new System.Drawing.Point(12, 97);
            this.btnBreak.Name = "btnBreak";
            this.btnBreak.Size = new System.Drawing.Size(75, 23);
            this.btnBreak.TabIndex = 1;
            this.btnBreak.Text = "Break";
            this.btnBreak.UseVisualStyleBackColor = true;
            // 
            // btnLunch
            // 
            this.btnLunch.Location = new System.Drawing.Point(12, 144);
            this.btnLunch.Name = "btnLunch";
            this.btnLunch.Size = new System.Drawing.Size(75, 23);
            this.btnLunch.TabIndex = 2;
            this.btnLunch.Text = "Lunch";
            this.btnLunch.UseVisualStyleBackColor = true;
            // 
            // timeBreak
            // 
            this.timeBreak.AutoSize = true;
            this.timeBreak.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timeBreak.Location = new System.Drawing.Point(144, 103);
            this.timeBreak.Name = "timeBreak";
            this.timeBreak.Size = new System.Drawing.Size(64, 17);
            this.timeBreak.TabIndex = 3;
            this.timeBreak.Text = "00:00:00";
            // 
            // timeLunch
            // 
            this.timeLunch.AutoSize = true;
            this.timeLunch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timeLunch.Location = new System.Drawing.Point(144, 144);
            this.timeLunch.Name = "timeLunch";
            this.timeLunch.Size = new System.Drawing.Size(64, 17);
            this.timeLunch.TabIndex = 4;
            this.timeLunch.Text = "00:00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(299, 209);
            this.Controls.Add(this.timeLunch);
            this.Controls.Add(this.timeBreak);
            this.Controls.Add(this.btnLunch);
            this.Controls.Add(this.btnBreak);
            this.Controls.Add(this.lblTime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnBreak;
        private System.Windows.Forms.Button btnLunch;
        private System.Windows.Forms.Label timeBreak;
        private System.Windows.Forms.Label timeLunch;
    }
}

