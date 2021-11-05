﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Principal.WeWatchDemo.DataAndModels.Models
{
    public partial class Reports
    {
        [Key]
        public int Id { get; set; }
        public int IncidentId { get; set; }
        public string HttpLink { get; set; }

        [ForeignKey(nameof(IncidentId))]
        [InverseProperty(nameof(Incidents.Reports))]
        public virtual Incidents Incident { get; set; }
    }
}
