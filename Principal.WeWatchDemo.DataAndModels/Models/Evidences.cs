using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Principal.WeWatchDemo.DataAndModels.Models
{
    public partial class Evidences
    {
        public Evidences()
        {
            Medias = new HashSet<Medias>();
        }

        [Key]
        public int Id { get; set; }
        public int IncidentId { get; set; }
        public int OwnerId { get; set; }
        public DateTime? DateOfEvent { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string Description { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }

        [ForeignKey(nameof(IncidentId))]
        [InverseProperty(nameof(Incidents.Evidences))]
        public virtual Incidents Incident { get; set; }
        [ForeignKey(nameof(OwnerId))]
        [InverseProperty(nameof(Users.Evidences))]
        public virtual Users Owner { get; set; }
        [InverseProperty("Evidence")]
        public virtual ICollection<Medias> Medias { get; set; }
    }
}
