using System;

namespace SimaxCrm.Model.RequestModel
{
    public class LeadsViewFilterModel
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string LeadStatus { get; set; }
        public string CurrentLeadStatus { get; set; }
        public string UserId { get; set; }

    }

}