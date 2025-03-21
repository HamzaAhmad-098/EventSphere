namespace ITECManagementSystem.Models
{
    public class Committee
    {
        public int committee_id { get; set; }
        public int itec_id { get; set; }
        public string committee_name { get; set; }

        public Committee(int committeeId, int itecId, string committeeName)
        {
            committee_id = committeeId;
            itec_id = itecId;
            committee_name = committeeName;
        }
        public Committee() { }
    }
}
