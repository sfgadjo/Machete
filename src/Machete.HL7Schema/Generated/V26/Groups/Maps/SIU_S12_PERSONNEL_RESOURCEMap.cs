// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SIU_S12_PERSONNEL_RESOURCE (GroupMap) - 
    /// </summary>
    public class SIU_S12_PERSONNEL_RESOURCEMap :
        HL7TemplateMap<SIU_S12_PERSONNEL_RESOURCE>
    {
        public SIU_S12_PERSONNEL_RESOURCEMap()
        {
            Map(x => x.AIP, 0, x => x.Required = true);
            Map(x => x.NTE, 1);
        }
    }
}