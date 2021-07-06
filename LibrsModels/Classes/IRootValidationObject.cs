using System.Collections.Generic;

namespace LibrsModels.Classes
{
    public interface IRootValidationObject<T> where T: ILibrsIncident
    {
        string Spec { get; }
        string Ori { get; }
        int ReportYear { get; }
        int ReportMonth { get; }
        bool ForSubmission { get; }
        List<T> IncidentList { get; }
        bool ZeroReport { get; }
    }
}