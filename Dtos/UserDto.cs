namespace idleGood_WebAPI.Dtos
{
    public class UserDto
    {
        public string ?Id { get; set; } // IdentityUser  Id
        public string ?UserName { get; set; } // IdentityUser  UserName
        public string ?UserIconUrl { get; set; }

        public string Email { get; set; } // IdentityUser  Email
        public string ?Address { get; set; }
        public string ?SelfIntro { get; set; }


    }
}
