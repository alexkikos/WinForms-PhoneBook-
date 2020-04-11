namespace Phone_WinForms
{
	partial class AddPhone
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
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.TXBproducer = new System.Windows.Forms.TextBox();
			this.TXBname = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txbColor = new System.Windows.Forms.TextBox();
			this.TBXcolor = new System.Windows.Forms.Label();
			this.TBXheight = new System.Windows.Forms.TextBox();
			this.TXBheight = new System.Windows.Forms.Label();
			this.TBXwidth = new System.Windows.Forms.TextBox();
			this.TXBwidth = new System.Windows.Forms.Label();
			this.TXBprice = new System.Windows.Forms.MaskedTextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Silver;
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Enabled = false;
			this.button1.Font = new System.Drawing.Font("Minion Pro Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(163, 329);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(99, 30);
			this.button1.TabIndex = 7;
			this.button1.Text = "Сохранить";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Minion Pro Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(30, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(126, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "Производитель";
			// 
			// TXBproducer
			// 
			this.TXBproducer.Font = new System.Drawing.Font("Minion Pro Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TXBproducer.Location = new System.Drawing.Point(163, 20);
			this.TXBproducer.Name = "TXBproducer";
			this.TXBproducer.Size = new System.Drawing.Size(247, 32);
			this.TXBproducer.TabIndex = 1;
			// 
			// TXBname
			// 
			this.TXBname.Font = new System.Drawing.Font("Minion Pro Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TXBname.Location = new System.Drawing.Point(163, 69);
			this.TXBname.Name = "TXBname";
			this.TXBname.Size = new System.Drawing.Size(247, 32);
			this.TXBname.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Minion Pro Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(144, 24);
			this.label2.TabIndex = 3;
			this.label2.Text = "Марка(Название)";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Minion Pro Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(107, 126);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 24);
			this.label3.TabIndex = 5;
			this.label3.Text = "Цена";
			// 
			// txbColor
			// 
			this.txbColor.Font = new System.Drawing.Font("Minion Pro Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txbColor.Location = new System.Drawing.Point(163, 170);
			this.txbColor.Name = "txbColor";
			this.txbColor.Size = new System.Drawing.Size(247, 32);
			this.txbColor.TabIndex = 4;
			// 
			// TBXcolor
			// 
			this.TBXcolor.AutoSize = true;
			this.TBXcolor.Font = new System.Drawing.Font("Minion Pro Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TBXcolor.Location = new System.Drawing.Point(108, 178);
			this.TBXcolor.Name = "TBXcolor";
			this.TBXcolor.Size = new System.Drawing.Size(47, 24);
			this.TBXcolor.TabIndex = 7;
			this.TBXcolor.Text = "Цвет";
			// 
			// TBXheight
			// 
			this.TBXheight.Font = new System.Drawing.Font("Minion Pro Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TBXheight.Location = new System.Drawing.Point(163, 217);
			this.TBXheight.Name = "TBXheight";
			this.TBXheight.Size = new System.Drawing.Size(247, 32);
			this.TBXheight.TabIndex = 5;
			// 
			// TXBheight
			// 
			this.TXBheight.AutoSize = true;
			this.TXBheight.Font = new System.Drawing.Font("Minion Pro Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TXBheight.Location = new System.Drawing.Point(91, 225);
			this.TXBheight.Name = "TXBheight";
			this.TXBheight.Size = new System.Drawing.Size(64, 24);
			this.TXBheight.TabIndex = 9;
			this.TXBheight.Text = "Высота";
			// 
			// TBXwidth
			// 
			this.TBXwidth.Font = new System.Drawing.Font("Minion Pro Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TBXwidth.Location = new System.Drawing.Point(163, 262);
			this.TBXwidth.Name = "TBXwidth";
			this.TBXwidth.Size = new System.Drawing.Size(247, 32);
			this.TBXwidth.TabIndex = 6;
			this.TBXwidth.Leave += new System.EventHandler(this.TBXwidth_Leave);
			// 
			// TXBwidth
			// 
			this.TXBwidth.AutoSize = true;
			this.TXBwidth.Font = new System.Drawing.Font("Minion Pro Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TXBwidth.Location = new System.Drawing.Point(82, 270);
			this.TXBwidth.Name = "TXBwidth";
			this.TXBwidth.Size = new System.Drawing.Size(73, 24);
			this.TXBwidth.TabIndex = 11;
			this.TXBwidth.Text = "Ширина";
			// 
			// TXBprice
			// 
			this.TXBprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TXBprice.Location = new System.Drawing.Point(163, 121);
			this.TXBprice.Mask = "0000.00";
			this.TXBprice.Name = "TXBprice";
			this.TXBprice.Size = new System.Drawing.Size(247, 29);
			this.TXBprice.TabIndex = 3;
			// 
			// AddPhone
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(422, 391);
			this.Controls.Add(this.TXBprice);
			this.Controls.Add(this.TBXwidth);
			this.Controls.Add(this.TXBwidth);
			this.Controls.Add(this.TBXheight);
			this.Controls.Add(this.TXBheight);
			this.Controls.Add(this.txbColor);
			this.Controls.Add(this.TBXcolor);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.TXBname);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.TXBproducer);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "AddPhone";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddPhone";
			this.Load += new System.EventHandler(this.AddPhone_Load);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddPhone_MouseMove);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label TBXcolor;
		private System.Windows.Forms.Label TXBheight;
		private System.Windows.Forms.Label TXBwidth;
		private System.Windows.Forms.TextBox TXBproducer;
		private System.Windows.Forms.TextBox TXBname;
		private System.Windows.Forms.TextBox txbColor;
		private System.Windows.Forms.TextBox TBXheight;
		private System.Windows.Forms.MaskedTextBox TXBprice;
		private System.Windows.Forms.TextBox TBXwidth;
	}
}