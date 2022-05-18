using ResturantManagementSystem.OOP_Classes.DataBaseHandel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantManagementSystem.OOP_Classes
{
    class ServiceProvider
    {
        private int companyID;
        private String name;
        private String email;
        private String phone;
        private String address;

        public ServiceProvider()
        {
        }

        public ServiceProvider(int companyID, string name, string email, string phone, string address)
        {
            this.CompanyID = companyID;
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
            this.Address = address;
        }

        public int CompanyID { get => companyID; set => companyID = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }

        /******************************************************/
        public void save()
        {
            new ServiceProviderRepository().save(this);
        }

        public void update()
        {
            new ServiceProviderRepository().update(this);
        }

        public void delete()
        {
            new ServiceProviderRepository().delete(this);
        }
    }
}
