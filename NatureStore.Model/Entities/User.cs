
namespace NatureStore.Model.Entitys
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }    
        public string Password { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public UserType UserType { get; set; }


        public User() { }

        public User(string userName, string password, string address, string city, string country)
        {
            UserName = userName;
            Password = password;
            Address = address;
            City = city;
            Country = country;
        }
    }



}
