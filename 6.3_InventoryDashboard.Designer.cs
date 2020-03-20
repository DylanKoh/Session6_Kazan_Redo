namespace Session6_Kazan_Redo
{
    partial class InventoryDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cDepartmentSpendingRatio = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cMonthlyDepartmentSpending = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvSpending = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvMostUsed = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvCostlyAssets = new System.Windows.Forms.DataGridView();
            this.btnInventoryControl = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cDepartmentSpendingRatio)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cMonthlyDepartmentSpending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpending)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostUsed)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostlyAssets)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSpending);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EM Spending by Department";
            // 
            // cDepartmentSpendingRatio
            // 
            chartArea5.Name = "ChartArea1";
            this.cDepartmentSpendingRatio.ChartAreas.Add(chartArea5);
            this.cDepartmentSpendingRatio.Dock = System.Windows.Forms.DockStyle.Fill;
            legend5.Name = "Legend1";
            this.cDepartmentSpendingRatio.Legends.Add(legend5);
            this.cDepartmentSpendingRatio.Location = new System.Drawing.Point(3, 18);
            this.cDepartmentSpendingRatio.Name = "cDepartmentSpendingRatio";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.cDepartmentSpendingRatio.Series.Add(series5);
            this.cDepartmentSpendingRatio.Size = new System.Drawing.Size(406, 339);
            this.cDepartmentSpendingRatio.TabIndex = 1;
            this.cDepartmentSpendingRatio.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cDepartmentSpendingRatio);
            this.groupBox2.Location = new System.Drawing.Point(771, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 360);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Department Spending Ratio";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cMonthlyDepartmentSpending);
            this.groupBox3.Location = new System.Drawing.Point(771, 378);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(409, 298);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Monthly Department Spending";
            // 
            // cMonthlyDepartmentSpending
            // 
            chartArea6.Name = "ChartArea1";
            this.cMonthlyDepartmentSpending.ChartAreas.Add(chartArea6);
            this.cMonthlyDepartmentSpending.Dock = System.Windows.Forms.DockStyle.Fill;
            legend6.Name = "Legend1";
            this.cMonthlyDepartmentSpending.Legends.Add(legend6);
            this.cMonthlyDepartmentSpending.Location = new System.Drawing.Point(3, 18);
            this.cMonthlyDepartmentSpending.Name = "cMonthlyDepartmentSpending";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.cMonthlyDepartmentSpending.Series.Add(series6);
            this.cMonthlyDepartmentSpending.Size = new System.Drawing.Size(403, 277);
            this.cMonthlyDepartmentSpending.TabIndex = 0;
            this.cMonthlyDepartmentSpending.Text = "chart2";
            // 
            // dgvSpending
            // 
            this.dgvSpending.AllowUserToAddRows = false;
            this.dgvSpending.AllowUserToDeleteRows = false;
            this.dgvSpending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSpending.Location = new System.Drawing.Point(3, 18);
            this.dgvSpending.Name = "dgvSpending";
            this.dgvSpending.RowHeadersWidth = 51;
            this.dgvSpending.RowTemplate.Height = 24;
            this.dgvSpending.Size = new System.Drawing.Size(747, 168);
            this.dgvSpending.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvMostUsed);
            this.groupBox4.Location = new System.Drawing.Point(12, 207);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(753, 194);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Monthly Report for Most-Used Parts";
            // 
            // dgvMostUsed
            // 
            this.dgvMostUsed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostUsed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMostUsed.Location = new System.Drawing.Point(3, 18);
            this.dgvMostUsed.Name = "dgvMostUsed";
            this.dgvMostUsed.RowHeadersWidth = 51;
            this.dgvMostUsed.RowTemplate.Height = 24;
            this.dgvMostUsed.Size = new System.Drawing.Size(747, 173);
            this.dgvMostUsed.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvCostlyAssets);
            this.groupBox5.Location = new System.Drawing.Point(12, 407);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(753, 194);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Monthly Report of Costly Assets";
            // 
            // dgvCostlyAssets
            // 
            this.dgvCostlyAssets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCostlyAssets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCostlyAssets.Location = new System.Drawing.Point(3, 18);
            this.dgvCostlyAssets.Name = "dgvCostlyAssets";
            this.dgvCostlyAssets.RowHeadersWidth = 51;
            this.dgvCostlyAssets.RowTemplate.Height = 24;
            this.dgvCostlyAssets.Size = new System.Drawing.Size(747, 173);
            this.dgvCostlyAssets.TabIndex = 0;
            // 
            // btnInventoryControl
            // 
            this.btnInventoryControl.Location = new System.Drawing.Point(18, 638);
            this.btnInventoryControl.Name = "btnInventoryControl";
            this.btnInventoryControl.Size = new System.Drawing.Size(142, 35);
            this.btnInventoryControl.TabIndex = 6;
            this.btnInventoryControl.Text = "Inventory Control";
            this.btnInventoryControl.UseVisualStyleBackColor = true;
            this.btnInventoryControl.Click += new System.EventHandler(this.btnInventoryControl_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(166, 638);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(142, 35);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(511, 647);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Language: ";
            // 
            // cbLanguage
            // 
            this.cbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Location = new System.Drawing.Point(597, 644);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(165, 24);
            this.cbLanguage.TabIndex = 9;
            // 
            // InventoryDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 707);
            this.Controls.Add(this.cbLanguage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnInventoryControl);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "InventoryDashboard";
            this.Text = "Inventory Dashboard";
            this.Load += new System.EventHandler(this.InventoryDashboard_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cDepartmentSpendingRatio)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cMonthlyDepartmentSpending)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpending)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostUsed)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostlyAssets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart cDepartmentSpendingRatio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart cMonthlyDepartmentSpending;
        private System.Windows.Forms.DataGridView dgvSpending;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvMostUsed;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvCostlyAssets;
        private System.Windows.Forms.Button btnInventoryControl;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLanguage;
    }
}

