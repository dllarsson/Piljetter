using System;

namespace PiljetterUserClient
{
    internal class Concert
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int Stage_Id { get; set; }
        public int Artist_Id { get; set; }
        public int Pesetas { get; set; }
        public bool IsCanceled { get; set; }
        public string ArtistName { get; set; }
        public string CityName { get; set; }
        public string StageName { get; set; }
        public int AvaibleTickets { get; set; }
        public int MaxVisitors { get; set; }

    }
}