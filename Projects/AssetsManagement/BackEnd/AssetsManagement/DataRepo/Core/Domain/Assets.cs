using System;
namespace DataRepo.Controllers.Domain
{
    public class Assets: Entity
    {
        public string Address { get; set; }
        public string Description { get; set; }
        public int Owner { get; set; }
    }
}
