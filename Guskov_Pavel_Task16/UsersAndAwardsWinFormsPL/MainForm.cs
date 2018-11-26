using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersAndAwardsBL;
using Entites;
using System.Data.SqlClient;

namespace UsersAndAwardsWinFormsPL
{
    public partial class frmMain : Form
    {
        private enum SortMode { Asceding, Desceding };

        UsersAndAwardsBLL usersAndAwardsBLL = new UsersAndAwardsBLL();

        private SortMode usersSortMode = SortMode.Asceding;
        private SortMode awardsSortMode = SortMode.Asceding;

        public frmMain()
        {
            DateSourceForm frm = new DateSourceForm();

            if(frm.ShowDialog() == DialogResult.Yes)
            {
                string context = ConfigurationManager.AppSettings["context"];
                string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
                usersAndAwardsBLL = new UsersAndAwardsBLL(connectionString);
            }
            else
            {
                usersAndAwardsBLL = new UsersAndAwardsBLL();
            }

            InitializeComponent();

            CreateUserGrid();
            CreateAwardGrid();
            displayUsers();
            displayAwards();

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region AddLogic
        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUpdateUser addForm = new AddUpdateUser(usersAndAwardsBLL);

            addForm.Text = "Add User";

            if (addForm.ShowDialog() == DialogResult.OK)
            {

                usersAndAwardsBLL.AddUser(addForm.FirstName, addForm.LastName, addForm.Birthday, addForm.UsersAwards);
                displayUsers();

            }

        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            AddUpdateAward addAward = new AddUpdateAward();

            addAward.Text = "Add Award";

            if (addAward.ShowDialog() == DialogResult.OK)
            {

                usersAndAwardsBLL.AddAward(addAward.Title, addAward.Description);
                displayAwards();

            }
        }
        #endregion

        #region UpdateLogic
        private void UpdateAward_Click(object sender, EventArgs e)
        {
            //AddUpdateAward updateAward = new AddUpdateAward(usersAndAwardsBLL, Int32.Parse(dataUsers.CurrentRow.Cells[0].Value.ToString()));
            if (dataAwards.CurrentRow == null)
            {
                ErrorForm errorForm = new ErrorForm("Choose row in awards table");
                errorForm.ShowDialog();
            }
            else
            {
                int currentrow = Int32.Parse(dataAwards.CurrentRow.Cells[0].Value.ToString());

                AddUpdateAward updateAward = new AddUpdateAward(currentrow, usersAndAwardsBLL);

                updateAward.Text = "Update Award";

                if (updateAward.ShowDialog() == DialogResult.OK)
                {

                    usersAndAwardsBLL.UpdateAward(currentrow, updateAward.Title, updateAward.Description);
                    displayAwards();

                }
            }
        }

        private void UpdateUser_Click(object sender, EventArgs e)
        {
            if (dataUsers.CurrentRow == null)
            {
                ErrorForm errorForm = new ErrorForm("Choose row in user table");
                errorForm.ShowDialog();
            }
            else
            {
                int currentrow = Int32.Parse(dataUsers.CurrentRow.Cells[0].Value.ToString());

                AddUpdateUser updateUser = new AddUpdateUser(currentrow, usersAndAwardsBLL);

                updateUser.Text = "Update User";

                if (updateUser.ShowDialog() == DialogResult.OK)
                {

                    usersAndAwardsBLL.UpdateUser(currentrow, updateUser.FirstName, updateUser.LastName, updateUser.Birthday, updateUser.UsersAwards);
                    displayUsers();

                }
            }
        }
        #endregion

        #region DisplayInfo
        private void displayUsers()
        {
            dataUsers.DataSource = null;
            dataUsers.DataSource = usersAndAwardsBLL.GetUsersList();
        }

        private void displayAwards()
        {
            dataAwards.DataSource = null;
            dataAwards.DataSource = usersAndAwardsBLL.GetAwards();
        }

        private void CreateUserGrid()
        {
            dataUsers.AutoGenerateColumns = false;

            dataUsers.Columns.Add(new DataGridViewColumn()
            {
                CellTemplate = new DataGridViewTextBoxCell(),
                DataPropertyName = "ID",
                Visible = false,
            });

            dataUsers.Columns.Add(new DataGridViewColumn()
            {
                CellTemplate = new DataGridViewTextBoxCell(),
                DataPropertyName = "FirstName",
                HeaderText = "First Name",
                Width = 200
            });

            dataUsers.Columns.Add(new DataGridViewColumn()
            {
                CellTemplate = new DataGridViewTextBoxCell(),
                DataPropertyName = "LastName",
                HeaderText = "Last Name",
                Width = 200
            });

            dataUsers.Columns.Add(new DataGridViewColumn()
            {
                CellTemplate = new DataGridViewTextBoxCell(),
                DataPropertyName = "Birthday",
                HeaderText = "Birthday",
                Width = 100,
            });

            dataUsers.Columns.Add(new DataGridViewColumn()
            {
                CellTemplate = new DataGridViewTextBoxCell(),
                DataPropertyName = "Age",
                HeaderText = "Age",
                Width = 50,
            });

            dataUsers.Columns.Add(new DataGridViewColumn()
            {
                CellTemplate = new DataGridViewTextBoxCell(),
                DataPropertyName = "StrOfUsersAwawrds",
                HeaderText = "Awards",
                Width = 400,
            });

        }

