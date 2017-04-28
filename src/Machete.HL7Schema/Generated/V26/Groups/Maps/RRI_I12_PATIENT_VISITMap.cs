// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RRI_I12_PATIENT_VISIT (GroupMap) - 
    /// </summary>
    public class RRI_I12_PATIENT_VISITMap :
        HL7TemplateMap<RRI_I12_PATIENT_VISIT>
    {
        public RRI_I12_PATIENT_VISITMap()
        {
            Map(x => x.PV1, 0, x => x.Required = true);
            Map(x => x.PV2, 1);
        }
    }
}