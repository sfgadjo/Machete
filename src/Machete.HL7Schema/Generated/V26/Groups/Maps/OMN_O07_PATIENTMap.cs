// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OMN_O07_PATIENT (GroupMap) - 
    /// </summary>
    public class OMN_O07_PATIENTMap :
        HL7TemplateMap<OMN_O07_PATIENT>
    {
        public OMN_O07_PATIENTMap()
        {
            Map(x => x.PID, 0, x => x.Required = true);
            Map(x => x.PD1, 1);
            Map(x => x.NTE, 2);
            Map(x => x.PatientVisit, 3);
            Map(x => x.Insurance, 4);
            Map(x => x.GT1, 5);
            Map(x => x.AL1, 6);
        }
    }
}