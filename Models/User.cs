namespace KZNshelter.Models
{
    public enum Roles
    {
        Guests,
        User,
        Admin
    }
    public class User
    {
        
        public int Id { get; set; }
        public string Shelter_Name { get; set; }
        public string ImagePath { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Desc { get; set; }
        public Roles Role { get; set; }

        public User(int id)
        {
            Id = id;
        }
    }
}