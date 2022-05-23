namespace F1.Models
{
    public class Race
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string Img { get; set; }
        public int Round { get; set; }
        public string RaceDate { get; set; }
        public string QualiDate { get; set; }
        public string P1Date { get; set; }
        public string P2Date { get; set; }
        public string P3Date { get; set; }
        public bool IsFinished { get; set; }
        public string Place1 { get; set; }
        public string Place2 { get; set; }
        public string Place3 { get; set; }

    }
}
