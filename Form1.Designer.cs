
namespace CustomerQueueControl
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
			this.label_customerName = new System.Windows.Forms.Label();
			this.textBox_customerName = new System.Windows.Forms.TextBox();
			this.button_addCustomer = new System.Windows.Forms.Button();
			this.listBox_customerLine = new System.Windows.Forms.ListBox();
			this.label_customerLine = new System.Windows.Forms.Label();
			this.button_nextLamberjack = new System.Windows.Forms.Button();
			this.textBox_hasFlatjack = new System.Windows.Forms.TextBox();
			this.groupBox_buttonSetCount = new System.Windows.Forms.GroupBox();
			this.button_removeFoodCount = new System.Windows.Forms.Button();
			this.button_addFoodCount = new System.Windows.Forms.Button();
			this.button_foodNum5 = new System.Windows.Forms.Button();
			this.button_foodNum4 = new System.Windows.Forms.Button();
			this.button_foodNum3 = new System.Windows.Forms.Button();
			this.button_foodNum2 = new System.Windows.Forms.Button();
			this.button_foodNum1 = new System.Windows.Forms.Button();
			this.listBox_orderState = new System.Windows.Forms.ListBox();
			this.label_menu = new System.Windows.Forms.Label();
			this.label_quantity = new System.Windows.Forms.Label();
			this.listBox_menu = new System.Windows.Forms.ListBox();
			this.label_currentCustomer = new System.Windows.Forms.Label();
			this.textBox_descriptionMenuItem = new System.Windows.Forms.TextBox();
			this.button_loadMenu = new System.Windows.Forms.Button();
			this.button_loadCustomer = new System.Windows.Forms.Button();
			this.openFileDialog_menu = new System.Windows.Forms.OpenFileDialog();
			this.openFileDialog_customer = new System.Windows.Forms.OpenFileDialog();
			this.groupBox_addCustomer = new System.Windows.Forms.GroupBox();
			this.textBox_customerDesc = new System.Windows.Forms.TextBox();
			this.label1_customerDesc = new System.Windows.Forms.Label();
			this.groupBox_addDish = new System.Windows.Forms.GroupBox();
			this.label_dishPrice = new System.Windows.Forms.Label();
			this.textBox_dishPrice = new System.Windows.Forms.TextBox();
			this.button_addDish = new System.Windows.Forms.Button();
			this.textBox_dishDesc = new System.Windows.Forms.TextBox();
			this.label_dishDesc = new System.Windows.Forms.Label();
			this.textBox_dishName = new System.Windows.Forms.TextBox();
			this.label_dishName = new System.Windows.Forms.Label();
			this.label_order = new System.Windows.Forms.Label();
			this.textBox_currentCustomerName = new System.Windows.Forms.TextBox();
			this.folderBrowserDialog_ordersDirectory = new System.Windows.Forms.FolderBrowserDialog();
			this.button_clearMenu = new System.Windows.Forms.Button();
			this.groupBox_buttonSetCount.SuspendLayout();
			this.groupBox_addCustomer.SuspendLayout();
			this.groupBox_addDish.SuspendLayout();
			this.SuspendLayout();
			// 
			// label_customerName
			// 
			this.label_customerName.AutoSize = true;
			this.label_customerName.Location = new System.Drawing.Point(6, 23);
			this.label_customerName.Name = "label_customerName";
			this.label_customerName.Size = new System.Drawing.Size(35, 13);
			this.label_customerName.TabIndex = 4;
			this.label_customerName.Text = "Name";
			// 
			// textBox_customerName
			// 
			this.textBox_customerName.Location = new System.Drawing.Point(62, 19);
			this.textBox_customerName.Name = "textBox_customerName";
			this.textBox_customerName.Size = new System.Drawing.Size(249, 20);
			this.textBox_customerName.TabIndex = 5;
			// 
			// button_addCustomer
			// 
			this.button_addCustomer.BackColor = System.Drawing.Color.LightBlue;
			this.button_addCustomer.Location = new System.Drawing.Point(317, 17);
			this.button_addCustomer.Name = "button_addCustomer";
			this.button_addCustomer.Size = new System.Drawing.Size(57, 49);
			this.button_addCustomer.TabIndex = 6;
			this.button_addCustomer.Text = "Add";
			this.button_addCustomer.UseVisualStyleBackColor = false;
			this.button_addCustomer.Click += new System.EventHandler(this.button_addLamberjack_Click);
			// 
			// listBox_customerLine
			// 
			this.listBox_customerLine.FormattingEnabled = true;
			this.listBox_customerLine.Location = new System.Drawing.Point(12, 42);
			this.listBox_customerLine.Name = "listBox_customerLine";
			this.listBox_customerLine.Size = new System.Drawing.Size(181, 329);
			this.listBox_customerLine.TabIndex = 7;
			// 
			// label_customerLine
			// 
			this.label_customerLine.AutoSize = true;
			this.label_customerLine.Location = new System.Drawing.Point(64, 26);
			this.label_customerLine.Name = "label_customerLine";
			this.label_customerLine.Size = new System.Drawing.Size(74, 13);
			this.label_customerLine.TabIndex = 8;
			this.label_customerLine.Text = "Customer Line";
			// 
			// button_nextLamberjack
			// 
			this.button_nextLamberjack.BackColor = System.Drawing.Color.PaleGreen;
			this.button_nextLamberjack.Enabled = false;
			this.button_nextLamberjack.Location = new System.Drawing.Point(213, 321);
			this.button_nextLamberjack.Name = "button_nextLamberjack";
			this.button_nextLamberjack.Size = new System.Drawing.Size(165, 53);
			this.button_nextLamberjack.TabIndex = 13;
			this.button_nextLamberjack.Text = "Next lamberjack";
			this.button_nextLamberjack.UseVisualStyleBackColor = false;
			this.button_nextLamberjack.Click += new System.EventHandler(this.button_nextLamberjack_Click);
			// 
			// textBox_hasFlatjack
			// 
			this.textBox_hasFlatjack.HideSelection = false;
			this.textBox_hasFlatjack.Location = new System.Drawing.Point(12, 392);
			this.textBox_hasFlatjack.Multiline = true;
			this.textBox_hasFlatjack.Name = "textBox_hasFlatjack";
			this.textBox_hasFlatjack.ReadOnly = true;
			this.textBox_hasFlatjack.Size = new System.Drawing.Size(181, 118);
			this.textBox_hasFlatjack.TabIndex = 14;
			this.textBox_hasFlatjack.TabStop = false;
			this.textBox_hasFlatjack.WordWrap = false;
			// 
			// groupBox_buttonSetCount
			// 
			this.groupBox_buttonSetCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox_buttonSetCount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.groupBox_buttonSetCount.Controls.Add(this.button_removeFoodCount);
			this.groupBox_buttonSetCount.Controls.Add(this.button_addFoodCount);
			this.groupBox_buttonSetCount.Controls.Add(this.button_foodNum5);
			this.groupBox_buttonSetCount.Controls.Add(this.button_foodNum4);
			this.groupBox_buttonSetCount.Controls.Add(this.button_foodNum3);
			this.groupBox_buttonSetCount.Controls.Add(this.button_foodNum2);
			this.groupBox_buttonSetCount.Controls.Add(this.button_foodNum1);
			this.groupBox_buttonSetCount.Enabled = false;
			this.groupBox_buttonSetCount.Location = new System.Drawing.Point(381, 36);
			this.groupBox_buttonSetCount.Name = "groupBox_buttonSetCount";
			this.groupBox_buttonSetCount.Size = new System.Drawing.Size(43, 270);
			this.groupBox_buttonSetCount.TabIndex = 16;
			this.groupBox_buttonSetCount.TabStop = false;
			// 
			// button_removeFoodCount
			// 
			this.button_removeFoodCount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button_removeFoodCount.Location = new System.Drawing.Point(6, 237);
			this.button_removeFoodCount.Name = "button_removeFoodCount";
			this.button_removeFoodCount.Size = new System.Drawing.Size(31, 27);
			this.button_removeFoodCount.TabIndex = 0;
			this.button_removeFoodCount.Text = "-";
			this.button_removeFoodCount.UseVisualStyleBackColor = true;
			this.button_removeFoodCount.Click += new System.EventHandler(this.button_removeFoodCount_Click);
			// 
			// button_addFoodCount
			// 
			this.button_addFoodCount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button_addFoodCount.Location = new System.Drawing.Point(6, 205);
			this.button_addFoodCount.Name = "button_addFoodCount";
			this.button_addFoodCount.Size = new System.Drawing.Size(31, 27);
			this.button_addFoodCount.TabIndex = 1;
			this.button_addFoodCount.Text = "+";
			this.button_addFoodCount.UseVisualStyleBackColor = true;
			this.button_addFoodCount.Click += new System.EventHandler(this.button_addFoodCount_Click);
			// 
			// button_foodNum5
			// 
			this.button_foodNum5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button_foodNum5.Location = new System.Drawing.Point(6, 126);
			this.button_foodNum5.Name = "button_foodNum5";
			this.button_foodNum5.Size = new System.Drawing.Size(31, 23);
			this.button_foodNum5.TabIndex = 4;
			this.button_foodNum5.Tag = "5";
			this.button_foodNum5.Text = "5";
			this.button_foodNum5.UseVisualStyleBackColor = true;
			this.button_foodNum5.Click += new System.EventHandler(this.button_foodNum_addFlapjack_Click);
			// 
			// button_foodNum4
			// 
			this.button_foodNum4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button_foodNum4.Location = new System.Drawing.Point(6, 97);
			this.button_foodNum4.Name = "button_foodNum4";
			this.button_foodNum4.Size = new System.Drawing.Size(31, 23);
			this.button_foodNum4.TabIndex = 3;
			this.button_foodNum4.Tag = "4";
			this.button_foodNum4.Text = "4";
			this.button_foodNum4.UseVisualStyleBackColor = true;
			this.button_foodNum4.Click += new System.EventHandler(this.button_foodNum_addFlapjack_Click);
			// 
			// button_foodNum3
			// 
			this.button_foodNum3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button_foodNum3.Location = new System.Drawing.Point(6, 68);
			this.button_foodNum3.Name = "button_foodNum3";
			this.button_foodNum3.Size = new System.Drawing.Size(31, 23);
			this.button_foodNum3.TabIndex = 2;
			this.button_foodNum3.Tag = "3";
			this.button_foodNum3.Text = "3";
			this.button_foodNum3.UseVisualStyleBackColor = true;
			this.button_foodNum3.Click += new System.EventHandler(this.button_foodNum_addFlapjack_Click);
			// 
			// button_foodNum2
			// 
			this.button_foodNum2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button_foodNum2.Location = new System.Drawing.Point(6, 39);
			this.button_foodNum2.Name = "button_foodNum2";
			this.button_foodNum2.Size = new System.Drawing.Size(31, 23);
			this.button_foodNum2.TabIndex = 1;
			this.button_foodNum2.Tag = "2";
			this.button_foodNum2.Text = "2";
			this.button_foodNum2.UseVisualStyleBackColor = true;
			this.button_foodNum2.Click += new System.EventHandler(this.button_foodNum_addFlapjack_Click);
			// 
			// button_foodNum1
			// 
			this.button_foodNum1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.button_foodNum1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button_foodNum1.Location = new System.Drawing.Point(6, 10);
			this.button_foodNum1.Name = "button_foodNum1";
			this.button_foodNum1.Size = new System.Drawing.Size(31, 23);
			this.button_foodNum1.TabIndex = 0;
			this.button_foodNum1.Tag = "1";
			this.button_foodNum1.Text = "1";
			this.button_foodNum1.UseVisualStyleBackColor = true;
			this.button_foodNum1.Click += new System.EventHandler(this.button_foodNum_addFlapjack_Click);
			// 
			// listBox_orderState
			// 
			this.listBox_orderState.FormattingEnabled = true;
			this.listBox_orderState.Location = new System.Drawing.Point(213, 107);
			this.listBox_orderState.Name = "listBox_orderState";
			this.listBox_orderState.Size = new System.Drawing.Size(165, 199);
			this.listBox_orderState.TabIndex = 17;
			// 
			// label_menu
			// 
			this.label_menu.AutoSize = true;
			this.label_menu.Location = new System.Drawing.Point(494, 25);
			this.label_menu.Name = "label_menu";
			this.label_menu.Size = new System.Drawing.Size(34, 13);
			this.label_menu.TabIndex = 19;
			this.label_menu.Text = "Menu";
			// 
			// label_quantity
			// 
			this.label_quantity.AutoSize = true;
			this.label_quantity.Location = new System.Drawing.Point(378, 25);
			this.label_quantity.Name = "label_quantity";
			this.label_quantity.Size = new System.Drawing.Size(46, 13);
			this.label_quantity.TabIndex = 20;
			this.label_quantity.Text = "Quantity";
			// 
			// listBox_menu
			// 
			this.listBox_menu.FormattingEnabled = true;
			this.listBox_menu.Location = new System.Drawing.Point(428, 42);
			this.listBox_menu.Name = "listBox_menu";
			this.listBox_menu.Size = new System.Drawing.Size(165, 238);
			this.listBox_menu.TabIndex = 23;
			this.listBox_menu.SelectedIndexChanged += new System.EventHandler(this.listBox_menu_SelectedIndexChanged);
			// 
			// label_currentCustomer
			// 
			this.label_currentCustomer.AutoSize = true;
			this.label_currentCustomer.Location = new System.Drawing.Point(248, 25);
			this.label_currentCustomer.MaximumSize = new System.Drawing.Size(200, 22);
			this.label_currentCustomer.Name = "label_currentCustomer";
			this.label_currentCustomer.Size = new System.Drawing.Size(88, 13);
			this.label_currentCustomer.TabIndex = 24;
			this.label_currentCustomer.Text = "Current Customer";
			this.label_currentCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox_descriptionMenuItem
			// 
			this.textBox_descriptionMenuItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_descriptionMenuItem.Location = new System.Drawing.Point(430, 321);
			this.textBox_descriptionMenuItem.Multiline = true;
			this.textBox_descriptionMenuItem.Name = "textBox_descriptionMenuItem";
			this.textBox_descriptionMenuItem.Size = new System.Drawing.Size(163, 53);
			this.textBox_descriptionMenuItem.TabIndex = 28;
			this.textBox_descriptionMenuItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// button_loadMenu
			// 
			this.button_loadMenu.Location = new System.Drawing.Point(428, 283);
			this.button_loadMenu.Name = "button_loadMenu";
			this.button_loadMenu.Size = new System.Drawing.Size(75, 23);
			this.button_loadMenu.TabIndex = 29;
			this.button_loadMenu.Text = "Load Menu";
			this.button_loadMenu.UseVisualStyleBackColor = true;
			this.button_loadMenu.Click += new System.EventHandler(this.button_loadMenu_Click);
			// 
			// button_loadCustomer
			// 
			this.button_loadCustomer.Location = new System.Drawing.Point(12, 523);
			this.button_loadCustomer.Name = "button_loadCustomer";
			this.button_loadCustomer.Size = new System.Drawing.Size(75, 23);
			this.button_loadCustomer.TabIndex = 30;
			this.button_loadCustomer.Text = "Load Cust";
			this.button_loadCustomer.UseVisualStyleBackColor = true;
			this.button_loadCustomer.Click += new System.EventHandler(this.button_loadCustomer_Click);
			// 
			// groupBox_addCustomer
			// 
			this.groupBox_addCustomer.Controls.Add(this.textBox_customerDesc);
			this.groupBox_addCustomer.Controls.Add(this.label1_customerDesc);
			this.groupBox_addCustomer.Controls.Add(this.textBox_customerName);
			this.groupBox_addCustomer.Controls.Add(this.label_customerName);
			this.groupBox_addCustomer.Controls.Add(this.button_addCustomer);
			this.groupBox_addCustomer.Location = new System.Drawing.Point(209, 471);
			this.groupBox_addCustomer.Name = "groupBox_addCustomer";
			this.groupBox_addCustomer.Size = new System.Drawing.Size(384, 75);
			this.groupBox_addCustomer.TabIndex = 31;
			this.groupBox_addCustomer.TabStop = false;
			this.groupBox_addCustomer.Text = "New Customer";
			// 
			// textBox_customerDesc
			// 
			this.textBox_customerDesc.Location = new System.Drawing.Point(62, 45);
			this.textBox_customerDesc.Name = "textBox_customerDesc";
			this.textBox_customerDesc.Size = new System.Drawing.Size(249, 20);
			this.textBox_customerDesc.TabIndex = 8;
			// 
			// label1_customerDesc
			// 
			this.label1_customerDesc.AutoSize = true;
			this.label1_customerDesc.Location = new System.Drawing.Point(6, 46);
			this.label1_customerDesc.Name = "label1_customerDesc";
			this.label1_customerDesc.Size = new System.Drawing.Size(32, 13);
			this.label1_customerDesc.TabIndex = 7;
			this.label1_customerDesc.Text = "Desc";
			// 
			// groupBox_addDish
			// 
			this.groupBox_addDish.Controls.Add(this.label_dishPrice);
			this.groupBox_addDish.Controls.Add(this.textBox_dishPrice);
			this.groupBox_addDish.Controls.Add(this.button_addDish);
			this.groupBox_addDish.Controls.Add(this.textBox_dishDesc);
			this.groupBox_addDish.Controls.Add(this.label_dishDesc);
			this.groupBox_addDish.Controls.Add(this.textBox_dishName);
			this.groupBox_addDish.Controls.Add(this.label_dishName);
			this.groupBox_addDish.Location = new System.Drawing.Point(209, 392);
			this.groupBox_addDish.Name = "groupBox_addDish";
			this.groupBox_addDish.Size = new System.Drawing.Size(384, 73);
			this.groupBox_addDish.TabIndex = 32;
			this.groupBox_addDish.TabStop = false;
			this.groupBox_addDish.Text = "New Dish";
			// 
			// label_dishPrice
			// 
			this.label_dishPrice.AutoSize = true;
			this.label_dishPrice.Location = new System.Drawing.Point(233, 20);
			this.label_dishPrice.Name = "label_dishPrice";
			this.label_dishPrice.Size = new System.Drawing.Size(31, 13);
			this.label_dishPrice.TabIndex = 6;
			this.label_dishPrice.Text = "Price";
			// 
			// textBox_dishPrice
			// 
			this.textBox_dishPrice.Location = new System.Drawing.Point(264, 17);
			this.textBox_dishPrice.Name = "textBox_dishPrice";
			this.textBox_dishPrice.Size = new System.Drawing.Size(49, 20);
			this.textBox_dishPrice.TabIndex = 2;
			// 
			// button_addDish
			// 
			this.button_addDish.BackColor = System.Drawing.Color.LightBlue;
			this.button_addDish.Location = new System.Drawing.Point(319, 17);
			this.button_addDish.Name = "button_addDish";
			this.button_addDish.Size = new System.Drawing.Size(57, 47);
			this.button_addDish.TabIndex = 4;
			this.button_addDish.Text = "Add";
			this.button_addDish.UseVisualStyleBackColor = false;
			this.button_addDish.Click += new System.EventHandler(this.button_addDish_Click);
			// 
			// textBox_dishDesc
			// 
			this.textBox_dishDesc.Location = new System.Drawing.Point(64, 44);
			this.textBox_dishDesc.Name = "textBox_dishDesc";
			this.textBox_dishDesc.Size = new System.Drawing.Size(249, 20);
			this.textBox_dishDesc.TabIndex = 3;
			// 
			// label_dishDesc
			// 
			this.label_dishDesc.AutoSize = true;
			this.label_dishDesc.Location = new System.Drawing.Point(6, 47);
			this.label_dishDesc.Name = "label_dishDesc";
			this.label_dishDesc.Size = new System.Drawing.Size(32, 13);
			this.label_dishDesc.TabIndex = 2;
			this.label_dishDesc.Text = "Desc";
			// 
			// textBox_dishName
			// 
			this.textBox_dishName.Location = new System.Drawing.Point(64, 17);
			this.textBox_dishName.Name = "textBox_dishName";
			this.textBox_dishName.Size = new System.Drawing.Size(166, 20);
			this.textBox_dishName.TabIndex = 1;
			// 
			// label_dishName
			// 
			this.label_dishName.AutoSize = true;
			this.label_dishName.Location = new System.Drawing.Point(7, 20);
			this.label_dishName.Name = "label_dishName";
			this.label_dishName.Size = new System.Drawing.Size(35, 13);
			this.label_dishName.TabIndex = 0;
			this.label_dishName.Text = "Name";
			// 
			// label_order
			// 
			this.label_order.AutoSize = true;
			this.label_order.Location = new System.Drawing.Point(270, 90);
			this.label_order.Name = "label_order";
			this.label_order.Size = new System.Drawing.Size(33, 13);
			this.label_order.TabIndex = 33;
			this.label_order.Text = "Order";
			// 
			// textBox_currentCustomerName
			// 
			this.textBox_currentCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_currentCustomerName.BackColor = System.Drawing.SystemColors.Window;
			this.textBox_currentCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_currentCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_currentCustomerName.Location = new System.Drawing.Point(213, 46);
			this.textBox_currentCustomerName.MaximumSize = new System.Drawing.Size(200, 30);
			this.textBox_currentCustomerName.Multiline = true;
			this.textBox_currentCustomerName.Name = "textBox_currentCustomerName";
			this.textBox_currentCustomerName.ReadOnly = true;
			this.textBox_currentCustomerName.Size = new System.Drawing.Size(165, 27);
			this.textBox_currentCustomerName.TabIndex = 34;
			this.textBox_currentCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// button_clearMenu
			// 
			this.button_clearMenu.Location = new System.Drawing.Point(509, 283);
			this.button_clearMenu.Name = "button_clearMenu";
			this.button_clearMenu.Size = new System.Drawing.Size(84, 23);
			this.button_clearMenu.TabIndex = 35;
			this.button_clearMenu.Text = "Clear Menu";
			this.button_clearMenu.UseVisualStyleBackColor = true;
			this.button_clearMenu.Click += new System.EventHandler(this.button_clearMenu_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(606, 664);
			this.Controls.Add(this.button_clearMenu);
			this.Controls.Add(this.textBox_currentCustomerName);
			this.Controls.Add(this.label_order);
			this.Controls.Add(this.groupBox_addDish);
			this.Controls.Add(this.groupBox_addCustomer);
			this.Controls.Add(this.button_loadCustomer);
			this.Controls.Add(this.button_loadMenu);
			this.Controls.Add(this.label_currentCustomer);
			this.Controls.Add(this.textBox_descriptionMenuItem);
			this.Controls.Add(this.listBox_menu);
			this.Controls.Add(this.label_quantity);
			this.Controls.Add(this.label_menu);
			this.Controls.Add(this.listBox_orderState);
			this.Controls.Add(this.groupBox_buttonSetCount);
			this.Controls.Add(this.textBox_hasFlatjack);
			this.Controls.Add(this.button_nextLamberjack);
			this.Controls.Add(this.label_customerLine);
			this.Controls.Add(this.listBox_customerLine);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.ShowIcon = false;
			this.Text = "Breakfast for Lamberjack";
			this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
			this.groupBox_buttonSetCount.ResumeLayout(false);
			this.groupBox_addCustomer.ResumeLayout(false);
			this.groupBox_addCustomer.PerformLayout();
			this.groupBox_addDish.ResumeLayout(false);
			this.groupBox_addDish.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label_customerName;
		private System.Windows.Forms.TextBox textBox_customerName;
		private System.Windows.Forms.Button button_addCustomer;
		private System.Windows.Forms.ListBox listBox_customerLine;
		private System.Windows.Forms.Label label_customerLine;
		private System.Windows.Forms.Button button_nextLamberjack;
		private System.Windows.Forms.TextBox textBox_hasFlatjack;
		private System.Windows.Forms.GroupBox groupBox_buttonSetCount;
		private System.Windows.Forms.Button button_foodNum5;
		private System.Windows.Forms.Button button_foodNum4;
		private System.Windows.Forms.Button button_foodNum3;
		private System.Windows.Forms.Button button_foodNum2;
		private System.Windows.Forms.Button button_foodNum1;
		private System.Windows.Forms.ListBox listBox_orderState;
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
		private System.Windows.Forms.GroupBox groupBox_addCustomer;
		private System.Windows.Forms.TextBox textBox_customerDesc;
		private System.Windows.Forms.Label label1_customerDesc;
		private System.Windows.Forms.GroupBox groupBox_addDish;
		private System.Windows.Forms.Label label_dishPrice;
		private System.Windows.Forms.TextBox textBox_dishPrice;
		private System.Windows.Forms.Button button_addDish;
		private System.Windows.Forms.TextBox textBox_dishDesc;
		private System.Windows.Forms.Label label_dishDesc;
		private System.Windows.Forms.TextBox textBox_dishName;
		private System.Windows.Forms.Label label_dishName;
		private System.Windows.Forms.Label label_order;
		private System.Windows.Forms.TextBox textBox_currentCustomerName;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_ordersDirectory;
		private System.Windows.Forms.Button button_clearMenu;
	}
}

