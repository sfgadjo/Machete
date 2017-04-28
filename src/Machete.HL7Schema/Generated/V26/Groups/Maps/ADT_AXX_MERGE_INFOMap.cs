// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ADT_AXX_MERGE_INFO (GroupMap) - 
    /// </summary>
    public class ADT_AXX_MERGE_INFOMap :
        HL7TemplateMap<ADT_AXX_MERGE_INFO>
    {
        public ADT_AXX_MERGE_INFOMap()
        {
            Map(x => x.MRG, 0, x => x.Required = true);
            Map(x => x.PV1, 1, x => x.Required = true);
        }
    }
}