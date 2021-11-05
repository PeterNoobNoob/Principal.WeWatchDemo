using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Principal.WeWatchDemo.DataAndModels.Models
{
    public partial class Incidents
    {
        public Incidents()
        {
            Evidences = new HashSet<Evidences>();
            Medias = new HashSet<Medias>();
            RejectedRequests = new HashSet<RejectedRequests>();
            Reports = new HashSet<Reports>();
        }

        [Key]
        public int Id { get; set; }
        public int OwnerId { get; set; }
        public DateTime? DateOfEvent { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public bool? IsClosed { get; set; }
        public bool? IsOwnerVictim { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }

        [ForeignKey(nameof(OwnerId))]
        [InverseProperty(nameof(Users.Incidents))]
        public virtual Users Owner { get; set; }
        [InverseProperty("Incident")]
        public virtual ICollection<Evidences> Evidences { get; set; }
        [InverseProperty("Incident")]
        public virtual ICollection<Medias> Medias { get; set; }
        [InverseProperty("Incident")]
        public virtual ICollection<RejectedRequests> RejectedRequests { get; set; }
        [InverseProperty("Incident")]
        public virtual ICollection<Reports> Reports { get; set; }
    }
}
