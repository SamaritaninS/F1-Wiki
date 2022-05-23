using System.Collections.Generic;

namespace F1.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public string Base { get; set; }
        public string Chief { get; set; }
        public string Power { get; set; }
        public string TeamEntry { get; set; }
        public int Championships { get; set; }
        public int Poles { get; set; }
        public int FastesLaps { get; set; }
        public int Points { get; set; }
        public int Position { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; }
        public string Preview { get; set; }
        public string Img { get; set; }
        public string FirstDriver { get; set; }
        public string SecondDriver { get; set; }
    }
}
