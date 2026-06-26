namespace Backend.DTO.ContactDTO
{
    public class CreateContactDTO
    {
        public string Name { get; set; } = null!;

        public string? Subject { get; set; }

        public string? Msg { get; set; }

        
    }
}
