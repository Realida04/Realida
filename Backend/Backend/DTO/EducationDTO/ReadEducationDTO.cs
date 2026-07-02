namespace Backend.DTO.EducationDTO
{
    public class ReadEducationDTO
    {
        public string Institution { get; set; } = null!;

        public string Degree { get; set; } = null!;

        public string Field { get; set; } = null!;

        public int StartYear { get; set; }
        public int UserId { get; set; }
    }
}
