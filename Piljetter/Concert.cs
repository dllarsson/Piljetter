﻿using System;

namespace Piljetter
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
    }
}