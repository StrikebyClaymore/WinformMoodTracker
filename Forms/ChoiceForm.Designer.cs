
using Microsoft.Win32;
using System;

namespace MoodTracker.Forms
{
    partial class ChoiceForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.DateBox = new System.Windows.Forms.TableLayoutPanel();
            this.DateText = new System.Windows.Forms.LinkLabel();
            this.DateButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button4 = new System.Windows.Forms.Button();
            this.EditButton2 = new System.Windows.Forms.Button();
            this.EditButton1 = new System.Windows.Forms.Button();
            this.NeutralButton = new System.Windows.Forms.Button();
            this.BadButton = new System.Windows.Forms.Button();
            this.AwfulButton = new System.Windows.Forms.Button();
            this.GoodButton = new System.Windows.Forms.Button();
            this.RadButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SetNextDay = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SaveLabel = new System.Windows.Forms.Button();
            this.DateBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(152, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Как ты себя чувствуешь?";
            // 
            // DateBox
            // 
            this.DateBox.ColumnCount = 2;
            this.DateBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.27668F));
            this.DateBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.72332F));
            this.DateBox.Controls.Add(this.DateText, 1, 0);
            this.DateBox.Controls.Add(this.DateButton, 0, 0);
            this.DateBox.Location = new System.Drawing.Point(192, 70);
            this.DateBox.Name = "DateBox";
            this.DateBox.RowCount = 1;
            this.DateBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DateBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.DateBox.Size = new System.Drawing.Size(239, 23);
            this.DateBox.TabIndex = 2;
            // 
            // DateText
            // 
            this.DateText.AutoSize = true;
            this.DateText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DateText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateText.LinkColor = System.Drawing.Color.ForestGreen;
            this.DateText.Location = new System.Drawing.Point(27, 0);
            this.DateText.Name = "DateText";
            this.DateText.Size = new System.Drawing.Size(196, 21);
            this.DateText.TabIndex = 4;
            this.DateText.TabStop = true;
            this.DateText.Text = "Сегодня, 12 августа, 10:00";
            this.DateText.VisitedLinkColor = System.Drawing.Color.DarkOrchid;
            this.DateText.Click += new System.EventHandler(this.Date_Click);
            // 
            // DateButton
            // 
            this.DateButton.AutoSize = true;
            this.DateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DateButton.FlatAppearance.BorderSize = 0;
            this.DateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.DateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DateButton.Image = global::MoodTracker.Properties.Resources.date_icon;
            this.DateButton.Location = new System.Drawing.Point(0, 0);
            this.DateButton.Margin = new System.Windows.Forms.Padding(0);
            this.DateButton.Name = "DateButton";
            this.DateButton.Size = new System.Drawing.Size(22, 22);
            this.DateButton.TabIndex = 4;
            this.DateButton.UseVisualStyleBackColor = true;
            this.DateButton.Click += new System.EventHandler(this.Date_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Image = global::MoodTracker.Properties.Resources.close_icon;
            this.CloseButton.Location = new System.Drawing.Point(12, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(38, 38);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.AutoSize = true;
            this.EditButton.BackColor = System.Drawing.Color.Transparent;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Image = global::MoodTracker.Properties.Resources.edit_icon;
            this.EditButton.Location = new System.Drawing.Point(558, 412);
            this.EditButton.Name = "EditButton";
            this.EditButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EditButton.Size = new System.Drawing.Size(38, 38);
            this.EditButton.TabIndex = 4;
            this.EditButton.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.27668F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.72332F));
            this.tableLayoutPanel2.Controls.Add(this.linkLabel1, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkColor = System.Drawing.Color.LimeGreen;
            this.linkLabel1.Location = new System.Drawing.Point(23, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(157, 42);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Сегодня, 12 августа, 10:00";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.DarkOrchid;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::MoodTracker.Properties.Resources.date_icon;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(20, 22);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // EditButton2
            // 
            this.EditButton2.AutoSize = true;
            this.EditButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditButton2.FlatAppearance.BorderSize = 0;
            this.EditButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.EditButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditButton2.ForeColor = System.Drawing.Color.ForestGreen;
            this.EditButton2.Location = new System.Drawing.Point(519, 456);
            this.EditButton2.Name = "EditButton2";
            this.EditButton2.Size = new System.Drawing.Size(122, 27);
            this.EditButton2.TabIndex = 6;
            this.EditButton2.Text = "Оставить заметку";
            this.EditButton2.UseVisualStyleBackColor = true;
            this.EditButton2.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // EditButton1
            // 
            this.EditButton1.AutoSize = true;
            this.EditButton1.BackColor = System.Drawing.Color.Transparent;
            this.EditButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditButton1.FlatAppearance.BorderSize = 0;
            this.EditButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.EditButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton1.Image = global::MoodTracker.Properties.Resources.edit_icon;
            this.EditButton1.Location = new System.Drawing.Point(558, 412);
            this.EditButton1.Name = "EditButton1";
            this.EditButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EditButton1.Size = new System.Drawing.Size(38, 38);
            this.EditButton1.TabIndex = 4;
            this.EditButton1.UseVisualStyleBackColor = false;
            this.EditButton1.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // NeutralButton
            // 
            this.NeutralButton.AutoSize = true;
            this.NeutralButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NeutralButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NeutralButton.FlatAppearance.BorderSize = 0;
            this.NeutralButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.NeutralButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NeutralButton.Image = global::MoodTracker.Properties.Resources.neutral;
            this.NeutralButton.Location = new System.Drawing.Point(155, 3);
            this.NeutralButton.Name = "NeutralButton";
            this.NeutralButton.Size = new System.Drawing.Size(70, 70);
            this.NeutralButton.TabIndex = 7;
            this.NeutralButton.UseVisualStyleBackColor = true;
            this.NeutralButton.Click += new System.EventHandler(this.ChoiseMoodButton_Click);
            // 
            // BadButton
            // 
            this.BadButton.AutoSize = true;
            this.BadButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BadButton.FlatAppearance.BorderSize = 0;
            this.BadButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BadButton.Image = global::MoodTracker.Properties.Resources.bad;
            this.BadButton.Location = new System.Drawing.Point(231, 3);
            this.BadButton.Name = "BadButton";
            this.BadButton.Size = new System.Drawing.Size(70, 70);
            this.BadButton.TabIndex = 8;
            this.BadButton.UseVisualStyleBackColor = true;
            this.BadButton.Click += new System.EventHandler(this.ChoiseMoodButton_Click);
            // 
            // AwfulButton
            // 
            this.AwfulButton.AutoSize = true;
            this.AwfulButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AwfulButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AwfulButton.FlatAppearance.BorderSize = 0;
            this.AwfulButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AwfulButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AwfulButton.Image = global::MoodTracker.Properties.Resources.awful;
            this.AwfulButton.Location = new System.Drawing.Point(307, 3);
            this.AwfulButton.Name = "AwfulButton";
            this.AwfulButton.Size = new System.Drawing.Size(70, 70);
            this.AwfulButton.TabIndex = 9;
            this.AwfulButton.UseVisualStyleBackColor = true;
            this.AwfulButton.Click += new System.EventHandler(this.ChoiseMoodButton_Click);
            // 
            // GoodButton
            // 
            this.GoodButton.AutoSize = true;
            this.GoodButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GoodButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoodButton.FlatAppearance.BorderSize = 0;
            this.GoodButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.GoodButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoodButton.Image = global::MoodTracker.Properties.Resources.good;
            this.GoodButton.Location = new System.Drawing.Point(79, 3);
            this.GoodButton.Name = "GoodButton";
            this.GoodButton.Size = new System.Drawing.Size(70, 70);
            this.GoodButton.TabIndex = 10;
            this.GoodButton.UseVisualStyleBackColor = true;
            this.GoodButton.Click += new System.EventHandler(this.ChoiseMoodButton_Click);
            // 
            // RadButton
            // 
            this.RadButton.AutoSize = true;
            this.RadButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadButton.FlatAppearance.BorderSize = 0;
            this.RadButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RadButton.Image = global::MoodTracker.Properties.Resources.rad;
            this.RadButton.Location = new System.Drawing.Point(3, 3);
            this.RadButton.Name = "RadButton";
            this.RadButton.Size = new System.Drawing.Size(70, 70);
            this.RadButton.TabIndex = 11;
            this.RadButton.UseVisualStyleBackColor = true;
            this.RadButton.Click += new System.EventHandler(this.ChoiseMoodButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.GoodButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BadButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.AwfulButton, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.RadButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.NeutralButton, 2, 0);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(137, 205);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(380, 76);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // SetNextDay
            // 
            this.SetNextDay.Location = new System.Drawing.Point(13, 433);
            this.SetNextDay.Name = "SetNextDay";
            this.SetNextDay.Size = new System.Drawing.Size(97, 46);
            this.SetNextDay.TabIndex = 13;
            this.SetNextDay.Text = "Set Next Day";
            this.SetNextDay.UseVisualStyleBackColor = true;
            this.SetNextDay.Click += new System.EventHandler(this.SetNextDay_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.AutoSize = true;
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Image = global::MoodTracker.Properties.Resources.accept;
            this.SaveButton.Location = new System.Drawing.Point(300, 397);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(59, 54);
            this.SaveButton.TabIndex = 14;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SaveLabel
            // 
            this.SaveLabel.AutoSize = true;
            this.SaveLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveLabel.FlatAppearance.BorderSize = 0;
            this.SaveLabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SaveLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.SaveLabel.Location = new System.Drawing.Point(271, 456);
            this.SaveLabel.Name = "SaveLabel";
            this.SaveLabel.Size = new System.Drawing.Size(122, 27);
            this.SaveLabel.TabIndex = 15;
            this.SaveLabel.Text = "Сохранить";
            this.SaveLabel.UseVisualStyleBackColor = true;
            this.SaveLabel.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ChoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(654, 502);
            this.Controls.Add(this.SaveLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SetNextDay);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.EditButton2);
            this.Controls.Add(this.EditButton1);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ChoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Дневник настроения";
            this.VisibleChanged += new System.EventHandler(this.OpenDialog_Shown);
            this.DateBox.ResumeLayout(false);
            this.DateBox.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel DateBox;
        private System.Windows.Forms.LinkLabel DateText;
        private System.Windows.Forms.Button DateButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button EditButton2;
        private System.Windows.Forms.Button EditButton1;
        private System.Windows.Forms.Button NeutralButton;
        private System.Windows.Forms.Button BadButton;
        private System.Windows.Forms.Button AwfulButton;
        private System.Windows.Forms.Button GoodButton;
        private System.Windows.Forms.Button RadButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button SetNextDay;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button SaveLabel;
    }
}

