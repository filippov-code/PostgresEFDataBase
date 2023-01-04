namespace Presentation
{
    partial class Form1
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
            this.shipmentsDataGrid = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customersDataGrid = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ordersDataGrid = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.removeCustomerButton = new System.Windows.Forms.Button();
            this.addOrderButton = new System.Windows.Forms.Button();
            this.removeOrderButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.customerIdForCountOrdersTextBox = new System.Windows.Forms.TextBox();
            this.customerOrdersCountDataGrid = new System.Windows.Forms.DataGridView();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.shipmentIdForAddressTextBox = new System.Windows.Forms.TextBox();
            this.addressOfShipmentDataGrid = new System.Windows.Forms.DataGridView();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.customerIdForSumOrdersTextBox = new System.Windows.Forms.TextBox();
            this.customerOrdersSumDataGrid = new System.Windows.Forms.DataGridView();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.customerOrdersSumResultLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.customerOrdersCountResultLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.addressOfShipmentResultLabel = new System.Windows.Forms.Label();
            this.newCustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.newCustomerAddressTextBox = new System.Windows.Forms.TextBox();
            this.newCustomerAgeTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.newOrderCustomerIdTextBox = new System.Windows.Forms.TextBox();
            this.newOrderDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.newOrderPriceTextBox = new System.Windows.Forms.TextBox();
            this.newShipmentCourierInfoTextBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.customerIdForCountOrdersButton = new System.Windows.Forms.Button();
            this.shipmentForAddressButton = new System.Windows.Forms.Button();
            this.customerIdForSumOrdersButton = new System.Windows.Forms.Button();
            this.removeShipmentButton = new System.Windows.Forms.Button();
            this.saveCustomersButton = new System.Windows.Forms.Button();
            this.saveOrdersButton = new System.Windows.Forms.Button();
            this.saveShipmentsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrdersCountDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressOfShipmentDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrdersSumDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // shipmentsDataGrid
            // 
            this.shipmentsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shipmentsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column2,
            this.Column1});
            this.shipmentsDataGrid.Location = new System.Drawing.Point(824, 32);
            this.shipmentsDataGrid.MultiSelect = false;
            this.shipmentsDataGrid.Name = "shipmentsDataGrid";
            this.shipmentsDataGrid.RowHeadersWidth = 51;
            this.shipmentsDataGrid.RowTemplate.Height = 29;
            this.shipmentsDataGrid.Size = new System.Drawing.Size(400, 188);
            this.shipmentsDataGrid.TabIndex = 4;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column7.DataPropertyName = "Id";
            this.Column7.HeaderText = "Id";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 51;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "OrderId";
            this.Column2.HeaderText = "OrderId";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 89;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CourierInfo";
            this.Column1.HeaderText = "Информация курьеру";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // customersDataGrid
            // 
            this.customersDataGrid.AllowUserToDeleteRows = false;
            this.customersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.customersDataGrid.Location = new System.Drawing.Point(12, 32);
            this.customersDataGrid.MultiSelect = false;
            this.customersDataGrid.Name = "customersDataGrid";
            this.customersDataGrid.RowHeadersWidth = 51;
            this.customersDataGrid.RowTemplate.Height = 29;
            this.customersDataGrid.Size = new System.Drawing.Size(400, 188);
            this.customersDataGrid.TabIndex = 0;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Id";
            this.Column8.HeaderText = "Id";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Name";
            this.Column9.HeaderText = "Имя";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Address";
            this.Column10.HeaderText = "Адрес";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "Age";
            this.Column11.HeaderText = "Возраст";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(418, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Orders";
            // 
            // ordersDataGrid
            // 
            this.ordersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.ordersDataGrid.Location = new System.Drawing.Point(418, 32);
            this.ordersDataGrid.MultiSelect = false;
            this.ordersDataGrid.Name = "ordersDataGrid";
            this.ordersDataGrid.RowHeadersWidth = 51;
            this.ordersDataGrid.RowTemplate.Height = 29;
            this.ordersDataGrid.Size = new System.Drawing.Size(400, 188);
            this.ordersDataGrid.TabIndex = 3;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Id";
            this.Column3.HeaderText = "Id";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "CustomerId";
            this.Column4.HeaderText = "Id Покупателя";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Date";
            this.Column5.HeaderText = "Дата";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Price";
            this.Column6.HeaderText = "Цена";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(824, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Shipments";
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addCustomerButton.Location = new System.Drawing.Point(12, 332);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(127, 29);
            this.addCustomerButton.TabIndex = 6;
            this.addCustomerButton.Text = "+Покупатель";
            this.addCustomerButton.UseVisualStyleBackColor = true;
            this.addCustomerButton.Click += new System.EventHandler(this.addCustomerButton_Click);
            // 
            // removeCustomerButton
            // 
            this.removeCustomerButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeCustomerButton.Location = new System.Drawing.Point(274, 332);
            this.removeCustomerButton.Name = "removeCustomerButton";
            this.removeCustomerButton.Size = new System.Drawing.Size(138, 29);
            this.removeCustomerButton.TabIndex = 7;
            this.removeCustomerButton.Text = "-Покупатель";
            this.removeCustomerButton.UseVisualStyleBackColor = true;
            this.removeCustomerButton.Click += new System.EventHandler(this.removeCustomerButton_Click);
            // 
            // addOrderButton
            // 
            this.addOrderButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addOrderButton.Location = new System.Drawing.Point(418, 332);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(130, 29);
            this.addOrderButton.TabIndex = 8;
            this.addOrderButton.Text = "+Заказ";
            this.addOrderButton.UseVisualStyleBackColor = true;
            this.addOrderButton.Click += new System.EventHandler(this.addOrderButton_Click);
            // 
            // removeOrderButton
            // 
            this.removeOrderButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeOrderButton.Location = new System.Drawing.Point(684, 332);
            this.removeOrderButton.Name = "removeOrderButton";
            this.removeOrderButton.Size = new System.Drawing.Size(134, 29);
            this.removeOrderButton.TabIndex = 9;
            this.removeOrderButton.Text = "-Заказ";
            this.removeOrderButton.UseVisualStyleBackColor = true;
            this.removeOrderButton.Click += new System.EventHandler(this.removeOrderButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(13, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Количество заказов покупателя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(13, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Id Покупателя";
            // 
            // customerIdForCountOrdersTextBox
            // 
            this.customerIdForCountOrdersTextBox.Location = new System.Drawing.Point(126, 391);
            this.customerIdForCountOrdersTextBox.Name = "customerIdForCountOrdersTextBox";
            this.customerIdForCountOrdersTextBox.Size = new System.Drawing.Size(286, 27);
            this.customerIdForCountOrdersTextBox.TabIndex = 14;
            // 
            // customerOrdersCountDataGrid
            // 
            this.customerOrdersCountDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerOrdersCountDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column12,
            this.Column13,
            this.Column14});
            this.customerOrdersCountDataGrid.Location = new System.Drawing.Point(13, 459);
            this.customerOrdersCountDataGrid.Name = "customerOrdersCountDataGrid";
            this.customerOrdersCountDataGrid.ReadOnly = true;
            this.customerOrdersCountDataGrid.RowHeadersWidth = 51;
            this.customerOrdersCountDataGrid.RowTemplate.Height = 29;
            this.customerOrdersCountDataGrid.Size = new System.Drawing.Size(399, 165);
            this.customerOrdersCountDataGrid.TabIndex = 15;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "Id";
            this.Column12.HeaderText = "Id";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 125;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "Date";
            this.Column13.HeaderText = "Дата";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 125;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "Price";
            this.Column14.HeaderText = "Цена";
            this.Column14.MinimumWidth = 6;
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 125;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(418, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Адрес доставки";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(418, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Id Доставки";
            // 
            // shipmentIdForAddressTextBox
            // 
            this.shipmentIdForAddressTextBox.Location = new System.Drawing.Point(514, 391);
            this.shipmentIdForAddressTextBox.Name = "shipmentIdForAddressTextBox";
            this.shipmentIdForAddressTextBox.Size = new System.Drawing.Size(304, 27);
            this.shipmentIdForAddressTextBox.TabIndex = 18;
            // 
            // addressOfShipmentDataGrid
            // 
            this.addressOfShipmentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addressOfShipmentDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18});
            this.addressOfShipmentDataGrid.Location = new System.Drawing.Point(418, 459);
            this.addressOfShipmentDataGrid.Name = "addressOfShipmentDataGrid";
            this.addressOfShipmentDataGrid.ReadOnly = true;
            this.addressOfShipmentDataGrid.RowHeadersWidth = 51;
            this.addressOfShipmentDataGrid.RowTemplate.Height = 29;
            this.addressOfShipmentDataGrid.Size = new System.Drawing.Size(400, 165);
            this.addressOfShipmentDataGrid.TabIndex = 19;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "Id";
            this.Column15.HeaderText = "Id";
            this.Column15.MinimumWidth = 6;
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Width = 125;
            // 
            // Column16
            // 
            this.Column16.DataPropertyName = "Name";
            this.Column16.HeaderText = "Имя";
            this.Column16.MinimumWidth = 6;
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column16.Width = 125;
            // 
            // Column17
            // 
            this.Column17.DataPropertyName = "Address";
            this.Column17.HeaderText = "Адрес";
            this.Column17.MinimumWidth = 6;
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            this.Column17.Width = 125;
            // 
            // Column18
            // 
            this.Column18.DataPropertyName = "Age";
            this.Column18.HeaderText = "Возраст";
            this.Column18.MinimumWidth = 6;
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            this.Column18.Width = 125;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(824, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Сумма заказов покупателя";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(824, 394);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Id Покупателя";
            // 
            // customerIdForSumOrdersTextBox
            // 
            this.customerIdForSumOrdersTextBox.Location = new System.Drawing.Point(937, 391);
            this.customerIdForSumOrdersTextBox.Name = "customerIdForSumOrdersTextBox";
            this.customerIdForSumOrdersTextBox.Size = new System.Drawing.Size(283, 27);
            this.customerIdForSumOrdersTextBox.TabIndex = 22;
            // 
            // customerOrdersSumDataGrid
            // 
            this.customerOrdersSumDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerOrdersSumDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column19,
            this.Column20,
            this.Column21});
            this.customerOrdersSumDataGrid.Location = new System.Drawing.Point(824, 459);
            this.customerOrdersSumDataGrid.Name = "customerOrdersSumDataGrid";
            this.customerOrdersSumDataGrid.ReadOnly = true;
            this.customerOrdersSumDataGrid.RowHeadersWidth = 51;
            this.customerOrdersSumDataGrid.RowTemplate.Height = 29;
            this.customerOrdersSumDataGrid.Size = new System.Drawing.Size(400, 165);
            this.customerOrdersSumDataGrid.TabIndex = 23;
            // 
            // Column19
            // 
            this.Column19.DataPropertyName = "Id";
            this.Column19.HeaderText = "Id";
            this.Column19.MinimumWidth = 6;
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            this.Column19.Width = 125;
            // 
            // Column20
            // 
            this.Column20.DataPropertyName = "Date";
            this.Column20.HeaderText = "Дата";
            this.Column20.MinimumWidth = 6;
            this.Column20.Name = "Column20";
            this.Column20.ReadOnly = true;
            this.Column20.Width = 125;
            // 
            // Column21
            // 
            this.Column21.DataPropertyName = "Price";
            this.Column21.HeaderText = "Цена";
            this.Column21.MinimumWidth = 6;
            this.Column21.Name = "Column21";
            this.Column21.ReadOnly = true;
            this.Column21.Width = 125;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(824, 627);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Итого:";
            // 
            // customerOrdersSumResultLabel
            // 
            this.customerOrdersSumResultLabel.AutoSize = true;
            this.customerOrdersSumResultLabel.Location = new System.Drawing.Point(883, 627);
            this.customerOrdersSumResultLabel.Name = "customerOrdersSumResultLabel";
            this.customerOrdersSumResultLabel.Size = new System.Drawing.Size(0, 20);
            this.customerOrdersSumResultLabel.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 627);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 20);
            this.label12.TabIndex = 26;
            this.label12.Text = "Итого:";
            // 
            // customerOrdersCountResultLabel
            // 
            this.customerOrdersCountResultLabel.AutoSize = true;
            this.customerOrdersCountResultLabel.Location = new System.Drawing.Point(72, 627);
            this.customerOrdersCountResultLabel.Name = "customerOrdersCountResultLabel";
            this.customerOrdersCountResultLabel.Size = new System.Drawing.Size(0, 20);
            this.customerOrdersCountResultLabel.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(418, 627);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 20);
            this.label14.TabIndex = 28;
            this.label14.Text = "Адрес:";
            // 
            // addressOfShipmentResultLabel
            // 
            this.addressOfShipmentResultLabel.AutoSize = true;
            this.addressOfShipmentResultLabel.Location = new System.Drawing.Point(478, 627);
            this.addressOfShipmentResultLabel.Name = "addressOfShipmentResultLabel";
            this.addressOfShipmentResultLabel.Size = new System.Drawing.Size(0, 20);
            this.addressOfShipmentResultLabel.TabIndex = 29;
            // 
            // newCustomerNameTextBox
            // 
            this.newCustomerNameTextBox.Location = new System.Drawing.Point(12, 246);
            this.newCustomerNameTextBox.Name = "newCustomerNameTextBox";
            this.newCustomerNameTextBox.Size = new System.Drawing.Size(256, 27);
            this.newCustomerNameTextBox.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(12, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 20);
            this.label11.TabIndex = 31;
            this.label11.Text = "Имя";
            // 
            // newCustomerAddressTextBox
            // 
            this.newCustomerAddressTextBox.Location = new System.Drawing.Point(12, 299);
            this.newCustomerAddressTextBox.Name = "newCustomerAddressTextBox";
            this.newCustomerAddressTextBox.Size = new System.Drawing.Size(400, 27);
            this.newCustomerAddressTextBox.TabIndex = 32;
            // 
            // newCustomerAgeTextBox
            // 
            this.newCustomerAgeTextBox.Location = new System.Drawing.Point(274, 246);
            this.newCustomerAgeTextBox.Name = "newCustomerAgeTextBox";
            this.newCustomerAgeTextBox.Size = new System.Drawing.Size(138, 27);
            this.newCustomerAgeTextBox.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(12, 276);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 20);
            this.label13.TabIndex = 34;
            this.label13.Text = "Адрес";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(274, 223);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 20);
            this.label15.TabIndex = 35;
            this.label15.Text = "Возраст";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(418, 223);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(109, 20);
            this.label16.TabIndex = 36;
            this.label16.Text = "Id Покупателя";
            // 
            // newOrderCustomerIdTextBox
            // 
            this.newOrderCustomerIdTextBox.Location = new System.Drawing.Point(418, 246);
            this.newOrderCustomerIdTextBox.Name = "newOrderCustomerIdTextBox";
            this.newOrderCustomerIdTextBox.Size = new System.Drawing.Size(141, 27);
            this.newOrderCustomerIdTextBox.TabIndex = 37;
            // 
            // newOrderDateTimePicker
            // 
            this.newOrderDateTimePicker.Location = new System.Drawing.Point(418, 299);
            this.newOrderDateTimePicker.Name = "newOrderDateTimePicker";
            this.newOrderDateTimePicker.Size = new System.Drawing.Size(400, 27);
            this.newOrderDateTimePicker.TabIndex = 38;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(418, 276);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 20);
            this.label17.TabIndex = 39;
            this.label17.Text = "Дата";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(565, 223);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 20);
            this.label18.TabIndex = 40;
            this.label18.Text = "Цена";
            // 
            // newOrderPriceTextBox
            // 
            this.newOrderPriceTextBox.Location = new System.Drawing.Point(565, 246);
            this.newOrderPriceTextBox.Name = "newOrderPriceTextBox";
            this.newOrderPriceTextBox.Size = new System.Drawing.Size(256, 27);
            this.newOrderPriceTextBox.TabIndex = 41;
            // 
            // newShipmentCourierInfoTextBox
            // 
            this.newShipmentCourierInfoTextBox.Location = new System.Drawing.Point(824, 246);
            this.newShipmentCourierInfoTextBox.Multiline = true;
            this.newShipmentCourierInfoTextBox.Name = "newShipmentCourierInfoTextBox";
            this.newShipmentCourierInfoTextBox.Size = new System.Drawing.Size(400, 80);
            this.newShipmentCourierInfoTextBox.TabIndex = 42;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(824, 223);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(154, 20);
            this.label19.TabIndex = 43;
            this.label19.Text = "Информация курьеру";
            // 
            // customerIdForCountOrdersButton
            // 
            this.customerIdForCountOrdersButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customerIdForCountOrdersButton.Location = new System.Drawing.Point(13, 424);
            this.customerIdForCountOrdersButton.Name = "customerIdForCountOrdersButton";
            this.customerIdForCountOrdersButton.Size = new System.Drawing.Size(399, 29);
            this.customerIdForCountOrdersButton.TabIndex = 44;
            this.customerIdForCountOrdersButton.Text = "Посчитать";
            this.customerIdForCountOrdersButton.UseVisualStyleBackColor = true;
            this.customerIdForCountOrdersButton.Click += new System.EventHandler(this.customerIdForCountOrdersButton_Click);
            // 
            // shipmentForAddressButton
            // 
            this.shipmentForAddressButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.shipmentForAddressButton.Location = new System.Drawing.Point(418, 424);
            this.shipmentForAddressButton.Name = "shipmentForAddressButton";
            this.shipmentForAddressButton.Size = new System.Drawing.Size(400, 29);
            this.shipmentForAddressButton.TabIndex = 45;
            this.shipmentForAddressButton.Text = "Узнать";
            this.shipmentForAddressButton.UseVisualStyleBackColor = true;
            this.shipmentForAddressButton.Click += new System.EventHandler(this.shipmentForAddressButton_Click);
            // 
            // customerIdForSumOrdersButton
            // 
            this.customerIdForSumOrdersButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customerIdForSumOrdersButton.Location = new System.Drawing.Point(824, 424);
            this.customerIdForSumOrdersButton.Name = "customerIdForSumOrdersButton";
            this.customerIdForSumOrdersButton.Size = new System.Drawing.Size(400, 29);
            this.customerIdForSumOrdersButton.TabIndex = 46;
            this.customerIdForSumOrdersButton.Text = "Рассчитать";
            this.customerIdForSumOrdersButton.UseVisualStyleBackColor = true;
            this.customerIdForSumOrdersButton.Click += new System.EventHandler(this.customerIdForSumOrdersButton_Click);
            // 
            // removeShipmentButton
            // 
            this.removeShipmentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeShipmentButton.Location = new System.Drawing.Point(1033, 332);
            this.removeShipmentButton.Name = "removeShipmentButton";
            this.removeShipmentButton.Size = new System.Drawing.Size(191, 29);
            this.removeShipmentButton.TabIndex = 47;
            this.removeShipmentButton.Text = "-Доставка";
            this.removeShipmentButton.UseVisualStyleBackColor = true;
            this.removeShipmentButton.Click += new System.EventHandler(this.removeShipmentButton_Click);
            // 
            // saveCustomersButton
            // 
            this.saveCustomersButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveCustomersButton.Location = new System.Drawing.Point(145, 332);
            this.saveCustomersButton.Name = "saveCustomersButton";
            this.saveCustomersButton.Size = new System.Drawing.Size(123, 29);
            this.saveCustomersButton.TabIndex = 48;
            this.saveCustomersButton.Text = "Сохранить";
            this.saveCustomersButton.UseVisualStyleBackColor = true;
            this.saveCustomersButton.Click += new System.EventHandler(this.saveCustomersButton_Click);
            // 
            // saveOrdersButton
            // 
            this.saveOrdersButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveOrdersButton.Location = new System.Drawing.Point(554, 332);
            this.saveOrdersButton.Name = "saveOrdersButton";
            this.saveOrdersButton.Size = new System.Drawing.Size(124, 29);
            this.saveOrdersButton.TabIndex = 49;
            this.saveOrdersButton.Text = "Сохранить";
            this.saveOrdersButton.UseVisualStyleBackColor = true;
            this.saveOrdersButton.Click += new System.EventHandler(this.saveOrdersButton_Click);
            // 
            // saveShipmentsButton
            // 
            this.saveShipmentsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveShipmentsButton.Location = new System.Drawing.Point(824, 332);
            this.saveShipmentsButton.Name = "saveShipmentsButton";
            this.saveShipmentsButton.Size = new System.Drawing.Size(203, 29);
            this.saveShipmentsButton.TabIndex = 50;
            this.saveShipmentsButton.Text = "Сохранить";
            this.saveShipmentsButton.UseVisualStyleBackColor = true;
            this.saveShipmentsButton.Click += new System.EventHandler(this.saveShipmentsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 653);
            this.Controls.Add(this.saveShipmentsButton);
            this.Controls.Add(this.saveOrdersButton);
            this.Controls.Add(this.saveCustomersButton);
            this.Controls.Add(this.removeShipmentButton);
            this.Controls.Add(this.customerIdForSumOrdersButton);
            this.Controls.Add(this.shipmentForAddressButton);
            this.Controls.Add(this.customerIdForCountOrdersButton);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.newShipmentCourierInfoTextBox);
            this.Controls.Add(this.newOrderPriceTextBox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.newOrderDateTimePicker);
            this.Controls.Add(this.newOrderCustomerIdTextBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.newCustomerAgeTextBox);
            this.Controls.Add(this.newCustomerAddressTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.newCustomerNameTextBox);
            this.Controls.Add(this.addressOfShipmentResultLabel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.customerOrdersCountResultLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.customerOrdersSumResultLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.customerOrdersSumDataGrid);
            this.Controls.Add(this.customerIdForSumOrdersTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.addressOfShipmentDataGrid);
            this.Controls.Add(this.shipmentIdForAddressTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.customerOrdersCountDataGrid);
            this.Controls.Add(this.customerIdForCountOrdersTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.removeOrderButton);
            this.Controls.Add(this.addOrderButton);
            this.Controls.Add(this.removeCustomerButton);
            this.Controls.Add(this.addCustomerButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.shipmentsDataGrid);
            this.Controls.Add(this.ordersDataGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customersDataGrid);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.shipmentsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrdersCountDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressOfShipmentDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrdersSumDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView customersDataGrid;
        private Label label1;
        private Label label2;
        private DataGridView ordersDataGrid;
        private DataGridView shipmentsDataGrid;
        private Label label3;
        private Button addCustomerButton;
        private Button removeCustomerButton;
        private Button addOrderButton;
        private Button removeOrderButton;
        private Label label4;
        private Label label5;
        private TextBox customerIdForCountOrdersTextBox;
        private DataGridView customerOrdersCountDataGrid;
        private Label label6;
        private Label label7;
        private TextBox shipmentIdForAddressTextBox;
        private DataGridView addressOfShipmentDataGrid;
        private Label label8;
        private Label label9;
        private TextBox customerIdForSumOrdersTextBox;
        private DataGridView customerOrdersSumDataGrid;
        private Label label10;
        private Label customerOrdersSumResultLabel;
        private Label label12;
        private Label customerOrdersCountResultLabel;
        private Label label14;
        private Label addressOfShipmentResultLabel;
        private TextBox newCustomerNameTextBox;
        private Label label11;
        private TextBox newCustomerAddressTextBox;
        private TextBox newCustomerAgeTextBox;
        private Label label13;
        private Label label15;
        private Label label16;
        private TextBox newOrderCustomerIdTextBox;
        private DateTimePicker newOrderDateTimePicker;
        private Label label17;
        private Label label18;
        private TextBox newOrderPriceTextBox;
        private TextBox newShipmentCourierInfoTextBox;
        private Label label19;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private Button customerIdForCountOrdersButton;
        private Button shipmentForAddressButton;
        private Button customerIdForSumOrdersButton;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn Column16;
        private DataGridViewTextBoxColumn Column17;
        private DataGridViewTextBoxColumn Column18;
        private DataGridViewTextBoxColumn Column19;
        private DataGridViewTextBoxColumn Column20;
        private DataGridViewTextBoxColumn Column21;
        private Button removeShipmentButton;
        private Button saveCustomersButton;
        private Button saveOrdersButton;
        private Button saveShipmentsButton;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}