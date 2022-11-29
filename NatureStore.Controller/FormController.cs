using Microsoft.EntityFrameworkCore;
using NatureStore.Controller.Enums;
using NatureStore.Controller.Interfaces;
using NatureStore.Model;
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
    public class FormController : IFormController
    {
        private readonly NatureStoreDbContext db = DbConnector.GetInstance().GetDb();
        public void AddUserToDb(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        public FormStatus CheckIfUserTaken(string username)
        {
            var user = db.Users.FirstOrDefault(u => u.UserName == username);

            if(user == null)
                return FormStatus.Valid;
            else
                return FormStatus.UsernameTaken;
        }

        public FormStatus ValidateAddress(string address)
        {
            if (address.Length < 2)
                return FormStatus.LengthTooShort;
            else
                return FormStatus.Valid;
        }

        public FormStatus ValidateCitry(string city)
        {
            if (city.Length < 3)
                return FormStatus.LengthTooShort;
            else
                return FormStatus.Valid;
        }

        public FormStatus ValidateCountry(string country)
        {
            if (country.Length < 3)
                return FormStatus.LengthTooShort;
            else
                return FormStatus.Valid;
        }

        public FormStatus ValidatePassword(string password)
        {
            if (password.Length < 6)
                return FormStatus.LengthTooShort;
            else
                return FormStatus.Valid;
        }


        public FormStatus ValidateUsername(string username)
        {
            var regex = new Regex("[a-z][0,9]+");
            if (username.Length < 4)
                return FormStatus.LengthTooShort;
            else if (regex.IsMatch(username))
                return FormStatus.UsernameInvalid;
            else
                return FormStatus.Valid;
        }
    }
}
