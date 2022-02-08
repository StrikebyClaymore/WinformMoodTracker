
namespace MoodTracker.Forms
{
    partial class MainForm
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
            this.Statistic = new System.Windows.Forms.Button();
            this.EditMoods = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Statistic
            // 
            this.Statistic.Location = new System.Drawing.Point(187, 67);
            this.Statistic.Name = "Statistic";
            this.Statistic.Size = new System.Drawing.Size(244, 54);
            this.Statistic.TabIndex = 0;
            this.Statistic.Text = "Statistic";
            this.Statistic.UseVisualStyleBackColor = true;
            this.Statistic.Click += new System.EventHandler(this.Statistic_Click);
            // 
            // EditMoods
            // 
            this.EditMoods.Location = new System.Drawing.Point(187, 155);
            this.EditMoods.Name = "EditMoods";
            this.EditMoods.Size = new System.Drawing.Size(244, 54);
            this.EditMoods.TabIndex = 1;
            this.EditMoods.Text = "Edit moods";
            this.EditMoods.UseVisualStyleBackColor = true;
            this.EditMoods.Click += new System.EventHandler(this.EditMoods_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 502);
            this.Controls.Add(this.EditMoods);
            this.Controls.Add(this.Statistic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Дневник настроения";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Statistic;
        private System.Windows.Forms.Button EditMoods;
    }
}