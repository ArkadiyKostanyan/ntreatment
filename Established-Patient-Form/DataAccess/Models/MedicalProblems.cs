namespace DataAccess.Models
{
    public class MedicalProblems
    {
        public bool IsPositive { get; set; }
        public string Notes { get; set; }

        public MedicalProblems()
        {
            IsPositive = false;
            Notes = string.Empty;
        }
    }
}
