using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Data
{
    public partial class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public string Address { get; set; }
        public string IdentityCardNumber { get; set; }
        public int IdDocumentType { get; set; }
        public string Email { get; set; }
        public DateTime DateExpiredGuid { get; set; }
        public byte[] Password { get; set; }
        public string Guid { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastLoginDate { get; set; }
        public int IdCity { get; set; }
    }
}
