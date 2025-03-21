namespace ITECManagementSystem.Models
{
    public class ItechEdition
    {
        public int ItecId { get; set; }
        public int Year { get; set; }
        public string Theme { get; set; }

        public ItechEdition(int itecId, int year, string theme)
        {
            ItecId = itecId;
            Year = year;
            Theme = theme;
        }
        public ItechEdition() {
            
        }
    }
}
