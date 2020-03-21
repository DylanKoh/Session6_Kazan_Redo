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
                                               select x.Date).ToList();
                var getDistinctDates = (from x in getDistinctDatesInitial
                                        select x.ToString("yyyy/MM")).Distinct().Take(10);

                foreach (var distinctDates in getDistinctDates)
                {
                    dgvSpending.Columns.Add(distinctDates, distinctDates);
                    dgvMostUsed.Columns.Add(distinctDates, distinctDates);
                    dgvCostlyAssets.Columns.Add(distinctDates, distinctDates);

                }

                #region Populating 1st DGV
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
                #endregion

                #region Populating 2nd DGV
                var getDistinctParts = (from x in context.Parts
                                        select x.Name).Distinct();
                var highestCostRow = new List<string>() { "Highest Cost" };
                var mostNumberRow = new List<string>() { "Most Number" };

                foreach (var distinctDates in getDistinctDates)
                {
                    var highestCostDict = new Dictionary<string, decimal>();
                    var mostNumberDict = new Dictionary<string, decimal>();
                    foreach (var item in getDistinctParts)
                    {
                        var initialQuery = (from x in context.Orders
                                            where x.EmergencyMaintenance.EMEndDate != null && x.EmergencyMaintenance.EMStartDate != null
                                            select x).ToList();

                        var getSpendings = (from x in initialQuery
                                            where x.Date.ToString("yyyy/MM") == distinctDates
                                            select x.OrderItems.Where(y => y.Part.Name == item).Sum(y => y.Amount * y.UnitPrice)).Sum();

                        highestCostDict.Add(item, Convert.ToDecimal(getSpendings));

                        var getAmount = (from x in initialQuery
                                         where x.Date.ToString("yyyy/MM") == distinctDates
                                         select x.OrderItems.Where(y => y.Part.Name == item).Sum(y => y.Amount)).Sum();
                        mostNumberDict.Add(item, getAmount);
                    }
                    var getHighestCost = (from x in highestCostDict
                                          orderby x.Value descending
                                          where x.Value != 0
                                          select x.Key).First();
                    highestCostRow.Add(getHighestCost);
                    var getMostNumber = (from x in mostNumberDict
                                         orderby x.Value descending
                                         where x.Value != 0
                                         select x.Key).First();
                    mostNumberRow.Add(getMostNumber);

                }
                dgvMostUsed.Rows.Add(highestCostRow.ToArray());
                dgvMostUsed.Rows.Add(mostNumberRow.ToArray());
                #endregion

                #region Populating 3rd DGV
                var assetRow = new List<string>() { "Asset" };
                var departmentRow = new List<string>() { "Department" };
                var getDistinctAssets = (from x in context.Assets
                                         select x.AssetName).Distinct();
                foreach (var distinctDates in getDistinctDates)
                {
                    var assetSpendings = new Dictionary<string, decimal>();
                    var assetDepartment = new Dictionary<string, string>();
                    foreach (var item in getDistinctAssets)
                    {
                        var initialQuery = (from x in context.Orders
                                            where x.EmergencyMaintenance.EMEndDate != null && x.EmergencyMaintenance.EMStartDate != null
                                            select x).ToList();
                        var getAssetSpendings = (from x in initialQuery
                                                 where x.Date.ToString("yyyy/MM") == distinctDates && x.EmergencyMaintenance.Asset.AssetName == item
                                                 select x.OrderItems.Sum(y => y.Amount * y.UnitPrice)).Sum();

                        var getAssetDepartment = (from x in context.Assets
                                                  where x.AssetName == item
                                                  select x.DepartmentLocation.Department.Name).FirstOrDefault();
                        assetSpendings.Add(item, Convert.ToDecimal(getAssetSpendings));
                        assetDepartment.Add(item, getAssetDepartment);

                    }

                    var getHighestSpendingAsset = (from x in assetSpendings
                                                   where x.Value != 0
                                                   orderby x.Value descending
                                                   select x.Value).FirstOrDefault();
                    var checkNumberofAssets = (from x in assetSpendings
                                               where x.Value == getHighestSpendingAsset
                                               select x.Key).ToList();

                    if (checkNumberofAssets.Count == 1)
                    {
                        assetRow.Add(checkNumberofAssets.First());

                        var getDepartment = (from x in assetDepartment
                                             where x.Key == checkNumberofAssets.First()
                                             select x.Value).First();
                        departmentRow.Add(getDepartment);
                    }
                    else
                    {
                        var toAddAsset = string.Empty;
                        var toAddDepartment = string.Empty;
                        foreach (var item in checkNumberofAssets)
                        {
                            if (toAddAsset == string.Empty)
                            {
                                toAddAsset = item;

                                var getDepartment = (from x in assetDepartment
                                                     where x.Key == item
                                                     select x.Value).First();
                                toAddDepartment = getDepartment;
                            }
                            else
                            {
                                toAddAsset += $", {item}";

                                var getDepartment = (from x in assetDepartment
                                                     where x.Key == item
                                                     select x.Value).First();
                                toAddDepartment += $", {getDepartment}";
                            }
                        }
                        assetRow.Add(toAddAsset);
                        departmentRow.Add(toAddDepartment);
                    }
                    
                }
                dgvCostlyAssets.Rows.Add(assetRow.ToArray());
                dgvCostlyAssets.Rows.Add(departmentRow.ToArray());
                #endregion

            }



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

