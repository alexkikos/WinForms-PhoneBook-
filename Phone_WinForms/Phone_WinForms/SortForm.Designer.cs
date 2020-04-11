namespace Phone_WinForms
{
	partial class SortForm
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbHeight = new System.Windows.Forms.RadioButton();
			this.rbWidth = new System.Windows.Forms.RadioButton();
			this.rbColor = new System.Windows.Forms.RadioButton();
			this.rbPrice = new System.Windows.Forms.RadioButton();
			this.RBproducer = new System.Windows.Forms.RadioButton();
			this.rbName = new System.Windows.Forms.RadioButton();
			this.btnDone = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Yellow;
			this.groupBox1.Controls.Add(this.rbHeight);
			this.groupBox1.Controls.Add(this.rbWidth);
			this.groupBox1.Controls.Add(this.rbColor);
			this.groupBox1.Controls.Add(this.rbPrice);
			this.groupBox1.Controls.Add(this.RBproducer);
			this.groupBox1.Controls.Add(this.rbName);
			this.groupBox1.Font = new System.Drawing.Font("Minion Pro Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.groupBox1.Location = new System.Drawing.Point(31, 25);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(195, 266);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Сортировка";
			this.groupBox1.UseCompatibleTextRendering = true;
			// 
			// rbHeight
			// 
			this.rbHeight.AutoSize = true;
			this.rbHeight.Location = new System.Drawing.Point(24, 206);
			this.rbHeight.Name = "rbHeight";
			this.rbHeight.Size = new System.Drawing.Size(82, 28);
			this.rbHeight.TabIndex = 7;
			this.rbHeight.TabStop = true;
			this.rbHeight.Tag = "6";
			this.rbHeight.Text = "Высоте";
			this.rbHeight.UseVisualStyleBackColor = true;
			this.rbHeight.CheckedChanged += new System.EventHandler(this.rbHeight_CheckedChanged);
			// 
			// rbWidth
			// 
			this.rbWidth.AutoSize = true;
			this.rbWidth.Location = new System.Drawing.Point(24, 172);
			this.rbWidth.Name = "rbWidth";
			this.rbWidth.Size = new System.Drawing.Size(91, 28);
			this.rbWidth.TabIndex = 6;
			this.rbWidth.TabStop = true;
			this.rbWidth.Tag = "5";
			this.rbWidth.Text = "Ширине";
			this.rbWidth.UseVisualStyleBackColor = true;
			this.rbWidth.CheckedChanged += new System.EventHandler(this.rbHeight_CheckedChanged);
			// 
			// rbColor
			// 
			this.rbColor.AutoSize = true;
			this.rbColor.Location = new System.Drawing.Point(24, 138);
			this.rbColor.Name = "rbColor";
			this.rbColor.Size = new System.Drawing.Size(74, 28);
			this.rbColor.TabIndex = 5;
			this.rbColor.TabStop = true;
			this.rbColor.Tag = "4";
			this.rbColor.Text = "Цвету";
			this.rbColor.UseVisualStyleBackColor = true;
			this.rbColor.CheckedChanged += new System.EventHandler(this.rbHeight_CheckedChanged);
			// 
			// rbPrice
			// 
			this.rbPrice.AutoSize = true;
			this.rbPrice.Location = new System.Drawing.Point(24, 104);
			this.rbPrice.Name = "rbPrice";
			this.rbPrice.Size = new System.Drawing.Size(66, 28);
			this.rbPrice.TabIndex = 3;
			this.rbPrice.TabStop = true;
			this.rbPrice.Tag = "3";
			this.rbPrice.Text = "Цене";
			this.rbPrice.UseVisualStyleBackColor = true;
			this.rbPrice.CheckedChanged += new System.EventHandler(this.rbHeight_CheckedChanged);
			// 
			// RBproducer
			// 
			this.RBproducer.AutoSize = true;
			this.RBproducer.Location = new System.Drawing.Point(24, 70);
			this.RBproducer.Name = "RBproducer";
			this.RBproducer.Size = new System.Drawing.Size(148, 28);
			this.RBproducer.TabIndex = 2;
			this.RBproducer.TabStop = true;
			this.RBproducer.Tag = "2";
			this.RBproducer.Text = "Производителю";
			this.RBproducer.UseVisualStyleBackColor = true;
			this.RBproducer.CheckedChanged += new System.EventHandler(this.rbHeight_CheckedChanged);
			// 
			// rbName
			// 
			this.rbName.AutoSize = true;
			this.rbName.Location = new System.Drawing.Point(24, 36);
			this.rbName.Name = "rbName";
			this.rbName.Size = new System.Drawing.Size(105, 28);
			this.rbName.TabIndex = 0;
			this.rbName.TabStop = true;
			this.rbName.Tag = "1";
			this.rbName.Text = "Названию";
			this.rbName.UseVisualStyleBackColor = true;
			this.rbName.CheckedChanged += new System.EventHandler(this.rbHeight_CheckedChanged);
			// 
			// btnDone
			// 
			this.btnDone.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnDone.Location = new System.Drawing.Point(55, 314);
			this.btnDone.Name = "btnDone";
			this.btnDone.Size = new System.Drawing.Size(129, 33);
			this.btnDone.TabIndex = 1;
			this.btnDone.Text = "Выполнить";
			this.btnDone.UseVisualStyleBackColor = true;
			this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
			// 
			// SortForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.YellowGreen;
			this.ClientSize = new System.Drawing.Size(256, 371);
			this.Controls.Add(this.btnDone);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "SortForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Tag = "1";
			this.Text = "SortForm";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbName;
		private System.Windows.Forms.RadioButton rbPrice;
		private System.Windows.Forms.RadioButton RBproducer;
		private System.Windows.Forms.RadioButton rbColor;
		private System.Windows.Forms.RadioButton rbWidth;
		private System.Windows.Forms.RadioButton rbHeight;
		private System.Windows.Forms.Button btnDone;
	}
}