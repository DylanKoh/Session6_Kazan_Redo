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
    public partial class InventoryControl : Form
    {
        public InventoryControl()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InventoryControl_Load(object sender, EventArgs e)
        {
            using (var context = new Session6Entities())
            {
                #region Populating Combo Box for Asset Name
                var getAssetName = (from x in context.EmergencyMaintenances
                                    where x.EMEndDate == null
                                    select new { AssetName = x.Asset.AssetName, EMNumber = x.ID });
                foreach (var item in getAssetName)
                {
                    cbAssetName.Items.Add($"{item.AssetName} ({item.EMNumber})");
                }
                #endregion

                #region Populating Combo Box for Warehouses
                var getWarehouses = (from x in context.Warehouses
                                     select x.Name).Distinct().ToArray();
                cbWarehouse.Items.AddRange(getWarehouses);
                #endregion

                #region Populating Combo Box for Part
                var getParts = (from x in context.Parts
                                select x.Name).Distinct().ToArray();
                cbPartName.Items.AddRange(getParts);
                #endregion
            }
            var allocationMethodList = new List<string>() { "FIFO", "LIFO", "Minimum First" };
            cbAllocationMethod.Items.AddRange(allocationMethodList.ToArray());

            #region Loading Columns for Allocated Parts DGV
            dgvAllocatedParts.ColumnCount = 5;
            dgvAllocatedParts.Columns[0].Name = "Part ID";
            dgvAllocatedParts.Columns[1].Name = "Part Name";
            dgvAllocatedParts.Columns[2].Name = "Batch Number";
            dgvAllocatedParts.Columns[3].Name = "Unit Price";
            dgvAllocatedParts.Columns[4].Name = "Amount";
            dgvAllocatedParts.Columns[0].Visible = false;
            #endregion

            #region Adding Column for Link Cell for Assigned EM DGV
            var linkColumn = new DataGridViewLinkColumn
            {
                Text = "Remove",
                Name = "Actions",
                UseColumnTextForLinkValue = true
            };
            dgvAssignedParts.Columns.Add(linkColumn);
            #endregion
        }


        private void btnAllocate_Click(object sender, EventArgs e)
        {
            dgvAllocatedParts.Rows.Clear();
            var amt = nudAmount.Value;
            if (cbAllocationMethod.SelectedItem == null)
            {
                MessageBox.Show("Please select your allocation method!", "Allocate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbAllocationMethod.SelectedItem.ToString() == "FIFO")
            {
                var listToAdd = new List<OrderItem>();
                using (var context = new Session6Entities())
                {
                    var getRelatedParts = (from x in context.OrderItems
                                           where x.Part.Name == cbPartName.SelectedItem.ToString() && x.Order.Warehouse.Name == cbWarehouse.SelectedItem.ToString()
                                           orderby x.Order.Date
                                           select x);
                    foreach (var item in getRelatedParts)
                    {
                        if (amt == 0)
                        {
                            break;
                        }
                        if (item.Amount > amt)
                        {
                            continue;
                        }
                        else
                        {
                            listToAdd.Add(item);
                            amt -= item.Amount;
                        }
                    }
                    foreach (var item in listToAdd)
                    {
                        var row = new List<string>() { item.PartID.ToString(), item.Part.Name, item.BatchNumber, item.UnitPrice.ToString(), item.Amount.ToString() };
                        dgvAllocatedParts.Rows.Add(row.ToArray());
                    }
                }
            }
            else if (cbAllocationMethod.SelectedItem.ToString() == "LIFO")
            {
                var listToAdd = new List<OrderItem>();
                using (var context = new Session6Entities())
                {
                    var getRelatedParts = (from x in context.OrderItems
                                           where x.Part.Name == cbPartName.SelectedItem.ToString() && x.Order.Warehouse.Name == cbWarehouse.SelectedItem.ToString()
                                           orderby x.Order.Date descending
                                           select x);
                    foreach (var item in getRelatedParts)
                    {
                        if (amt == 0)
                        {
                            break;
                        }
                        if (item.Amount > amt)
                        {
                            continue;
                        }
                        else
                        {
                            listToAdd.Add(item);
                            amt -= item.Amount;
                        }
                    }
                    foreach (var item in listToAdd)
                    {
                        var row = new List<string>() { item.PartID.ToString(), item.Part.Name, item.BatchNumber, item.UnitPrice.ToString(), item.Amount.ToString() };
                        dgvAllocatedParts.Rows.Add(row.ToArray());
                    }
                }
            }
            else if (cbAllocationMethod.SelectedItem.ToString() == "Minimum First")
            {
                var listToAdd = new List<OrderItem>();
                using (var context = new Session6Entities())
                {
                    var getRelatedParts = (from x in context.OrderItems
                                           where x.Part.Name == cbPartName.SelectedItem.ToString() && x.Order.Warehouse.Name == cbWarehouse.SelectedItem.ToString()
                                           orderby x.UnitPrice * x.Amount
                                           select x);
                    foreach (var item in getRelatedParts)
                    {
                        if (amt == 0)
                        {
                            break;
                        }
                        if (item.Amount > amt)
                        {
                            continue;
                        }
                        else
                        {
                            listToAdd.Add(item);
                            amt -= item.Amount;
                        }
                    }
                    foreach (var item in listToAdd)
                    {
                        var row = new List<string>() { item.PartID.ToString(), item.Part.Name, item.BatchNumber, item.UnitPrice.ToString(), item.Amount.ToString() };
                        dgvAllocatedParts.Rows.Add(row.ToArray());
                    }
                }
            }

        }

        private void btnAssignToEM_Click(object sender, EventArgs e)
        {
            var toDelete = new List<string>();
            foreach (DataGridViewRow row in dgvAllocatedParts.Rows)
            {
                var newRow = new List<string>();
                toDelete.Add(dgvAllocatedParts.Rows[row.Index].Cells[1].Value.ToString());
                foreach (DataGridViewColumn cell in dgvAllocatedParts.Columns)
                {
                    newRow.Add(dgvAllocatedParts.Rows[row.Index].Cells[cell.Index].Value.ToString());
                }
                dgvAssignedParts.Rows.Add(newRow.ToArray());
            }
            dgvAllocatedParts.Rows.Clear();
            foreach (var item in toDelete.Distinct())
            {
                cbPartName.Items.Remove(item);
            }
        }

        private void dgvAssignedParts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                var response = MessageBox.Show("Are you sure you want to remove this item?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (response == DialogResult.Yes)
                {
                    dgvAssignedParts.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cbAssetName.SelectedItem == null)
            {
                MessageBox.Show("Please select your Asset!!", "Submit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var response = MessageBox.Show("Are you sure you want to submit?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (response == DialogResult.Yes)
                {
                    using (var context = new Session6Entities())
                    {
                        var getWarehouseID = (from x in context.Warehouses
                                              where x.Name == cbWarehouse.SelectedItem.ToString()
                                              select x.ID).First();
                        var getEMID = (from x in context.EmergencyMaintenances
                                       where x.Asset.AssetName + " (" + x.ID + ")" == cbAssetName.SelectedItem.ToString()
                                       select x.ID).First();
                        var getNewOrderID = (from x in context.Orders
                                             orderby x.ID descending
                                             select x.ID).First() + 1;
                        context.Orders.Add(new Order()
                        {
                            ID = getNewOrderID,
                            Date = dtpDate.Value,
                            DestinationWarehouseID = null,
                            EmergencyMaintenancesID = getEMID,
                            SourceWarehouseID = getWarehouseID,
                            SupplierID = null,
                            TransactionTypeID = 3,
                            Time = DateTime.Now.TimeOfDay
                        });
                        context.SaveChanges();

                        foreach (DataGridViewRow item in dgvAssignedParts.Rows)
                        {
                            context.OrderItems.Add(new OrderItem()
                            {
                                PartID = Convert.ToInt64(dgvAssignedParts.Rows[item.Index].Cells[0].Value),
                                BatchNumber = dgvAssignedParts.Rows[item.Index].Cells[2].Value.ToString(),
                                Amount = Convert.ToDecimal(dgvAssignedParts.Rows[item.Index].Cells[4].Value),
                                UnitPrice = Convert.ToDecimal(dgvAssignedParts.Rows[item.Index].Cells[3].Value),
                                OrderID = getNewOrderID
                            });
                        }
                        context.SaveChanges();
                    }
                    this.Close();
                }
            }
        }
    }
}