        private void CreateAwardGrid()
        {
            dataAwards.AutoGenerateColumns = false;

            dataAwards.Columns.Add(new DataGridViewColumn()
            {
                CellTemplate = new DataGridViewTextBoxCell(),
                DataPropertyName = "ID",
                Visible = false,
            });

            dataAwards.Columns.Add(new DataGridViewColumn()
            {
                CellTemplate = new DataGridViewTextBoxCell(),
                DataPropertyName = "Title",
                HeaderText = "Title",
                Width = 200
            });

            dataAwards.Columns.Add(new DataGridViewColumn()
            {
                CellTemplate = new DataGridViewTextBoxCell(),
                DataPropertyName = "Description",
                HeaderText = "Description",
                Width = 200
            });

            dataAwards.DataSource = null;
        }
        #endregion

        #region RemoveLogic
        private void RemoveAward_Click(object sender, EventArgs e)
        {
            if (dataAwards.CurrentRow == null)
            {
                ErrorForm errorForm = new ErrorForm("Choose row in awards table");
                errorForm.ShowDialog();
            }
            else
            {
                AcceptForm form = new AcceptForm();
                int currentrow = Int32.Parse(dataAwards.CurrentRow.Cells[0].Value.ToString());

                if (form.ShowDialog() == DialogResult.OK)
                {
                    usersAndAwardsBLL.RemoveAward(currentrow);

                    displayAwards();
                    displayUsers();
                }
            }
        }

        private void RemoveUser_Click(object sender, EventArgs e)
        {
            if (dataUsers.CurrentRow == null)
            {
                ErrorForm errorForm = new ErrorForm("Choose row in users table");
                errorForm.ShowDialog();
            }
            else
            {

                AcceptForm form = new AcceptForm();
                int currentrow = Int32.Parse(dataUsers.CurrentRow.Cells[0].Value.ToString());

                if (form.ShowDialog() == DialogResult.OK)
                {
                    usersAndAwardsBLL.RemoveUser(currentrow);

                    displayUsers();
                }
            }
        }

        #endregion

        #region UserSort
        private void dataUsers_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (usersSortMode == SortMode.Asceding)
                {
                    dataUsers.DataSource = usersAndAwardsBLL.SortUsersByFirstNameDesc();
                    usersSortMode = SortMode.Desceding;
                }
                else
                {
                    dataUsers.DataSource = usersAndAwardsBLL.SortUsersByFirstNameAsc();
                    usersSortMode = SortMode.Asceding;
                }
            }

            if (e.ColumnIndex == 2)
            {
                if (awardsSortMode == SortMode.Asceding)
                {
                    dataUsers.DataSource = usersAndAwardsBLL.SortUsersByLastNameDesc();
                    usersSortMode = SortMode.Desceding;
                }
                else
                {
                    dataUsers.DataSource = usersAndAwardsBLL.SortUsersByLastNameAsc();
                    usersSortMode = SortMode.Asceding;
                }
            }
            if (e.ColumnIndex == 3)
            {
                if (usersSortMode == SortMode.Asceding)
                {
                    dataUsers.DataSource = usersAndAwardsBLL.SortUsersByBirthdayDesc();
                    usersSortMode = SortMode.Desceding;
                }
                else
                {
                    dataUsers.DataSource = usersAndAwardsBLL.SortUsersByBirthdayAsc();
                    usersSortMode = SortMode.Asceding;
                }
            }
            if (e.ColumnIndex == 4)
            {
                if (usersSortMode == SortMode.Asceding)
                {
                    dataUsers.DataSource = usersAndAwardsBLL.SortUsersByAgeDesc();
                    usersSortMode = SortMode.Desceding;
                }
                else
                {
                    dataUsers.DataSource = usersAndAwardsBLL.SortUsersByAgeAsc();
                    usersSortMode = SortMode.Asceding;
                }
            }
            if (e.ColumnIndex == 5)
            {
                if (usersSortMode == SortMode.Asceding)
                {
                    dataUsers.DataSource = usersAndAwardsBLL.SortUsersByAwardsDesc();
                    usersSortMode = SortMode.Desceding;
                }
                else
                {
                    dataUsers.DataSource = usersAndAwardsBLL.SortUsersByAwardsAsc();
                    usersSortMode = SortMode.Asceding;
                }
            }
        }
        #endregion

        #region AwardsSort

        private void dataAwards_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (awardsSortMode == SortMode.Asceding)
                {
                    dataAwards.DataSource = usersAndAwardsBLL.SortAwardsByTitleDesc();
                    awardsSortMode = SortMode.Desceding;
                }
                else
                {
                    dataAwards.DataSource = usersAndAwardsBLL.SortAwardsByTitleAsc();
                    awardsSortMode = SortMode.Asceding;
                }
            }

            if (e.ColumnIndex == 2)
            {
                if (awardsSortMode == SortMode.Asceding)
                {
                    dataAwards.DataSource = usersAndAwardsBLL.SortAwardsByDescriptionDesc();
                    awardsSortMode = SortMode.Desceding;
                }
                else
                {
                    dataAwards.DataSource = usersAndAwardsBLL.SortAwardsByDescriptionAsc();
                    awardsSortMode = SortMode.Asceding;
                }
            }
        }

        #endregion
    }

}
