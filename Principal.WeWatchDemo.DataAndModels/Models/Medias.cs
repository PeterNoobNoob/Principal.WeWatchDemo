using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Principal.WeWatchDemo.DataAndModels.Models
{
    public partial class Medias
    {
        [Key]
        public int Id { get; set; }
        public int? EvidenceId { get; set; }
        public int? IncidentId { get; set; }
        public string Name { get; set; }
        public string BlobFileAddress { get; set; }
        public DateTime? Created { get; set; }

        [ForeignKey(nameof(EvidenceId))]
        [InverseProperty(nameof(Evidences.Medias))]
        public virtual Evidences Evidence { get; set; }
        [ForeignKey(nameof(IncidentId))]
        [InverseProperty(nameof(Incidents.Medias))]
        public virtual Incidents Incident { get; set; }
    }
}
