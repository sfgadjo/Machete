// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MFN_M06_MF_CLIN_STUDY (GroupMap) - 
    /// </summary>
    public class MFN_M06_MF_CLIN_STUDYMap :
        HL7TemplateMap<MFN_M06_MF_CLIN_STUDY>
    {
        public MFN_M06_MF_CLIN_STUDYMap()
        {
            Map(x => x.MFE, 0, x => x.Required = true);
            Map(x => x.CM0, 1, x => x.Required = true);
            Map(x => x.MfPhaseSchedDetail, 2);
        }
    }
}