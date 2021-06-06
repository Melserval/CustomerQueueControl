
namespace Breackfast_for_Lamberjack
{
	partial class Form1
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
			this.label_lamberjackName = new System.Windows.Forms.Label();
			this.textBox_lamberjackName = new System.Windows.Forms.TextBox();
			this.button_addLamberjack = new System.Windows.Forms.Button();
			this.listBox_breakfastLine = new System.Windows.Forms.ListBox();
			this.label_breakfastLine = new System.Windows.Forms.Label();
			this.button_nextLamberjack = new System.Windows.Forms.Button();
			this.textBox_hasFlatjack = new System.Windows.Forms.TextBox();
			this.groupBox_buttonSetCount = new System.Windows.Forms.GroupBox();
			this.button_foodNum5 = new System.Windows.Forms.Button();
			this.button_foodNum4 = new System.Windows.Forms.Button();
			this.button_foodNum3 = new System.Windows.Forms.Button();
			this.button_foodNum2 = new System.Windows.Forms.Button();
			this.button_foodNum1 = new System.Windows.Forms.Button();
			this.listBox_orderState = new System.Windows.Forms.ListBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button_addFoodCount = new System.Windows.Forms.Button();
			this.button_removeFoodCount = new System.Windows.Forms.Button();
			this.label_menu = new System.Windows.Forms.Label();
			this.label_quantity = new System.Windows.Forms.Label();
			this.listBox_menu = new System.Windows.Forms.ListBox();
			this.label_currentCustomer = new System.Windows.Forms.Label();
			this.textBox_descriptionMenuItem = new System.Windows.Forms.TextBox();
			this.button_loadMenu = new System.Windows.Forms.Button();
			this.button_loadCustomer = new System.Windows.Forms.Button();
			this.openFileDialog_menu = new System.Windows.Forms.OpenFileDialog();
			this.openFileDialog_customer = new System.Windows.Forms.OpenFileDialog();
			this.groupBox_buttonSetCount.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label_lamberjackName
			// 
			this.label_lamberjackName.AutoSize = true;
			this.label_lamberjackName.Location = new System.Drawing.Point(12, 9);
			this.label_lamberjackName.Name = "label_lamberjackName";
			this.label_lamberjackName.Size = new System.Drawing.Size(91, 13);
			this.label_lamberjackName.TabIndex = 4;
			this.label_lamberjackName.Text = "Lamberjack name";
			// 
			// textBox_lamberjackName
			// 
			this.textBox_lamberjackName.Location = new System.Drawing.Point(12, 25);
			this.textBox_lamberjackName.Name = "textBox_lamberjackName";
			this.textBox_lamberjackName.Size = new System.Drawing.Size(152, 20);
			this.textBox_lamberjackName.TabIndex = 5;
			this.textBox_lamberjackName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_lamberjackName_KeyUp);
			// 
			// button_addLamberjack
			// 
			this.button_addLamberjack.Location = new System.Drawing.Point(170, 21);
			this.button_addLamberjack.Name = "button_addLamberjack";
			this.button_addLamberjack.Size = new System.Drawing.Size(159, 26);
			this.button_addLamberjack.TabIndex = 6;
			this.button_addLamberjack.Text = "Add Lamberjack";
			this.button_addLamberjack.UseVisualStyleBackColor = true;
			this.button_addLamberjack.Click += new System.EventHandler(this.button_addLamberjack_Click);
			// 
			// listBox_breakfastLine
			// 
			this.listBox_breakfastLine.FormattingEnabled = true;
			this.listBox_breakfastLine.Location = new System.Drawing.Point(17, 76);
			this.listBox_breakfastLine.Name = "listBox_breakfastLine";
			this.listBox_breakfastLine.Size = new System.Drawing.Size(132, 186);
			this.listBox_breakfastLine.TabIndex = 7;
			// 
			// label_breakfastLine
			// 
			this.label_breakfastLine.AutoSize = true;
			this.label_breakfastLine.Location = new System.Drawing.Point(37, 60);
			this.label_breakfastLine.Name = "label_breakfastLine";
			this.label_breakfastLine.Size = new System.Drawing.Size(75, 13);
			this.label_breakfastLine.TabIndex = 8;
			this.label_breakfastLine.Text = "Breakfast Line";
			// 
			// button_nextLamberjack
			// 
			this.button_nextLamberjack.Enabled = false;
			this.button_nextLamberjack.Location = new System.Drawing.Point(16, 351);
			this.button_nextLamberjack.Name = "button_nextLamberjack";
			this.button_nextLamberjack.Size = new System.Drawing.Size(316, 35);
			this.button_nextLamberjack.TabIndex = 13;
			this.button_nextLamberjack.Text = "Next lamberjack";
			this.button_nextLamberjack.UseVisualStyleBackColor = true;
			this.button_nextLamberjack.Click += new System.EventHandler(this.button_nextLamberjack_Click);
			// 
			// textBox_hasFlatjack
			// 
			this.textBox_hasFlatjack.HideSelection = false;
			this.textBox_hasFlatjack.Location = new System.Drawing.Point(17, 269);
			this.textBox_hasFlatjack.Multiline = true;
			this.textBox_hasFlatjack.Name = "textBox_hasFlatjack";
			this.textBox_hasFlatjack.ReadOnly = true;
			this.textBox_hasFlatjack.Size = new System.Drawing.Size(132, 70);
			this.textBox_hasFlatjack.TabIndex = 14;
			this.textBox_hasFlatjack.TabStop = false;
			this.textBox_hasFlatjack.WordWrap = false;
			// 
			// groupBox_buttonSetCount
			// 
			this.groupBox_buttonSetCount.Controls.Add(this.button_foodNum5);
			this.groupBox_buttonSetCount.Controls.Add(this.button_foodNum4);
			this.groupBox_buttonSetCount.Controls.Add(this.button_foodNum3);
			this.groupBox_buttonSetCount.Controls.Add(this.button_foodNum2);
			this.groupBox_buttonSetCount.Controls.Add(this.button_foodNum1);
			this.groupBox_buttonSetCount.Enabled = false;
			this.groupBox_buttonSetCount.Location = new System.Drawing.Point(156, 71);
			this.groupBox_buttonSetCount.Name = "groupBox_buttonSetCount";
			this.groupBox_buttonSetCount.Size = new System.Drawing.Size(36, 130);
			this.groupBox_buttonSetCount.TabIndex = 16;
			this.groupBox_buttonSetCount.TabStop = false;
			// 
			// button_foodNum5
			// 
			this.button_foodNum5.Location = new System.Drawing.Point(3, 104);
			this.button_foodNum5.Name = "button_foodNum5";
			this.button_foodNum5.Size = new System.Drawing.Size(30, 23);
			this.button_foodNum5.TabIndex = 4;
			this.button_foodNum5.Tag = "5";
			this.button_foodNum5.Text = "5";
			this.button_foodNum5.UseVisualStyleBackColor = true;
			this.button_foodNum5.Click += new System.EventHandler(this.button_foodNum_addFlapjack_Click);
			// 
			// button_foodNum4
			// 
			this.button_foodNum4.Location = new System.Drawing.Point(3, 80);
			this.button_foodNum4.Name = "button_foodNum4";
			this.button_foodNum4.Size = new System.Drawing.Size(30, 23);
			this.button_foodNum4.TabIndex = 3;
			this.button_foodNum4.Tag = "4";
			this.button_foodNum4.Text = "4";
			this.button_foodNum4.UseVisualStyleBackColor = true;
			this.button_foodNum4.Click += new System.EventHandler(this.button_foodNum_addFlapjack_Click);
			// 
			// button_foodNum3
			// 
			this.button_foodNum3.Location = new System.Drawing.Point(3, 56);
			this.button_foodNum3.Name = "button_foodNum3";
			this.button_foodNum3.Size = new System.Drawing.Size(30, 23);
			this.button_foodNum3.TabIndex = 2;
			this.button_foodNum3.Tag = "3";
			this.button_foodNum3.Text = "3";
			this.button_foodNum3.UseVisualStyleBackColor = true;
			this.button_foodNum3.Click += new System.EventHandler(this.button_foodNum_addFlapjack_Click);
			// 
			// button_foodNum2
			// 
			this.button_foodNum2.Location = new System.Drawing.Point(3, 32);
			this.button_foodNum2.Name = "button_foodNum2";
			this.button_foodNum2.Size = new System.Drawing.Size(30, 23);
			this.button_foodNum2.TabIndex = 1;
			this.button_foodNum2.Tag = "2";
			this.button_foodNum2.Text = "2";
			this.button_foodNum2.UseVisualStyleBackColor = true;
			this.button_foodNum2.Click += new System.EventHandler(this.button_foodNum_addFlapjack_Click);
			// 
			// button_foodNum1
			// 
			this.button_foodNum1.Location = new System.Drawing.Point(3, 9);
			this.button_foodNum1.Name = "button_foodNum1";
			this.button_foodNum1.Size = new System.Drawing.Size(30, 23);
			this.button_foodNum1.TabIndex = 0;
			this.button_foodNum1.Tag = "1";
			this.button_foodNum1.Text = "1";
			this.button_foodNum1.UseVisualStyleBackColor = true;
			this.button_foodNum1.Click += new System.EventHandler(this.button_foodNum_addFlapjack_Click);
			// 
			// listBox_orderState
			// 
			this.listBox_orderState.FormattingEnabled = true;
			this.listBox_orderState.Location = new System.Drawing.Point(159, 270);
			this.listBox_orderState.Name = "listBox_orderState";
			this.listBox_orderState.Size = new System.Drawing.Size(132, 69);
			this.listBox_orderState.TabIndex = 17;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button_addFoodCount);
			this.groupBox2.Controls.Add(this.button_removeFoodCount);
			this.groupBox2.Location = new System.Drawing.Point(295, 264);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(37, 76);
			this.groupBox2.TabIndex = 18;
			this.groupBox2.TabStop = false;
			// 
			// button_addFoodCount
			// 
			this.button_addFoodCount.Location = new System.Drawing.Point(4, 10);
			this.button_addFoodCount.Name = "button_addFoodCount";
			this.button_addFoodCount.Size = new System.Drawing.Size(27, 27);
			this.button_addFoodCount.TabIndex = 1;
			this.button_addFoodCount.Text = "+";
			this.button_addFoodCount.UseVisualStyleBackColor = true;
			this.button_addFoodCount.Click += new System.EventHandler(this.button_addFoodCount_Click);
			// 
			// button_removeFoodCount
			// 
			this.button_removeFoodCount.Location = new System.Drawing.Point(4, 43);
			this.button_removeFoodCount.Name = "button_removeFoodCount";
			this.button_removeFoodCount.Size = new System.Drawing.Size(27, 27);
			this.button_removeFoodCount.TabIndex = 0;
			this.button_removeFoodCount.Text = "-";
			this.button_removeFoodCount.UseVisualStyleBackColor = true;
			this.button_removeFoodCount.Click += new System.EventHandler(this.button_removeFoodCount_Click);
			// 
			// label_menu
			// 
			this.label_menu.AutoSize = true;
			this.label_menu.Location = new System.Drawing.Point(243, 61);
			this.label_menu.Name = "label_menu";
			this.label_menu.Size = new System.Drawing.Size(34, 13);
			this.label_menu.TabIndex = 19;
			this.label_menu.Text = "Menu";
			// 
			// label_quantity
			// 
			this.label_quantity.AutoSize = true;
			this.label_quantity.Location = new System.Drawing.Point(155, 60);
			this.label_quantity.Name = "label_quantity";
			this.label_quantity.Size = new System.Drawing.Size(46, 13);
			this.label_quantity.TabIndex = 20;
			this.label_quantity.Text = "Quantity";
			// 
			// listBox_menu
			// 
			this.listBox_menu.Enabled = false;
			this.listBox_menu.FormattingEnabled = true;
			this.listBox_menu.Location = new System.Drawing.Point(200, 78);
			this.listBox_menu.Name = "listBox_menu";
			this.listBox_menu.Size = new System.Drawing.Size(129, 121);
			this.listBox_menu.TabIndex = 23;
			this.listBox_menu.SelectedIndexChanged += new System.EventHandler(this.listBox_menu_SelectedIndexChanged);
			// 
			// label_currentCustomer
			// 
			this.label_currentCustomer.AutoSize = true;
			this.label_currentCustomer.Location = new System.Drawing.Point(186, 254);
			this.label_currentCustomer.MaximumSize = new System.Drawing.Size(200, 22);
			this.label_currentCustomer.Name = "label_currentCustomer";
			this.label_currentCustomer.Size = new System.Drawing.Size(113, 13);
			this.label_currentCustomer.TabIndex = 24;
			this.label_currentCustomer.Text = "Чрезвычано важный";
			this.label_currentCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox_descriptionMenuItem
			// 
			this.textBox_descriptionMenuItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_descriptionMenuItem.Location = new System.Drawing.Point(157, 212);
			this.textBox_descriptionMenuItem.Multiline = true;
			this.textBox_descriptionMenuItem.Name = "textBox_descriptionMenuItem";
			this.textBox_descriptionMenuItem.Size = new System.Drawing.Size(173, 34);
			this.textBox_descriptionMenuItem.TabIndex = 28;
			this.textBox_descriptionMenuItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// button_loadMenu
			// 
			this.button_loadMenu.Location = new System.Drawing.Point(12, 441);
			this.button_loadMenu.Name = "button_loadMenu";
			this.button_loadMenu.Size = new System.Drawing.Size(75, 23);
			this.button_loadMenu.TabIndex = 29;
			this.button_loadMenu.Text = "Load Menu";
			this.button_loadMenu.UseVisualStyleBackColor = true;
			this.button_loadMenu.Click += new System.EventHandler(this.button_loadMenu_Click);
			// 
			// button_loadCustomer
			// 
			this.button_loadCustomer.Location = new System.Drawing.Point(104, 441);
			this.button_loadCustomer.Name = "button_loadCustomer";
			this.button_loadCustomer.Size = new System.Drawing.Size(75, 23);
			this.button_loadCustomer.TabIndex = 30;
			this.button_loadCustomer.Text = "Load Cust";
			this.button_loadCustomer.UseVisualStyleBackColor = true;
			this.button_loadCustomer.Click += new System.EventHandler(this.button_loadCustomer_Click);
			// 
			// openFileDialog_menu
			// 
			this.openFileDialog_menu.FileName = "openFileDialog1";
			// 
			// openFileDialog_customer
			// 
			this.openFileDialog_customer.FileName = "openFileDialog1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(342, 476);
			this.Controls.Add(this.button_loadCustomer);
			this.Controls.Add(this.button_loadMenu);
			this.Controls.Add(this.label_currentCustomer);
			this.Controls.Add(this.textBox_descriptionMenuItem);
			this.Controls.Add(this.listBox_menu);
			this.Controls.Add(this.label_quantity);
			this.Controls.Add(this.label_menu);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.listBox_orderState);
			this.Controls.Add(this.groupBox_buttonSetCount);
			this.Controls.Add(this.textBox_hasFlatjack);
			this.Controls.Add(this.button_nextLamberjack);
			this.Controls.Add(this.label_breakfastLine);
			this.Controls.Add(this.listBox_breakfastLine);
			this.Controls.Add(this.button_addLamberjack);
			this.Controls.Add(this.textBox_lamberjackName);
			this.Controls.Add(this.label_lamberjackName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.ShowIcon = false;
			this.Text = "Breakfast for Lamberjack";
			this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
			this.groupBox_buttonSetCount.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label_lamberjackName;
		private System.Windows.Forms.TextBox textBox_lamberjackName;
		private System.Windows.Forms.Button button_addLamberjack;
		private System.Windows.Forms.ListBox listBox_breakfastLine;
		private System.Windows.Forms.Label label_breakfastLine;
		private System.Windows.Forms.Button button_nextLamberjack;
		private System.Windows.Forms.TextBox textBox_hasFlatjack;
		private System.Windows.Forms.GroupBox groupBox_buttonSetCount;
		private System.Windows.Forms.Button button_foodNum5;
		private System.Windows.Forms.Button button_foodNum4;
		private System.Windows.Forms.Button button_foodNum3;
		private System.Windows.Forms.Button button_foodNum2;
		private System.Windows.Forms.Button button_foodNum1;
		private System.Windows.Forms.ListBox listBox_orderState;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button button_addFoodCount;
		private System.Windows.Forms.Button button_removeFoodCount;
		private System.Windows.Forms.Label label_menu;
		private System.Windows.Forms.Label label_quantity;
		private System.Windows.Forms.ListBox listBox_menu;
		private System.Windows.Forms.Label label_currentCustomer;
		private System.Windows.Forms.TextBox textBox_descriptionMenuItem;
		private System.Windows.Forms.Button button_loadMenu;
		private System.Windows.Forms.Button button_loadCustomer;
		private System.Windows.Forms.OpenFileDialog openFileDialog_menu;
		private System.Windows.Forms.OpenFileDialog openFileDialog_customer;
	}
}

