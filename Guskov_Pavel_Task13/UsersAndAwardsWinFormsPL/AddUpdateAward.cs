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
    public partial class AddUpdateAward : Form
    {
        private string title;
        private string description;

        public string Title
        {
            get
            {
                return title;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
        }

        public AddUpdateAward()
        {
            InitializeComponent();
        }

        public AddUpdateAward(int currentrow, UsersAndAwardsBLL usersAndAwardsBLL)
        {
            InitializeComponent();

            Award award = usersAndAwardsBLL.GetAward(currentrow);

            txtTitle.Text = award.Title;
            txtDescription.Text = award.Description;


        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            title = txtTitle.Text.Trim();
            description = txtDescription.Text.Trim();
            this.Close();
        }
    }
}
