
namespace MoodTracker.Forms
{
    partial class OpenDateForm
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.DateGrid = new System.Windows.Forms.TableLayoutPanel();
            this.Next = new System.Windows.Forms.Button();
            this.Previuos = new System.Windows.Forms.Button();
            this.CurrentDate = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.CloseButton.TabIndex = 4;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 396);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 58);
            this.button3.TabIndex = 7;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DateGrid
            // 
            this.DateGrid.ColumnCount = 7;
            this.DateGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.DateGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.DateGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.DateGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.DateGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.DateGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.DateGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.DateGrid.Location = new System.Drawing.Point(159, 144);
            this.DateGrid.Name = "DateGrid";
            this.DateGrid.RowCount = 5;
            this.DateGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.DateGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.DateGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.DateGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.DateGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.DateGrid.Size = new System.Drawing.Size(315, 228);
            this.DateGrid.TabIndex = 9;
            // 
            // Next
            // 
            this.Next.AutoSize = true;
            this.Next.Location = new System.Drawing.Point(449, 99);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(25, 23);
            this.Next.TabIndex = 12;
            this.Next.Text = ">";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Previuos
            // 
            this.Previuos.AutoSize = true;
            this.Previuos.Location = new System.Drawing.Point(159, 99);
            this.Previuos.Name = "Previuos";
            this.Previuos.Size = new System.Drawing.Size(25, 23);
            this.Previuos.TabIndex = 13;
            this.Previuos.Text = "<";
            this.Previuos.UseVisualStyleBackColor = true;
            this.Previuos.Click += new System.EventHandler(this.Previous_Click);
            // 
            // CurrentDate
            // 
            this.CurrentDate.AutoSize = true;
            this.CurrentDate.FlatAppearance.BorderSize = 0;
            this.CurrentDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CurrentDate.Location = new System.Drawing.Point(266, 99);
            this.CurrentDate.Name = "CurrentDate";
            this.CurrentDate.Size = new System.Drawing.Size(88, 23);
            this.CurrentDate.TabIndex = 14;
            this.CurrentDate.Text = "Февраль 2022";
            this.CurrentDate.UseVisualStyleBackColor = true;
            this.CurrentDate.Click += new System.EventHandler(this.CurrentDate_Click);
            // 
            // OpenDateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(654, 502);
            this.Controls.Add(this.CurrentDate);
            this.Controls.Add(this.Previuos);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.DateGrid);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "OpenDateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Дневник настроения";
            //this.VisibleChanged += new System.EventHandler(this.OpenDialog_Shown);
            this.Shown += new System.EventHandler(this.OpenDialog_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TableLayoutPanel DateGrid;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Previuos;
        private System.Windows.Forms.Button CurrentDate;
    }
}