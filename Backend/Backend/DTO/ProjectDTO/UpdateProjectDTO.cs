namespace Backend.DTO.ProjectDTO
{
    public class UpdateProjectDTO
    {
        public string Title { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string Githublink { get; set; } = null!;
        public int UserId { get; set; }
    }
}
