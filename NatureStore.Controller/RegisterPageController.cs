using NatureStore.Controller.Enums;
using NatureStore.Controller.Interfaces;
using NatureStore.Model.Context;
using NatureStore.Model.Entitys;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NatureStore.Controller
{
    public class RegisterPageController : IRegisterController
    {
        private readonly NatureStoreDbContext db = DbConnector.GetInstance().GetDb();
        public bool AddUserToDb(User user)
        {
            throw new NotImplementedException();
        }

        public FormStatus CheckIfUserTaken(string username)
        {
            throw new NotImplementedException();
        }

        public FormStatus ValidateAddress(string address)
        {
            if (address.Length < 2)
                return FormStatus.LengthToShort;
            else
                return FormStatus.Valid;
        }

        public FormStatus ValidateCitry(string city)
        {
            if (city.Length < 3)
                return FormStatus.LengthToShort;
            else
                return FormStatus.Valid;
        }

        public FormStatus ValidateCountry(string country)
        {
            if (country.Length < 3)
                return FormStatus.LengthToShort;
            else
                return FormStatus.Valid;
        }

        public FormStatus ValidatePassword(string password)
        {
            if (password.Length < 6)
                return FormStatus.LengthToShort;
            else
                return FormStatus.Valid;
        }


        public FormStatus ValidateUsername(string username)
        {
            var regex = new Regex("[a-zA-Z]");
            if (username.Length < 4)
                return FormStatus.LengthToShort;

            else if (regex.IsMatch(username))
                return FormStatus.UsernameInvalid;
            else
                return FormStatus.Valid;
        }
    }
}
