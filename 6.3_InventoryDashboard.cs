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
                var getDepartments = (from x in context.Departments
                                      select x.Name).Distinct();
                var getOrders = (from x in context.Orders
                                 where x.EmergencyMaintenance.EMStartDate != null && x.EmergencyMaintenance.EMEndDate != null
                                 orderby x.Date descending
                                 select x).ToList();
                var getGroupingByDates = (from x in getOrders
                                          group x by x.Date.ToString("yyyy/MM") into y
                                          select y);

                foreach (var distinctDates in getGroupingByDates.Distinct().Take(10))
                {
                    dgvSpending.Columns.Add(distinctDates.Key, distinctDates.Key);
                    dgvMostUsed.Columns.Add(distinctDates.Key, distinctDates.Key);
                    dgvSpending.Columns.Add(distinctDates.Key, distinctDates.Key);

                }

                foreach (var departments in getDepartments)
                {
                    var row = new List<string>();
                    row.Add(departments);
                    foreach (var distinctDates in getGroupingByDates.Distinct().Take(10))
                    {
                        var getList = (from x in context.Orders
                                       where x.EmergencyMaintenance.EMStartDate != null && x.EmergencyMaintenance.EMEndDate != null
                                       where x.EmergencyMaintenance.Asset.DepartmentLocation.Department.Name == departments
                                       select x).ToList();
                        var getSpendings = (from x in getList
                                            where x.Date.ToString("yyyy/MM") == distinctDates.Key
                                            select x.OrderItems.Sum(z => z.Amount * z.UnitPrice)).Sum().Value.ToString("0");
                        row.Add(getSpendings);



                    }
                    dgvSpending.Rows.Add(row.ToArray());
                }


            }



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

