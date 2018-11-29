namespace Exercise5_1_1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label vendorIDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label address1Label;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label invoiceDateLabel;
            System.Windows.Forms.Label invoiceNumberLabel;
            System.Windows.Forms.Label termsIDLabel;
            System.Windows.Forms.Label dueDateLabel;
            this.myDataSet = new Exercise5_1_1.MyDataSet();
            this.vendorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorsTableAdapter = new Exercise5_1_1.MyDataSetTableAdapters.VendorsTableAdapter();
            this.tableAdapterManager = new Exercise5_1_1.MyDataSetTableAdapters.TableAdapterManager();
            this.vendorsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.vendorsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fillByVendorIDToolStrip = new System.Windows.Forms.ToolStrip();
            this.vendorIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.vendorIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByVendorIDToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.vendorIDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.address1TextBox = new System.Windows.Forms.TextBox();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoicesTableAdapter = new Exercise5_1_1.MyDataSetTableAdapters.InvoicesTableAdapter();
            this.invoiceDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.invoiceNumberTextBox = new System.Windows.Forms.TextBox();
            this.termsIDComboBox = new System.Windows.Forms.ComboBox();
            this.dueDateTextBox = new System.Windows.Forms.TextBox();
            vendorIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            address1Label = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            invoiceDateLabel = new System.Windows.Forms.Label();
            invoiceNumberLabel = new System.Windows.Forms.Label();
            termsIDLabel = new System.Windows.Forms.Label();
            dueDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingNavigator)).BeginInit();
            this.vendorsBindingNavigator.SuspendLayout();
            this.fillByVendorIDToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // myDataSet
            // 
            this.myDataSet.DataSetName = "MyDataSet";
            this.myDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendorsBindingSource
            // 
            this.vendorsBindingSource.DataMember = "Vendors";
            this.vendorsBindingSource.DataSource = this.myDataSet;
            // 
            // vendorsTableAdapter
            // 
            this.vendorsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InvoicesTableAdapter = this.invoicesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Exercise5_1_1.MyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendorsTableAdapter = this.vendorsTableAdapter;
            // 
            // vendorsBindingNavigator
            // 
            this.vendorsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vendorsBindingNavigator.BindingSource = this.vendorsBindingSource;
            this.vendorsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vendorsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vendorsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.vendorsBindingNavigatorSaveItem});
            this.vendorsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vendorsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vendorsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vendorsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vendorsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vendorsBindingNavigator.Name = "vendorsBindingNavigator";
            this.vendorsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vendorsBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.vendorsBindingNavigator.TabIndex = 0;
            this.vendorsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // vendorsBindingNavigatorSaveItem
            // 
            this.vendorsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vendorsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vendorsBindingNavigatorSaveItem.Image")));
            this.vendorsBindingNavigatorSaveItem.Name = "vendorsBindingNavigatorSaveItem";
            this.vendorsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 20);
            this.vendorsBindingNavigatorSaveItem.Text = "Save Data";
            this.vendorsBindingNavigatorSaveItem.Click += new System.EventHandler(this.vendorsBindingNavigatorSaveItem_Click);
            // 
            // fillByVendorIDToolStrip
            // 
            this.fillByVendorIDToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendorIDToolStripLabel,
            this.vendorIDToolStripTextBox,
            this.fillByVendorIDToolStripButton});
            this.fillByVendorIDToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillByVendorIDToolStrip.Name = "fillByVendorIDToolStrip";
            this.fillByVendorIDToolStrip.Size = new System.Drawing.Size(800, 25);
            this.fillByVendorIDToolStrip.TabIndex = 1;
            this.fillByVendorIDToolStrip.Text = "fillByVendorIDToolStrip";
            // 
            // vendorIDToolStripLabel
            // 
            this.vendorIDToolStripLabel.Name = "vendorIDToolStripLabel";
            this.vendorIDToolStripLabel.Size = new System.Drawing.Size(58, 22);
            this.vendorIDToolStripLabel.Text = "VendorID:";
            // 
            // vendorIDToolStripTextBox
            // 
            this.vendorIDToolStripTextBox.Name = "vendorIDToolStripTextBox";
            this.vendorIDToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // fillByVendorIDToolStripButton
            // 
            this.fillByVendorIDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByVendorIDToolStripButton.Name = "fillByVendorIDToolStripButton";
            this.fillByVendorIDToolStripButton.Size = new System.Drawing.Size(87, 19);
            this.fillByVendorIDToolStripButton.Text = "FillByVendorID";
            this.fillByVendorIDToolStripButton.Click += new System.EventHandler(this.fillByVendorIDToolStripButton_Click);
            // 
            // vendorIDLabel
            // 
            vendorIDLabel.AutoSize = true;
            vendorIDLabel.Location = new System.Drawing.Point(33, 79);
            vendorIDLabel.Name = "vendorIDLabel";
            vendorIDLabel.Size = new System.Drawing.Size(58, 13);
            vendorIDLabel.TabIndex = 2;
            vendorIDLabel.Text = "Vendor ID:";
            // 
            // vendorIDTextBox
            // 
            this.vendorIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "VendorID", true));
            this.vendorIDTextBox.Location = new System.Drawing.Point(97, 76);
            this.vendorIDTextBox.Name = "vendorIDTextBox";
            this.vendorIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.vendorIDTextBox.TabIndex = 3;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(53, 105);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(97, 102);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(286, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // address1Label
            // 
            address1Label.AutoSize = true;
            address1Label.Location = new System.Drawing.Point(37, 131);
            address1Label.Name = "address1Label";
            address1Label.Size = new System.Drawing.Size(54, 13);
            address1Label.TabIndex = 6;
            address1Label.Text = "Address1:";
            // 
            // address1TextBox
            // 
            this.address1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "Address1", true));
            this.address1TextBox.Location = new System.Drawing.Point(97, 128);
            this.address1TextBox.Name = "address1TextBox";
            this.address1TextBox.Size = new System.Drawing.Size(286, 20);
            this.address1TextBox.TabIndex = 7;
            // 
            // address2TextBox
            // 
            this.address2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "Address2", true));
            this.address2TextBox.Location = new System.Drawing.Point(97, 154);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(286, 20);
            this.address2TextBox.TabIndex = 9;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(12, 200);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(79, 13);
            cityLabel.TabIndex = 9;
            cityLabel.Text = "City, State, Zip:";
            cityLabel.Click += new System.EventHandler(this.cityLabel_Click);
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(97, 197);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(140, 20);
            this.cityTextBox.TabIndex = 10;
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "State", true));
            this.stateTextBox.Location = new System.Drawing.Point(243, 197);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(46, 20);
            this.stateTextBox.TabIndex = 12;
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "ZipCode", true));
            this.zipCodeTextBox.Location = new System.Drawing.Point(295, 197);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(88, 20);
            this.zipCodeTextBox.TabIndex = 13;
            // 
            // invoicesBindingSource
            // 
            this.invoicesBindingSource.DataMember = "FK_Invoices_Vendors";
            this.invoicesBindingSource.DataSource = this.vendorsBindingSource;
            // 
            // invoicesTableAdapter
            // 
            this.invoicesTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceDateLabel
            // 
            invoiceDateLabel.AutoSize = true;
            invoiceDateLabel.Location = new System.Drawing.Point(20, 267);
            invoiceDateLabel.Name = "invoiceDateLabel";
            invoiceDateLabel.Size = new System.Drawing.Size(71, 13);
            invoiceDateLabel.TabIndex = 13;
            invoiceDateLabel.Text = "Invoice Date:";
            // 
            // invoiceDateDateTimePicker
            // 
            this.invoiceDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoicesBindingSource, "InvoiceDate", true));
            this.invoiceDateDateTimePicker.Location = new System.Drawing.Point(97, 263);
            this.invoiceDateDateTimePicker.Name = "invoiceDateDateTimePicker";
            this.invoiceDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.invoiceDateDateTimePicker.TabIndex = 14;
            // 
            // invoiceNumberLabel
            // 
            invoiceNumberLabel.AutoSize = true;
            invoiceNumberLabel.Location = new System.Drawing.Point(6, 240);
            invoiceNumberLabel.Name = "invoiceNumberLabel";
            invoiceNumberLabel.Size = new System.Drawing.Size(85, 13);
            invoiceNumberLabel.TabIndex = 15;
            invoiceNumberLabel.Text = "Invoice Number:";
            // 
            // invoiceNumberTextBox
            // 
            this.invoiceNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "InvoiceNumber", true));
            this.invoiceNumberTextBox.Location = new System.Drawing.Point(97, 237);
            this.invoiceNumberTextBox.Name = "invoiceNumberTextBox";
            this.invoiceNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.invoiceNumberTextBox.TabIndex = 16;
            // 
            // termsIDLabel
            // 
            termsIDLabel.AutoSize = true;
            termsIDLabel.Location = new System.Drawing.Point(38, 292);
            termsIDLabel.Name = "termsIDLabel";
            termsIDLabel.Size = new System.Drawing.Size(53, 13);
            termsIDLabel.TabIndex = 17;
            termsIDLabel.Text = "Terms ID:";
            // 
            // termsIDComboBox
            // 
            this.termsIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "TermsID", true));
            this.termsIDComboBox.FormattingEnabled = true;
            this.termsIDComboBox.Location = new System.Drawing.Point(97, 289);
            this.termsIDComboBox.Name = "termsIDComboBox";
            this.termsIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.termsIDComboBox.TabIndex = 18;
            // 
            // dueDateLabel
            // 
            dueDateLabel.AutoSize = true;
            dueDateLabel.Location = new System.Drawing.Point(35, 319);
            dueDateLabel.Name = "dueDateLabel";
            dueDateLabel.Size = new System.Drawing.Size(56, 13);
            dueDateLabel.TabIndex = 19;
            dueDateLabel.Text = "Due Date:";
            // 
            // dueDateTextBox
            // 
            this.dueDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "DueDate", true));
            this.dueDateTextBox.Location = new System.Drawing.Point(97, 316);
            this.dueDateTextBox.Name = "dueDateTextBox";
            this.dueDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.dueDateTextBox.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(dueDateLabel);
            this.Controls.Add(this.dueDateTextBox);
            this.Controls.Add(termsIDLabel);
            this.Controls.Add(this.termsIDComboBox);
            this.Controls.Add(invoiceNumberLabel);
            this.Controls.Add(this.invoiceNumberTextBox);
            this.Controls.Add(invoiceDateLabel);
            this.Controls.Add(this.invoiceDateDateTimePicker);
            this.Controls.Add(this.zipCodeTextBox);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.address2TextBox);
            this.Controls.Add(address1Label);
            this.Controls.Add(this.address1TextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(vendorIDLabel);
            this.Controls.Add(this.vendorIDTextBox);
            this.Controls.Add(this.fillByVendorIDToolStrip);
            this.Controls.Add(this.vendorsBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingNavigator)).EndInit();
            this.vendorsBindingNavigator.ResumeLayout(false);
            this.vendorsBindingNavigator.PerformLayout();
            this.fillByVendorIDToolStrip.ResumeLayout(false);
            this.fillByVendorIDToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyDataSet myDataSet;
        private System.Windows.Forms.BindingSource vendorsBindingSource;
        private MyDataSetTableAdapters.VendorsTableAdapter vendorsTableAdapter;
        private MyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vendorsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton vendorsBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStrip fillByVendorIDToolStrip;
        private System.Windows.Forms.ToolStripLabel vendorIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox vendorIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByVendorIDToolStripButton;
        private System.Windows.Forms.TextBox vendorIDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox address1TextBox;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private MyDataSetTableAdapters.InvoicesTableAdapter invoicesTableAdapter;
        private System.Windows.Forms.BindingSource invoicesBindingSource;
        private System.Windows.Forms.DateTimePicker invoiceDateDateTimePicker;
        private System.Windows.Forms.TextBox invoiceNumberTextBox;
        private System.Windows.Forms.ComboBox termsIDComboBox;
        private System.Windows.Forms.TextBox dueDateTextBox;
    }
}

