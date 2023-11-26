using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClassTestLastYearRevision
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tb_ModuleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'universityDataSet.tb_ModuleType' table. You can move, or remove it, as needed.
                this.tb_ModuleTypeTableAdapter.Fill(this.universityDataSet.tb_ModuleType);
                // TODO: This line of code loads data into the 'universityDataSet.tb_Module' table. You can move, or remove it, as needed.
                this.tb_ModuleTableAdapter.Fill(this.universityDataSet.tb_Module);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // Save Button function
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }



        // Save function to Call inside SaveButton
        private void SaveData()
        {
            if (this.Validate() && ValidateSave())
            {
                try
                {
                    this.tb_ModuleBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.universityDataSet);
                    MessageBox.Show("saved successfully!");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

        }

        // Validation Save Function
        private bool ValidateSave()
        {
            if (string.IsNullOrEmpty(tbxCode.Text))
            {
                MessageBox.Show("Module code cannot be empty!");
                return false;
            }
            else if (string.IsNullOrEmpty(tbxName.Text))
            {
                MessageBox.Show("Module name cannot be empty!");
                return false;
            }
            else if (string.IsNullOrEmpty(cbxType.Text))
            {
                MessageBox.Show("Module type cannot be empty!");
                return false;
            }
            else if (string.IsNullOrEmpty(nudYear.Text))
            {
                MessageBox.Show("Year cannot be empty");
                return false;
            }
            return true;
        }


        // To Filter the Module list
        private void tbxFilter_TextChanged(object sender, EventArgs e)
        {
            tb_ModuleBindingSource.Filter = $"ModuleName LIKE '%{tbxFilter.Text}%'";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tb_ModuleBindingSource.Count > 0)
            {
                var response = MessageBox.Show("Sure?", "Delete", MessageBoxButtons.YesNo);

                if (response == DialogResult.Yes)
                {
                    tb_ModuleBindingSource.RemoveCurrent();
                }
            }
            else
            {
                MessageBox.Show("No more records");
            }
        }


        // Add Button Function
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var name = tbxNewName.Text;
            var code = tbxNewCode.Text;
            var year = (int)nudNewYear.Value;

            var moduleType = ((DataRowView)cbxNewType.SelectedItem).Row;

            if (ValidateAdd())
            {
                try
                {
                    universityDataSet.tb_Module.Addtb_ModuleRow(
                    code, name, year,
                    (UniversityDataSet.tb_ModuleTypeRow)moduleType
                    );

                    MessageBox.Show("Added Successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }


        // Validating Add Function
        private bool ValidateAdd()
        {
            if (string.IsNullOrEmpty(tbxNewCode.Text))
            {
                MessageBox.Show("Module code cannot be empty!");
                return false;
            }
            else if (string.IsNullOrEmpty(tbxNewName.Text))
            {
                MessageBox.Show("Module name cannot be empty!");
                return false;
            }
            else if (string.IsNullOrEmpty(cbxNewType.Text))
            {
                MessageBox.Show("Module type cannot be empty!");
                return false;
            }
            else if (string.IsNullOrEmpty(nudNewYear.Text))
            {
                MessageBox.Show("Year cannot be empty");
                return false;
            }
            return true;
        }

        // Form Closing, when we are pressing X to close the forum
        // validation should work to check if there is a data that has not been saved
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Validate())
            {
                this.tb_ModuleBindingSource.EndEdit();
                if (universityDataSet.HasChanges())
                {
                    if (MessageBox.Show("Save?", "Save",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        SaveData();
                    }
                }
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
