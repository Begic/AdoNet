namespace AdoNet.UI
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
            label1 = new Label();
            label2 = new Label();
            txtbox_FirstName = new TextBox();
            txtbox_LastName = new TextBox();
            btnAdd = new Button();
            dataGrid = new DataGridView();
            cboxAllCustomer = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Vorname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 7);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 1;
            label2.Text = "Nachname";
            // 
            // txtbox_FirstName
            // 
            txtbox_FirstName.Location = new Point(10, 24);
            txtbox_FirstName.Margin = new Padding(3, 2, 3, 2);
            txtbox_FirstName.Name = "txtbox_FirstName";
            txtbox_FirstName.Size = new Size(195, 23);
            txtbox_FirstName.TabIndex = 2;
            // 
            // txtbox_LastName
            // 
            txtbox_LastName.Location = new Point(212, 24);
            txtbox_LastName.Margin = new Padding(3, 2, 3, 2);
            txtbox_LastName.Name = "txtbox_LastName";
            txtbox_LastName.Size = new Size(195, 23);
            txtbox_LastName.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(10, 349);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(396, 22);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "HINZUFÜGEN";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataGrid
            // 
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(10, 74);
            dataGrid.Margin = new Padding(3, 2, 3, 2);
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersWidth = 51;
            dataGrid.RowTemplate.Height = 29;
            dataGrid.Size = new Size(396, 270);
            dataGrid.TabIndex = 5;
            // 
            // cboxAllCustomer
            // 
            cboxAllCustomer.FormattingEnabled = true;
            cboxAllCustomer.Location = new Point(10, 49);
            cboxAllCustomer.Margin = new Padding(3, 2, 3, 2);
            cboxAllCustomer.Name = "cboxAllCustomer";
            cboxAllCustomer.Size = new Size(396, 23);
            cboxAllCustomer.TabIndex = 6;
            cboxAllCustomer.SelectedIndexChanged += cboxAllCustomer_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 380);
            Controls.Add(cboxAllCustomer);
            Controls.Add(dataGrid);
            Controls.Add(btnAdd);
            Controls.Add(txtbox_LastName);
            Controls.Add(txtbox_FirstName);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtbox_FirstName;
        private TextBox txtbox_LastName;
        private Button btnAdd;
        private DataGridView dataGrid;
        private ComboBox cboxAllCustomer;
    }
}