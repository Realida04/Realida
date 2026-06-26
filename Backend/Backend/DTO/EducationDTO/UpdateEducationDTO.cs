namespace Backend.DTO.EducationDTO
{
    public class UpdateEducationDTO
    {
        public string Institution { get; set; } = null!;

        public string Degree { get; set; } = null!;

        public string Field { get; set; } = null!;

        public int StartYear { get; set; }
    }

}
