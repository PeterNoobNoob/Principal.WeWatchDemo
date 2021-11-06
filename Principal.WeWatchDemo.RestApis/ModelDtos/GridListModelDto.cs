using Principal.WeWatchDemo.RestApis.ErrorModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Principal.WeWatchDemo.RestApis.ModelDtos
{
    public class GridListModelDto : ErrorResponseModel
    {

        public int Id { get; set; }
        public int OwnerId { get; set; }
        public DateTime? DateOfEvent { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string ProfilePic { get; set; }
        public bool? IsIncidentClosed { get; set; }

        /// <summary>
        /// Drží počet evidencií pripadajúcich k danému reportu
        /// </summary>
        public int? EvidenceOfIncidentCount { get; set; }

    }
}
