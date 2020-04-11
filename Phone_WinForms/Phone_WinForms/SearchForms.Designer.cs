namespace Phone_WinForms
{
	partial class SearchForms
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
			this.rbProducer = new System.Windows.Forms.RadioButton();
			this.rbWidth = new System.Windows.Forms.RadioButton();
			this.rbHeight = new System.Windows.Forms.RadioButton();
			this.rbColor = new System.Windows.Forms.RadioButton();
			this.rbPrice = new System.Windows.Forms.RadioButton();
			this.rbName = new System.Windows.Forms.RadioButton();
			this.txbSearchText = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbProducer);
			this.groupBox1.Controls.Add(this.rbWidth);
			this.groupBox1.Controls.Add(this.rbHeight);
			this.groupBox1.Controls.Add(this.rbColor);
			this.groupBox1.Controls.Add(this.rbPrice);
			this.groupBox1.Controls.Add(this.rbName);
			this.groupBox1.Font = new System.Drawing.Font("Minion", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox1.Location = new System.Drawing.Point(12, 71);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(210, 218);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Группа поиска";
			// 
			// rbProducer
			// 
			this.rbProducer.AutoSize = true;
			this.rbProducer.Location = new System.Drawing.Point(22, 117);
			this.rbProducer.Name = "rbProducer";
			this.rbProducer.Size = new System.Drawing.Size(152, 26);
			this.rbProducer.TabIndex = 5;
			this.rbProducer.Tag = "4";
			this.rbProducer.Text = "Изготовитель";
			this.rbProducer.UseVisualStyleBackColor = true;
			this.rbProducer.CheckedChanged += new System.EventHandler(this.rbPrice_CheckedChanged);
			// 
			// rbWidth
			// 
			this.rbWidth.AutoSize = true;
			this.rbWidth.Location = new System.Drawing.Point(22, 149);
			this.rbWidth.Name = "rbWidth";
			this.rbWidth.Size = new System.Drawing.Size(104, 26);
			this.rbWidth.TabIndex = 4;
			this.rbWidth.Tag = "5";
			this.rbWidth.Text = "Ширина";
			this.rbWidth.UseVisualStyleBackColor = true;
			this.rbWidth.CheckedChanged += new System.EventHandler(this.rbPrice_CheckedChanged);
			// 
			// rbHeight
			// 
			this.rbHeight.AutoSize = true;
			this.rbHeight.Location = new System.Drawing.Point(22, 181);
			this.rbHeight.Name = "rbHeight";
			this.rbHeight.Size = new System.Drawing.Size(93, 26);
			this.rbHeight.TabIndex = 3;
			this.rbHeight.Tag = "6";
			this.rbHeight.Text = "Высота";
			this.rbHeight.UseVisualStyleBackColor = true;
			this.rbHeight.CheckedChanged += new System.EventHandler(this.rbPrice_CheckedChanged);
			// 
			// rbColor
			// 
			this.rbColor.AutoSize = true;
			this.rbColor.Location = new System.Drawing.Point(22, 85);
			this.rbColor.Name = "rbColor";
			this.rbColor.Size = new System.Drawing.Size(72, 26);
			this.rbColor.TabIndex = 2;
			this.rbColor.Tag = "3";
			this.rbColor.Text = "Цвет";
			this.rbColor.UseVisualStyleBackColor = true;
			this.rbColor.CheckedChanged += new System.EventHandler(this.rbPrice_CheckedChanged);
			// 
			// rbPrice
			// 
			this.rbPrice.AutoSize = true;
			this.rbPrice.Location = new System.Drawing.Point(22, 58);
			this.rbPrice.Name = "rbPrice";
			this.rbPrice.Size = new System.Drawing.Size(74, 26);
			this.rbPrice.TabIndex = 1;
			this.rbPrice.Tag = "2";
			this.rbPrice.Text = "Цена";
			this.rbPrice.UseVisualStyleBackColor = true;
			this.rbPrice.CheckedChanged += new System.EventHandler(this.rbPrice_CheckedChanged);
			// 
			// rbName
			// 
			this.rbName.AutoSize = true;
			this.rbName.Checked = true;
			this.rbName.Location = new System.Drawing.Point(22, 30);
			this.rbName.Name = "rbName";
			this.rbName.Size = new System.Drawing.Size(68, 26);
			this.rbName.TabIndex = 0;
			this.rbName.TabStop = true;
			this.rbName.Tag = "1";
			this.rbName.Text = "Имя";
			this.rbName.UseVisualStyleBackColor = true;
			this.rbName.CheckedChanged += new System.EventHandler(this.rbPrice_CheckedChanged);
			// 
			// txbSearchText
			// 
			this.txbSearchText.Font = new System.Drawing.Font("Minion", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txbSearchText.Location = new System.Drawing.Point(10, 34);
			this.txbSearchText.Name = "txbSearchText";
			this.txbSearchText.Size = new System.Drawing.Size(300, 31);
			this.txbSearchText.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Minion", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(60, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(182, 22);
			this.label1.TabIndex = 3;
			this.label1.Text = "Поисковый запрос";
			// 
			// btnSearch
			// 
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSearch.Location = new System.Drawing.Point(235, 148);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 41);
			this.btnSearch.TabIndex = 4;
			this.btnSearch.Text = "Найти";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// SearchForms
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.ClientSize = new System.Drawing.Size(321, 312);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txbSearchText);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "SearchForms";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Tag = "1";
			this.Text = "SearchForms";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.RadioButton rbColor;
		internal System.Windows.Forms.RadioButton rbPrice;
		private System.Windows.Forms.RadioButton rbName;
		private System.Windows.Forms.RadioButton rbProducer;
		private System.Windows.Forms.RadioButton rbWidth;
		private System.Windows.Forms.RadioButton rbHeight;
		internal System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txbSearchText;
	}
}