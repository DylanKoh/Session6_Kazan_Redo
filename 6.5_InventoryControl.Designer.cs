namespace Session6_Kazan_Redo
{
    partial class InventoryControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbAssetName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbWarehouse = new System.Windows.Forms.ComboBox();
            this.cbPartName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nupAmount = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cbAllocationMethod = new System.Windows.Forms.ComboBox();
            this.btnAllocate = new System.Windows.Forms.Button();
            this.dgvAllocatedParts = new System.Windows.Forms.DataGridView();
            this.btnAssignToEM = new System.Windows.Forms.Button();
            this.dgvAssignedParts = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllocatedParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedParts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asset Name (EM Number): ";
            // 
            // cbAssetName
            // 
            this.cbAssetName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAssetName.FormattingEnabled = true;
            this.cbAssetName.Location = new System.Drawing.Point(195, 13);
            this.cbAssetName.Name = "cbAssetName";
            this.cbAssetName.Size = new System.Drawing.Size(544, 24);
            this.cbAssetName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(811, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date: ";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(863, 11);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(118, 22);
            this.dtpDate.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAllocate);
            this.groupBox1.Controls.Add(this.cbAllocationMethod);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nupAmount);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbPartName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbWarehouse);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1152, 156);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search for Parts: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAssignToEM);
            this.groupBox2.Controls.Add(this.dgvAllocatedParts);
            this.groupBox2.Location = new System.Drawing.Point(12, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1152, 188);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Allocated Parts: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvAssignedParts);
            this.groupBox3.Location = new System.Drawing.Point(12, 444);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1152, 199);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Assigned Parts: ";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(398, 649);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(91, 35);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(677, 649);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 35);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Warehouse: ";
            // 
            // cbWarehouse
            // 
            this.cbWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWarehouse.FormattingEnabled = true;
            this.cbWarehouse.Location = new System.Drawing.Point(102, 19);
            this.cbWarehouse.Name = "cbWarehouse";
            this.cbWarehouse.Size = new System.Drawing.Size(496, 24);
            this.cbWarehouse.TabIndex = 1;
            // 
            // cbPartName
            // 
            this.cbPartName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPartName.FormattingEnabled = true;
            this.cbPartName.Location = new System.Drawing.Point(102, 62);
            this.cbPartName.Name = "cbPartName";
            this.cbPartName.Size = new System.Drawing.Size(496, 24);
            this.cbPartName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Part Name: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(604, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Amount: ";
            // 
            // nupAmount
            // 
            this.nupAmount.DecimalPlaces = 2;
            this.nupAmount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nupAmount.Location = new System.Drawing.Point(674, 63);
            this.nupAmount.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nupAmount.Name = "nupAmount";
            this.nupAmount.Size = new System.Drawing.Size(97, 22);
            this.nupAmount.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(777, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Allocation Method: ";
            // 
            // cbAllocationMethod
            // 
            this.cbAllocationMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAllocationMethod.FormattingEnabled = true;
            this.cbAllocationMethod.Location = new System.Drawing.Point(912, 60);
            this.cbAllocationMethod.Name = "cbAllocationMethod";
            this.cbAllocationMethod.Size = new System.Drawing.Size(234, 24);
            this.cbAllocationMethod.TabIndex = 7;
            // 
            // btnAllocate
            // 
            this.btnAllocate.Location = new System.Drawing.Point(912, 103);
            this.btnAllocate.Name = "btnAllocate";
            this.btnAllocate.Size = new System.Drawing.Size(234, 32);
            this.btnAllocate.TabIndex = 8;
            this.btnAllocate.Text = "Allocate";
            this.btnAllocate.UseVisualStyleBackColor = true;
            // 
            // dgvAllocatedParts
            // 
            this.dgvAllocatedParts.AllowUserToAddRows = false;
            this.dgvAllocatedParts.AllowUserToDeleteRows = false;
            this.dgvAllocatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllocatedParts.Location = new System.Drawing.Point(6, 21);
            this.dgvAllocatedParts.Name = "dgvAllocatedParts";
            this.dgvAllocatedParts.RowHeadersWidth = 51;
            this.dgvAllocatedParts.RowTemplate.Height = 24;
            this.dgvAllocatedParts.Size = new System.Drawing.Size(963, 150);
            this.dgvAllocatedParts.TabIndex = 0;
            // 
            // btnAssignToEM
            // 
            this.btnAssignToEM.Location = new System.Drawing.Point(975, 138);
            this.btnAssignToEM.Name = "btnAssignToEM";
            this.btnAssignToEM.Size = new System.Drawing.Size(171, 33);
            this.btnAssignToEM.TabIndex = 1;
            this.btnAssignToEM.Text = "+ Assign to EM";
            this.btnAssignToEM.UseVisualStyleBackColor = true;
            // 
            // dgvAssignedParts
            // 
            this.dgvAssignedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignedParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAssignedParts.Location = new System.Drawing.Point(3, 18);
            this.dgvAssignedParts.Name = "dgvAssignedParts";
            this.dgvAssignedParts.RowHeadersWidth = 51;
            this.dgvAssignedParts.RowTemplate.Height = 24;
            this.dgvAssignedParts.Size = new System.Drawing.Size(1146, 178);
            this.dgvAssignedParts.TabIndex = 0;
            // 
            // InventoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 696);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAssetName);
            this.Controls.Add(this.label1);
            this.Name = "InventoryControl";
            this.Text = "Inventory Control";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nupAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllocatedParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAssetName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAllocate;
        private System.Windows.Forms.ComboBox cbAllocationMethod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nupAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbPartName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbWarehouse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvAllocatedParts;
        private System.Windows.Forms.Button btnAssignToEM;
        private System.Windows.Forms.DataGridView dgvAssignedParts;
    }
}