namespace Backend.DTO.UserrDTO
{
    public class ReadUserDTO
    {
        public string Fullname { get; set; } = null!;

        public string Title { get; set; } = null!;

        public string Phone { get; set; } = null!; 
        public string Email { get; set; }
    }
}
