using System;
namespace DataRepo.Controllers.Domain
{
    public class Entity
    {
        public int Id { get; set; }
        public int CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
    }
}
