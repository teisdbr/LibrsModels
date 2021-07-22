using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using NibrsModels.NibrsReport.Item;
using NibrsModels.NibrsReport.Person;
using NibrsModels.NibrsReport.Subject;


namespace LibrsModels.Classes
{
    public class StateReportBatch : IRootValidationObject<ILibrsIncident>
    {
        public string StateReportingSpec => "2.5";

        /// <summary>
        ///     This is the same as ORI, it will be used to report to FBI via NIBRS
        /// </summary>
        public string ReportingId { get; set; }

        /// <summary>
        /// This is the reporting period to which all of the incidents being reported belong to
        /// </summary>
        public DateTime ReportingDate { get; set; } // ReportDate?

        public List<StateReport> StateReports { get; set; }

        #region IRootValidationObject Implementation
        
        [JsonProperty("spec")]
        string IRootValidationObject<ILibrsIncident>.Spec => StateReportingSpec;
        
        [JsonProperty("ori")]
        string IRootValidationObject<ILibrsIncident>.Ori => ReportingId;
        [JsonProperty("reportYear")]
        int IRootValidationObject<ILibrsIncident>.ReportYear => ReportingDate.Year;
        [JsonProperty("reportMonth")]
        int IRootValidationObject<ILibrsIncident>.ReportMonth => ReportingDate.Month;
        [JsonProperty("forSubmission")]
        bool IRootValidationObject<ILibrsIncident>.ForSubmission => false; // False for now
        // api/jsonValidator?validateOnly=true
        [JsonProperty("incidentList")]
        List<ILibrsIncident> IRootValidationObject<ILibrsIncident>.IncidentList { get; }

        [JsonProperty("zeroReport")]
        ZeroReport IRootValidationObject<ILibrsIncident>.ZeroReport => StateReports != null && StateReports.Any() ? null : new ZeroReport();

        #endregion
    }
}