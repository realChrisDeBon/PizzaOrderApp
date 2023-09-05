using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class EditListForm : Form
    {
        public const string datafile = "pizzajoints.csv"; // Holds our list of pizza joints
        public EditListForm()
        {
            InitializeComponent();
        }

        private void EditListForm_Load(object sender, EventArgs e)
        {
            List<string> pizza_joints = File.ReadAllLines(datafile).ToList();
            foreach (string expected_pizzajoint in pizza_joints)
            {
                string[] pizzajoint_data = expected_pizzajoint.Split(','); // comma-delimiter
                if (pizzajoint_data.Length == 3)
                {
                    csv_data_grid.Rows.Add(pizzajoint_data[0], pizzajoint_data[1], pizzajoint_data[2]);
                }
                else
                {
                    // Bad data, do nothing
                }
            }
        }

        private void cancel__Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void remove__Click(object sender, EventArgs e)
        {

        }

        private void update__Click(object sender, EventArgs e)
        {
            var confirm_ = MessageBox.Show("Are you sure you would like to save these settings?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm_ == DialogResult.Yes)
            {
                for (int i = csv_data_grid.Rows.Count - 1; i > -1; i--)
                {
                    DataGridViewRow row = csv_data_grid.Rows[i];
                    if (!row.IsNewRow && row.Cells[0].Value == null)
                    {
                        csv_data_grid.Rows.RemoveAt(i);
                    }
                }

                const string comma = ",";
                StringBuilder sb = new StringBuilder();
                foreach (DataGridViewRow datarow_ in csv_data_grid.Rows)
                {
                    if ((datarow_.Cells[0].Value != null) && (datarow_.Cells[0].Value != ""))
                    {
                        sb.Append(datarow_.Cells[0].Value + comma + datarow_.Cells[1].Value + comma + datarow_.Cells[2].Value + Environment.NewLine);
                    }
                }
                File.WriteAllText("pizzajoints.csv", sb.ToString());

                this.Close();
            } else
            {
                // nothing
            }
        }
    }
}
