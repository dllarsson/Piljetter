using System;

namespace PiljetterUserClient
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Pesetas { get; set; }
        public DateTime CreatedOnDate { get; set; }
        public int TicketId { get; set; }
        public string ConcertName { get; set; }
        public string CouponId { get; set; }
    }
}