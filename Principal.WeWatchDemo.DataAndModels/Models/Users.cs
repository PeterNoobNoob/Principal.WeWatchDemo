using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Principal.WeWatchDemo.DataAndModels.Models
{
    public partial class Users
    {
        public Users()
        {
            Evidences = new HashSet<Evidences>();
            Incidents = new HashSet<Incidents>();
            RejectedRequests = new HashSet<RejectedRequests>();
        }

        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string DeviceId { get; set; }
        public Guid Token { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
        public DateTime? Created { get; set; }
        public string ProfilePic { get; set; }

        [InverseProperty("Owner")]
        public virtual ICollection<Evidences> Evidences { get; set; }
        [InverseProperty("Owner")]
        public virtual ICollection<Incidents> Incidents { get; set; }
        [InverseProperty("Owner")]
        public virtual ICollection<RejectedRequests> RejectedRequests { get; set; }
    }
}
