using System.Collections;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace LibrsModels.Classes
{
    public class RootValidationObject: IPaddingFixer
    {
        [JsonProperty("spec")] public string Spec { get; set; }

        [JsonProperty("ori")] public string Ori { get; set; }

        [JsonProperty("reportYear")] public int ReportYear { get; set; }

        [JsonProperty("reportMonth")] public int ReportMonth { get; set; }

        [JsonProperty("forSubmission")] public bool ForSubmission { get; set; }

        [JsonProperty("librsIncident")] public List<LibrsIncident> IncidentList { get; set; }

        public void FixPaddings()
        {
            #region Fixing Paddings For RootObject
            Ori = Ori.PadLeft(1);
            #endregion
            #region Fix Padding For Children
            Recursive(this);
            #endregion
        }

        private void Recursive(object il)
        {
            // Get all the properties of the object
            foreach (var inc in il.GetType().GetProperties())
            {
                // For each property check if the property implements the IPaddingFixer Interface
                if (typeof(IPaddingFixer).IsAssignableFrom(inc.PropertyType))
                {
                    // If it implements the desired interface then extract value of the property
                    IPaddingFixer converter = (IPaddingFixer) inc.GetValue(il);
                    // Call the FixPadding function implemented by the interface
                    converter.FixPaddings();
                    // call Recursive function so that all the properties
                    // which implement IPaddingFixer interface inside this property
                    Recursive(converter);
                }

                // For each property check if it a list
                if (inc.PropertyType.IsGenericType &&
                    (inc.PropertyType.GetGenericTypeDefinition() == typeof(List<>)))
                {
                    // Get the value of the list and cast as list
                    var segList = ((IEnumerable) inc.GetValue(il))?.Cast<object>().ToList();
                    segList?.ForEach(sl =>
                    {
                        // For each value in the list check if they implement IPaddingFixer Interface
                        if (sl is IPaddingFixer)
                        {
                            var converter = (IPaddingFixer) sl;
                            // Call the FixPadding function implemented by the interface
                            converter.FixPaddings();
                            // call Recursive function so that all the properties
                            // which implement IPaddingFixer interface inside this property
                            Recursive(converter);
                        }
                    });
                }
            }
        }
    }
}