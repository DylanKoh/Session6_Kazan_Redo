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
        }


        private void btnAllocate_Click(object sender, EventArgs e)
        {
            if (cbAllocationMethod.SelectedItem == null)
            {
                MessageBox.Show("Please select your allocation method!","Allocate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbAllocationMethod.SelectedItem.ToString() == "FIFO")
            {
                
            }
            else if (cbAllocationMethod.SelectedItem.ToString() == "LIFO")
            {

            }
            else if (cbAllocationMethod.SelectedItem.ToString() == "Minimum First")
            {

            }
            
        }
    }
}
