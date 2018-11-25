using System;
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

namespace UsersAndAwardsWinFormsPL
{
    public partial class AddUpdateUser : Form
    {
        private string firstName;
        private string lastName;
        private DateTime birthday;
        private List<Award> allAwards;
        private List<Award> usersAwards;
        private CheckBox[] checks;
        private UsersAndAwardsBLL usersAndAwardsBLL;

        #region prop
        public string FirstName
        {
            get
            {
                return firstName;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
        }

        public DateTime Birthday
        {
            get
            {
                return birthday;
            }
        }

        public List<Award> UsersAwards
        {
            get
            {
                return usersAwards;
            }
        }
        #endregion


        public AddUpdateUser(UsersAndAwardsBLL usersAndAwardsBLL)
        {
            InitializeComponent();

            this.usersAndAwardsBLL = usersAndAwardsBLL;

            allAwards = usersAndAwardsBLL.GetAwards();

            checks = new CheckBox[allAwards.Count];
            int i = 0;

            foreach (Award award in allAwards)
            {
                checks[i] = new CheckBox();
                checks[i].Name = award.Title;
                checks[i].Text = award.Title;
                pnlAwards.Controls.Add(checks[i]);
                i++;
            }
        }

        public AddUpdateUser(int currentrow, UsersAndAwardsBLL usersAndAwardsBLL)
        {
            InitializeComponent();

            this.usersAndAwardsBLL = usersAndAwardsBLL;

            User user = usersAndAwardsBLL.GetUser(currentrow);
            List<Award> usersAwards = user.GetUserAwards();

            txtFisrtName.Text = user.FirstName;
            txtLastName.Text = user.LastName;
            BirthDay.Value = user.BirthDay;

            allAwards = usersAndAwardsBLL.GetAwards();

            checks = new CheckBox[allAwards.Count];
            int i = 0;

            foreach (Award award in allAwards)
            {
                checks[i] = new CheckBox();
                checks[i].Name = award.Title;
                checks[i].Text = award.Title;
                pnlAwards.Controls.Add(checks[i]);

                foreach(Award _award in usersAwards)
                {
                    if (checks[i].Text.Equals(_award.Title))
                    {
                        checks[i].Checked = true;
                    }
                }

                i++;
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            firstName = txtFisrtName.Text.Trim();
            lastName = txtLastName.Text.Trim();
            birthday = BirthDay.Value.Date;

            usersAwards = new List<Award>();

            for (int i = 0; i < allAwards.Count; i++)
            {
                if (checks[i].Checked)
                {
                    foreach(Award award in allAwards)
                    {
                        if (checks[i].Name.Equals(award.Title))
                        {
                            usersAwards.Add(award);
                        }
                    }

                }
            }

            this.Close();
        }
    }
}
