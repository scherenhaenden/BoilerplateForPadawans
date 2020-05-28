using System;
namespace DataRepo.Controllers.Domain
{
    public class Users: Entity
    {
        public string LoginName { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
