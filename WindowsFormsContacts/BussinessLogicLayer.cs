using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsContacts
{
    public class BussinessLogicLayer
    {
        private DataAccessLayer _dataAccessLayer;
        public BussinessLogicLayer()
        {
            _dataAccessLayer = new DataAccessLayer();
        }

        public Contact SaveContact(Contact contact)
        {
            if (contact.Id==0)
                //_dataAccessLayer.InsertContact
            else
                //_dataAccessLayer.UpdateContact


        }
    }
}
