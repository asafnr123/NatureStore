using NatureStore.Controller.Enums;
using NatureStore.Model.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatureStore.Controller.Interfaces
{
    public interface IRegisterController
    {
        public FormStatus ValidateUsername(string username);
        public FormStatus ValidatePassword(string password);
        public FormStatus ValidateAddress(string address);
        public FormStatus ValidateCountry(string country);
        public FormStatus ValidateCitry(string city);
        public FormStatus CheckIfUserTaken(string username);

        public void AddUserToDb(User user);
        
    }
}
