using System;

namespace Piljetter
{
    internal class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Pesetas { get; set; }
        public DateTime CreatedOnDate { get; set; }
    }
}