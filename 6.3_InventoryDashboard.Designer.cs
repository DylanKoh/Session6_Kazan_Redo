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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSpending = new System.Windows.Forms.DataGridView();
            this.cDepartmentSpendingRatio = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cMonthlyDepartmentSpending = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvMostUsed = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvCostlyAssets = new System.Windows.Forms.DataGridView();
            this.btnInventoryControl = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDepartmentSpendingRatio)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cMonthlyDepartmentSpending)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostUsed)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostlyAssets)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSpending);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(565, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EM Spending by Department";
            // 
            // dgvSpending
            // 
            this.dgvSpending.AllowUserToAddRows = false;
            this.dgvSpending.AllowUserToDeleteRows = false;
            this.dgvSpending.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSpending.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSpending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSpending.Location = new System.Drawing.Point(2, 15);
            this.dgvSpending.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvSpending.Name = "dgvSpending";
            this.dgvSpending.RowHeadersWidth = 51;
            this.dgvSpending.RowTemplate.Height = 24;
            this.dgvSpending.Size = new System.Drawing.Size(561, 137);
            this.dgvSpending.TabIndex = 0;
            // 
            // cDepartmentSpendingRatio
            // 
            chartArea1.Name = "ChartArea1";
            this.cDepartmentSpendingRatio.ChartAreas.Add(chartArea1);
            this.cDepartmentSpendingRatio.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.cDepartmentSpendingRatio.Legends.Add(legend1);
            this.cDepartmentSpendingRatio.Location = new System.Drawing.Point(2, 15);
            this.cDepartmentSpendingRatio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cDepartmentSpendingRatio.Name = "cDepartmentSpendingRatio";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.cDepartmentSpendingRatio.Series.Add(series1);
            this.cDepartmentSpendingRatio.Size = new System.Drawing.Size(305, 275);
            this.cDepartmentSpendingRatio.TabIndex = 1;
            this.cDepartmentSpendingRatio.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cDepartmentSpendingRatio);
            this.groupBox2.Location = new System.Drawing.Point(578, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(309, 292);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Department Spending Ratio";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cMonthlyDepartmentSpending);
            this.groupBox3.Location = new System.Drawing.Point(578, 307);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(307, 242);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Monthly Department Spending";
            // 
            // cMonthlyDepartmentSpending
            // 
            chartArea2.Name = "ChartArea1";
            this.cMonthlyDepartmentSpending.ChartAreas.Add(chartArea2);
            this.cMonthlyDepartmentSpending.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.cMonthlyDepartmentSpending.Legends.Add(legend2);
            this.cMonthlyDepartmentSpending.Location = new System.Drawing.Point(2, 15);
            this.cMonthlyDepartmentSpending.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cMonthlyDepartmentSpending.Name = "cMonthlyDepartmentSpending";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.cMonthlyDepartmentSpending.Series.Add(series2);
            this.cMonthlyDepartmentSpending.Size = new System.Drawing.Size(303, 225);
            this.cMonthlyDepartmentSpending.TabIndex = 0;
            this.cMonthlyDepartmentSpending.Text = "chart2";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvMostUsed);
            this.groupBox4.Location = new System.Drawing.Point(9, 168);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(565, 158);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Monthly Report for Most-Used Parts";
            // 
            // dgvMostUsed
            // 
            this.dgvMostUsed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMostUsed.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMostUsed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostUsed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMostUsed.Location = new System.Drawing.Point(2, 15);
            this.dgvMostUsed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMostUsed.Name = "dgvMostUsed";
            this.dgvMostUsed.RowHeadersWidth = 51;
            this.dgvMostUsed.RowTemplate.Height = 24;
            this.dgvMostUsed.Size = new System.Drawing.Size(561, 141);
            this.dgvMostUsed.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvCostlyAssets);
            this.groupBox5.Location = new System.Drawing.Point(9, 331);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Size = new System.Drawing.Size(565, 158);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Monthly Report of Costly Assets";
            // 
            // dgvCostlyAssets
            // 
            this.dgvCostlyAssets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCostlyAssets.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCostlyAssets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCostlyAssets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCostlyAssets.Location = new System.Drawing.Point(2, 15);
            this.dgvCostlyAssets.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCostlyAssets.Name = "dgvCostlyAssets";
            this.dgvCostlyAssets.RowHeadersWidth = 51;
            this.dgvCostlyAssets.RowTemplate.Height = 24;
            this.dgvCostlyAssets.Size = new System.Drawing.Size(561, 141);
            this.dgvCostlyAssets.TabIndex = 0;
            // 
            // btnInventoryControl
            // 
            this.btnInventoryControl.Location = new System.Drawing.Point(14, 518);
            this.btnInventoryControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInventoryControl.Name = "btnInventoryControl";
            this.btnInventoryControl.Size = new System.Drawing.Size(106, 28);
            this.btnInventoryControl.TabIndex = 6;
            this.btnInventoryControl.Text = "Inventory Control";
            this.btnInventoryControl.UseVisualStyleBackColor = true;
            this.btnInventoryControl.Click += new System.EventHandler(this.btnInventoryControl_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(124, 518);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 28);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 526);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Language: ";
            // 
            // cbLanguage
            // 
            this.cbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Location = new System.Drawing.Point(448, 523);
            this.cbLanguage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(125, 21);
            this.cbLanguage.TabIndex = 9;
            // 
            // InventoryDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 574);
            this.Controls.Add(this.cbLanguage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnInventoryControl);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "InventoryDashboard";
            this.Text = "Inventory Dashboard";
            this.Load += new System.EventHandler(this.InventoryDashboard_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpending)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDepartmentSpendingRatio)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cMonthlyDepartmentSpending)).EndInit();
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

