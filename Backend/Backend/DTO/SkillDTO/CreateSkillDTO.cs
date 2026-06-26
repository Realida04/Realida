namespace Backend.DTO.SkillDTO
{
    public class CreateSkillDTO
    {
        public string Name { get; set; } = null!;

        public string? Bio { get; set; }

        public string Title { get; set; } = null!;

        public string Email { get; set; } = null!;
    }
}
