using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lastprep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }





        // smth is gonna be saved
        private void tbTeacherBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveDate();
        }








        // variable kinda thing that will save
        private void SaveDate()
        {
            if (this.Validate())
            {
                try
                {
                    this.tbTeacherBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.dbDataSet);
                    MessageBox.Show("Saved");
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }








        //tries to catch smth
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
            this.tbCountryTableAdapter.Fill(this.dbDataSet.tbCountry);
            this.tbTeacherTableAdapter.Fill(this.dbDataSet.tbTeacher);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        












        //delete button
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbTeacherBindingSource.Count == 0)
            {
                MessageBox.Show("No more data");
            }
            else
            {
                if (MessageBox.Show("Sure?", "Sure", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    tbTeacherBindingSource.RemoveCurrent();
                }
            }
        }









        //nothing
        private void tbTeacherBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            //ableDisableButtons();
        }









        //save button

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveDate();
        }









        //asks if we have to save from user when the form is being closed
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Validate())
            {
                this.tbTeacherBindingSource.EndEdit();
                if (dbDataSet.HasChanges())
                {
                    if (MessageBox.Show("Do you wanna Save", "Save", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        SaveDate();
                    }
                }
            }
            else
            {
                e.Cancel = true;
            }
        }











        //btn add
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var selectedCountry = ((DataRowView)cmbNewCountry.SelectedItem).Row;
            dbDataSet.tbTeacher.AddtbTeacherRow(
                tbxNewFirstName.Text,
                tbxNewLastName.Text,
                dtpNewDataofBirth.Value,
                tbxNewPhone.Text,
                (int)nudNewGradeLevel.Value,
                chbNewActive.Checked,
                (dbDataSet.tbCountryRow)selectedCountry);
        }











        //textbox thaST FILTERS
        private void tbxFilter_TextChanged(object sender, EventArgs e)
        {
            tbTeacherBindingSource.Filter = $"lastName LIKE '{tbxFilter.Text}%'";
        }









        //validating each text boxes so that they wont be empty 
        private void tbxFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbxFirstName.Text))
            {
                MessageBox.Show("First name cannot be empty");
                e.Cancel = true;
            }
        }
    }
}
