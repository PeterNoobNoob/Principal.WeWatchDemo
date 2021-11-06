using Principal.WeWatchDemo.DataAndModels.Models;
using Principal.WeWatchDemo.RestApis.ErrorModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Principal.WeWatchDemo.RestApis.ModelDtos
{
    public class ReportsDto : ErrorResponseModel
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
