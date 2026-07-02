namespace Backend.DTO.ExperienceDTO
{
    public class UpdateExperienceDTO
    {
        public string Company { get; set; } = null!;
        public string Position { get; set; } = null!;

        public int StartDate { get; set; }

        public int EndDate { get; set; }
        public int UserId { get; set; }
    }
}
