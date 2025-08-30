using LotusCare.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotusCare.Forms
{
    public partial class DashboardForm : Form
    {
        private User user;

        public DashboardForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            // Example: show the logged-in user's name
            this.Text = $"Welcome, {user.FullName} ({user.Role})";
        }
    }
}
