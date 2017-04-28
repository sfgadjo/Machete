// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MFR_M05_MF_QUERY (GroupMap) - 
    /// </summary>
    public class MFR_M05_MF_QUERYMap :
        HL7TemplateMap<MFR_M05_MF_QUERY>
    {
        public MFR_M05_MF_QUERYMap()
        {
            Map(x => x.MFE, 0, x => x.Required = true);
            Map(x => x.LOC, 1, x => x.Required = true);
            Map(x => x.LCH, 2);
            Map(x => x.LRL, 3);
            Map(x => x.MfLocDept, 4, x => x.Required = true);
        }
    }
}