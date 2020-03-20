using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session6_Kazan_Redo
{
    public partial class InventoryDashboard : Form
    {
        public InventoryDashboard()
        {
            InitializeComponent();
        }

        private void InventoryDashboard_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btnInventoryControl_Click(object sender, EventArgs e)
        {
            (new InventoryControl()).ShowDialog();
            LoadGrid();
        }

        private void LoadGrid()
        {
            #region Clearing all rows and columns of all data bounded views
            dgvSpending.Rows.Clear();
            dgvSpending.Columns.Clear();
            dgvMostUsed.Rows.Clear();
            dgvMostUsed.Columns.Clear();
            dgvCostlyAssets.Rows.Clear();
            dgvCostlyAssets.Rows.Clear();
            cDepartmentSpendingRatio.Series.Clear();
            cMonthlyDepartmentSpending.Series.Clear();
            #endregion

            dgvSpending.Columns.Add("Department/Month", "Department/Month");
            dgvMostUsed.Columns.Add("Notes/Month", "Notes/Month");
            dgvCostlyAssets.Columns.Add("Asset Name/Month", "Asset Name/Month");
            using (var context = new Session6Entities())
            {

                var getDepartments = (from x in context.EmergencyMaintenances
                                      where x.EMStartDate != null && x.EMEndDate != null
                                      select x.Asset.DepartmentLocation.Department.Name).Distinct();

                var getDistinctDatesInitial = (from x in context.Orders
                                               where x.EmergencyMaintenance.EMStartDate != null && x.EmergencyMaintenance.EMEndDate != null
                                               orderby x.Date descending
                                               select  x.Date ).ToList();
                var getDistinctDates = (from x in getDistinctDatesInitial
                                        select x.ToString("yyyy/MM")).Distinct().Take(10);

                foreach (var distinctDates in getDistinctDates)
                {
                    dgvSpending.Columns.Add(distinctDates, distinctDates);
                    dgvMostUsed.Columns.Add(distinctDates, distinctDates);
                    dgvCostlyAssets.Columns.Add(distinctDates, distinctDates);

                }

                foreach (var departments in getDepartments)
                {
                    var row = new List<string>();
                    row.Add(departments);
                    foreach (var distinctDates in getDistinctDates)
                    {
                        var getList = (from x in context.Orders
                                       where x.EmergencyMaintenance.EMStartDate != null && x.EmergencyMaintenance.EMEndDate != null
                                       where x.EmergencyMaintenance.Asset.DepartmentLocation.Department.Name == departments
                                       select x).ToList();
                        var getSpendings = (from x in getList
                                            where x.Date.ToString("yyyy/MM") == distinctDates
                                            select x.OrderItems.Sum(z => z.Amount * z.UnitPrice)).Sum().Value.ToString("0");
                        row.Add(getSpendings);



                    }
                    dgvSpending.Rows.Add(row.ToArray());
                }

                foreach (DataGridViewColumn column in dgvSpending.Columns)
                {
                    if (dgvSpending.Columns[column.Index].Index == 0)
                    {
                        continue;
                    }
                    else
                    {
                        var dict = new Dictionary<int, decimal>();
                        foreach (DataGridViewRow row in dgvSpending.Rows)
                        {
                            dict.Add(row.Index, Convert.ToDecimal(dgvSpending.Rows[row.Index].Cells[column.Index].Value));
                        }
                        var getMax = (from x in dict
                                      orderby x.Value descending
                                      where x.Value != 0
                                      select x.Key).First();
                        var getMin = (from x in dict
                                      orderby x.Value
                                      where x.Value != 0
                                      select x.Key).First();
                        if (getMin == getMax)
                        {
                            dgvSpending.Rows[getMin].Cells[column.Index].Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            dgvSpending.Rows[getMin].Cells[column.Index].Style.ForeColor = Color.Red;
                            dgvSpending.Rows[getMax].Cells[column.Index].Style.ForeColor = Color.Green;
                        }
                    }
                }


            }



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

