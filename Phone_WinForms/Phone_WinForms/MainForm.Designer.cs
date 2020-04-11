namespace Phone_WinForms
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.btnLoad = new System.Windows.Forms.Button();
			this.BtnAddPhone = new System.Windows.Forms.Button();
			this.btnDel = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.DateTimer = new System.Windows.Forms.Timer(this.components);
			this.LBLuptime = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.btnSort = new System.Windows.Forms.Button();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.btnexit = new System.Windows.Forms.Button();
			this.lstbLISTPHONE = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// btnLoad
			// 
			this.btnLoad.BackColor = System.Drawing.Color.DarkOrchid;
			this.btnLoad.BackgroundImage = global::Phone_WinForms.Properties.Resources.images;
			this.btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnLoad.Location = new System.Drawing.Point(12, 12);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(75, 35);
			this.btnLoad.TabIndex = 0;
			this.btnLoad.Text = "Загрузить данные";
			this.btnLoad.UseVisualStyleBackColor = false;
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// BtnAddPhone
			// 
			this.BtnAddPhone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BtnAddPhone.BackColor = System.Drawing.Color.Aquamarine;
			this.BtnAddPhone.BackgroundImage = global::Phone_WinForms.Properties.Resources._1;
			this.BtnAddPhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.BtnAddPhone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.BtnAddPhone.Location = new System.Drawing.Point(175, 12);
			this.BtnAddPhone.Name = "BtnAddPhone";
			this.BtnAddPhone.Size = new System.Drawing.Size(106, 34);
			this.BtnAddPhone.TabIndex = 1;
			this.BtnAddPhone.Text = "Добавить информацию";
			this.BtnAddPhone.UseVisualStyleBackColor = false;
			this.BtnAddPhone.Click += new System.EventHandler(this.BtnAddPhone_Click);
			// 
			// btnDel
			// 
			this.btnDel.BackColor = System.Drawing.Color.LightSkyBlue;
			this.btnDel.BackgroundImage = global::Phone_WinForms.Properties.Resources._1;
			this.btnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnDel.Location = new System.Drawing.Point(395, 12);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(75, 34);
			this.btnDel.TabIndex = 2;
			this.btnDel.Text = "Удалить данные";
			this.btnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnDel.UseVisualStyleBackColor = false;
			this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.BackColor = System.Drawing.Color.LightSkyBlue;
			this.btnEdit.BackgroundImage = global::Phone_WinForms.Properties.Resources._31828760_foto_eines_alten_tierhaut_pergament_zerknittert_grobkörnigen_gesprenkelt_ockergelb_vignette_grunge_text;
			this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnEdit.Location = new System.Drawing.Point(287, 12);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(102, 34);
			this.btnEdit.TabIndex = 3;
			this.btnEdit.Text = "Редактировать";
			this.btnEdit.UseVisualStyleBackColor = false;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnSave
			// 
			this.btnSave.BackgroundImage = global::Phone_WinForms.Properties.Resources._31828760_foto_eines_alten_tierhaut_pergament_zerknittert_grobkörnigen_gesprenkelt_ockergelb_vignette_grunge_text;
			this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSave.Location = new System.Drawing.Point(94, 13);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 34);
			this.btnSave.TabIndex = 5;
			this.btnSave.Text = "Сохранить";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.Color.MediumBlue;
			this.btnSearch.BackgroundImage = global::Phone_WinForms.Properties.Resources._1;
			this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSearch.Location = new System.Drawing.Point(476, 12);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 34);
			this.btnSearch.TabIndex = 6;
			this.btnSearch.Text = "Поиск";
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// DateTimer
			// 
			this.DateTimer.Enabled = true;
			this.DateTimer.Interval = 1000;
			this.DateTimer.Tick += new System.EventHandler(this.DateTime_Tick);
			// 
			// LBLuptime
			// 
			this.LBLuptime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.LBLuptime.AutoSize = true;
			this.LBLuptime.BackColor = System.Drawing.Color.White;
			this.LBLuptime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LBLuptime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LBLuptime.ForeColor = System.Drawing.Color.Maroon;
			this.LBLuptime.Location = new System.Drawing.Point(764, 429);
			this.LBLuptime.Name = "LBLuptime";
			this.LBLuptime.Size = new System.Drawing.Size(48, 16);
			this.LBLuptime.TabIndex = 0;
			this.LBLuptime.Text = "uptime";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.Yellow;
			this.label1.Location = new System.Drawing.Point(672, 430);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 15);
			this.label1.TabIndex = 7;
			this.label1.Text = "Время работы";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.dateTimePicker1.CustomFormat = "dd:MMM:hh:mm:ss";
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker1.Location = new System.Drawing.Point(466, 427);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 8;
			// 
			// btnSort
			// 
			this.btnSort.BackColor = System.Drawing.Color.HotPink;
			this.btnSort.BackgroundImage = global::Phone_WinForms.Properties.Resources._31828760_foto_eines_alten_tierhaut_pergament_zerknittert_grobkörnigen_gesprenkelt_ockergelb_vignette_grunge_text;
			this.btnSort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSort.Location = new System.Drawing.Point(557, 13);
			this.btnSort.Name = "btnSort";
			this.btnSort.Size = new System.Drawing.Size(78, 34);
			this.btnSort.TabIndex = 9;
			this.btnSort.Text = "Сортировка";
			this.btnSort.UseVisualStyleBackColor = false;
			this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
			// 
			// btnRefresh
			// 
			this.btnRefresh.BackColor = System.Drawing.Color.PaleVioletRed;
			this.btnRefresh.BackgroundImage = global::Phone_WinForms.Properties.Resources._31828760_foto_eines_alten_tierhaut_pergament_zerknittert_grobkörnigen_gesprenkelt_ockergelb_vignette_grunge_text;
			this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnRefresh.ForeColor = System.Drawing.Color.Maroon;
			this.btnRefresh.Location = new System.Drawing.Point(641, 13);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(72, 34);
			this.btnRefresh.TabIndex = 10;
			this.btnRefresh.Text = "Обновить";
			this.btnRefresh.UseVisualStyleBackColor = false;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// btnexit
			// 
			this.btnexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnexit.BackColor = System.Drawing.Color.Olive;
			this.btnexit.BackgroundImage = global::Phone_WinForms.Properties.Resources._1;
			this.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnexit.ForeColor = System.Drawing.Color.Black;
			this.btnexit.Location = new System.Drawing.Point(12, 427);
			this.btnexit.Name = "btnexit";
			this.btnexit.Size = new System.Drawing.Size(75, 23);
			this.btnexit.TabIndex = 11;
			this.btnexit.Text = "Выход";
			this.btnexit.UseVisualStyleBackColor = false;
			this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
			// 
			// lstbLISTPHONE
			// 
			this.lstbLISTPHONE.AllowDrop = true;
			this.lstbLISTPHONE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstbLISTPHONE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lstbLISTPHONE.FormattingEnabled = true;
			this.lstbLISTPHONE.HorizontalScrollbar = true;
			this.lstbLISTPHONE.ImeMode = System.Windows.Forms.ImeMode.On;
			this.lstbLISTPHONE.ItemHeight = 25;
			this.lstbLISTPHONE.Location = new System.Drawing.Point(12, 52);
			this.lstbLISTPHONE.Name = "lstbLISTPHONE";
			this.lstbLISTPHONE.ScrollAlwaysVisible = true;
			this.lstbLISTPHONE.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.lstbLISTPHONE.Size = new System.Drawing.Size(800, 354);
			this.lstbLISTPHONE.TabIndex = 12;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
			this.BackColor = System.Drawing.Color.Green;
			this.BackgroundImage = global::Phone_WinForms.Properties.Resources._1;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(824, 456);
			this.Controls.Add(this.lstbLISTPHONE);
			this.Controls.Add(this.btnexit);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.btnSort);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.LBLuptime);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnDel);
			this.Controls.Add(this.BtnAddPhone);
			this.Controls.Add(this.btnLoad);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PhoneList";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.Button BtnAddPhone;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnSearch;
		public System.Windows.Forms.Timer DateTimer;
		public System.Windows.Forms.Label LBLuptime;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Button btnSort;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.Button btnexit;
		private System.Windows.Forms.ListBox lstbLISTPHONE;
	}
}

