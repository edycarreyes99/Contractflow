using System;
using System.Collections.Generic;

#nullable disable

namespace Contractflow.Models.Database
{
    public partial class User
    {
        public int Id { get; set; }
        public string Dni { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public Guid Salt { get; set; }
        public string PhoneNumber { get; set; }
        public string FatherName { get; set; }
        public string FullName { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string Email { get; set; }
    }
}
