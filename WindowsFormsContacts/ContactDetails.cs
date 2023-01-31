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
    public partial class ContactDetails : Form
    {
        private BussinessLogicLayer _bussinessLogicLayer;
        public ContactDetails()
        {
            InitializeComponent();
            _bussinessLogicLayer = new BussinessLogicLayer();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            contact.FirstName= txtFirstName.Text;
            contact.LastName= txtLastName.Text;
            contact.Phone = txtPhone.Text;
            contact.Address= txtAddress.Text;   
        }
    }
}
