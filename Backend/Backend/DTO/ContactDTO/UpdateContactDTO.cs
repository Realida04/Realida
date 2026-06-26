namespace Backend.DTO.ContactDTO
{
    public class UpdateContactDTO
    {
        public string Name { get; set; } = null!;

        public string? Subject { get; set; }

        public string? Msg { get; set; }
    }
}
