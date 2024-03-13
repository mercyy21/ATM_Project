namespace ATM_Project
{
    public class UpdateRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Pin { get; set; }
        public double? Balance { get; set; }
    }
}
