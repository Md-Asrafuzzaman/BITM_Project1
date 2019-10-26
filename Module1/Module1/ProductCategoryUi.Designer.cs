namespace Module1
{
    partial class ProductCategoryUi
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
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.displayDataGridView = new System.Windows.Forms.DataGridView();
            this.serachCodeButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchNameButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nextPageButton = new System.Windows.Forms.Button();
            this.categoryRepositoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDIT = new System.Windows.Forms.DataGridViewButtonColumn();
            this.updateButton = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryRepositoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productCategoryUiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.displayDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryRepositoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryRepositoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryUiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(134, 25);
            this.codeTextBox.MaxLength = 4;
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(217, 20);
            this.codeTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(134, 65);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(217, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(276, 109);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // displayDataGridView
            // 
            this.displayDataGridView.AutoGenerateColumns = false;
            this.displayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL,
            this.idDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.EDIT});
            this.displayDataGridView.DataSource = this.categoryModelBindingSource;
            this.displayDataGridView.Location = new System.Drawing.Point(35, 200);
            this.displayDataGridView.Name = "displayDataGridView";
            this.displayDataGridView.Size = new System.Drawing.Size(547, 288);
            this.displayDataGridView.TabIndex = 5;
            this.displayDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.displayDataGridView_CellContentClick);
            this.displayDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.displayDataGridView_RowPostPaint);
            // 
            // serachCodeButton
            // 
            this.serachCodeButton.Location = new System.Drawing.Point(374, 22);
            this.serachCodeButton.Name = "serachCodeButton";
            this.serachCodeButton.Size = new System.Drawing.Size(75, 23);
            this.serachCodeButton.TabIndex = 8;
            this.serachCodeButton.Text = "Search";
            this.serachCodeButton.UseVisualStyleBackColor = true;
            this.serachCodeButton.Click += new System.EventHandler(this.serachCodeButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.updateButton);
            this.groupBox2.Controls.Add(this.searchNameButton);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.serachCodeButton);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.saveButton);
            this.groupBox2.Controls.Add(this.codeTextBox);
            this.groupBox2.Controls.Add(this.nameTextBox);
            this.groupBox2.Location = new System.Drawing.Point(35, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(547, 138);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Entry";
            // 
            // searchNameButton
            // 
            this.searchNameButton.Location = new System.Drawing.Point(374, 63);
            this.searchNameButton.Name = "searchNameButton";
            this.searchNameButton.Size = new System.Drawing.Size(75, 23);
            this.searchNameButton.TabIndex = 9;
            this.searchNameButton.Text = "Search";
            this.searchNameButton.UseVisualStyleBackColor = true;
            this.searchNameButton.Click += new System.EventHandler(this.searchNameButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Code";
            // 
            // nextPageButton
            // 
            this.nextPageButton.Location = new System.Drawing.Point(259, 521);
            this.nextPageButton.Name = "nextPageButton";
            this.nextPageButton.Size = new System.Drawing.Size(75, 23);
            this.nextPageButton.TabIndex = 11;
            this.nextPageButton.Text = "Next";
            this.nextPageButton.UseVisualStyleBackColor = true;
            // 
            // SL
            // 
            this.SL.HeaderText = "SL";
            this.SL.Name = "SL";
            // 
            // EDIT
            // 
            this.EDIT.HeaderText = "Action";
            this.EDIT.Name = "EDIT";
            this.EDIT.Text = "Edit";
            this.EDIT.UseColumnTextForButtonValue = true;
            this.EDIT.Width = 85;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(125, 109);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 10;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Visible = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // categoryModelBindingSource
            // 
            this.categoryModelBindingSource.DataSource = typeof(Module1.Model.CategoryModel);
            // 
            // categoryRepositoryBindingSource1
            // 
            this.categoryRepositoryBindingSource1.DataSource = typeof(Module1.Repository.CategoryRepository);
            // 
            // productCategoryUiBindingSource
            // 
            this.productCategoryUiBindingSource.DataSource = typeof(Module1.ProductCategoryUi);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(117, 156);
            this.idTextBox.MaxLength = 4;
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(217, 20);
            this.idTextBox.TabIndex = 12;
            this.idTextBox.Visible = false;
            // 
            // ProductCategoryUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 556);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.nextPageButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.displayDataGridView);
            this.Name = "ProductCategoryUi";
            this.Text = "Product Category";
            this.Load += new System.EventHandler(this.ProductCategoryUi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.displayDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryRepositoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryRepositoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryUiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView displayDataGridView;
        private System.Windows.Forms.Button serachCodeButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button nextPageButton;
        private System.Windows.Forms.Button searchNameButton;
        private System.Windows.Forms.BindingSource categoryRepositoryBindingSource;
        private System.Windows.Forms.BindingSource categoryModelBindingSource;
        private System.Windows.Forms.BindingSource categoryRepositoryBindingSource1;
        private System.Windows.Forms.BindingSource productCategoryUiBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EDIT;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox idTextBox;
    }
}

