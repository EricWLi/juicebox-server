namespace JuiceboxServer.Models.Responses
{
    public class UserResponse
    {
        public string Id { get; set; } = null!;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Username { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }

        public UserResponse(AppUser user)
        {
            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Username = user.UserName;
            DateCreated = user.DateCreated;
            DateUpdated = user.DateUpdated;
        }
    }
}