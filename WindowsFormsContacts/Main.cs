using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsContacts
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        #region EVENTOS
        private void button1_Click(object sender, EventArgs e)
        {
            OpenContactDetailsDialog();
        }

        #endregion

        #region PRIVATE METHODS
        private void OpenContactDetailsDialog()
        {
            ContactDetails contactDetails = new ContactDetails();
            contactDetails.ShowDialog();
        }

        #endregion
    }
}
