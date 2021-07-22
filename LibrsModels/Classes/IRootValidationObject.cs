using System.Collections.Generic;

namespace LibrsModels.Classes
{
    public interface IRootValidationObject<T> where T: ILibrsIncident
    {
        string Spec { get; }
        string Ori { get; }
        int ReportYear { get; }
        int ReportMonth { get; }
        string AgencyName { get; }
        string SoftwareID { get; }
        string SoftwareVersion { get; }
        bool ForSubmission { get; }
        List<T> IncidentList { get; }
        ZeroReport ZeroReport { get; }
    }
}