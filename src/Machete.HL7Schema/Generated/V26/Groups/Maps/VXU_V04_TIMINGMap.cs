// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// VXU_V04_TIMING (GroupMap) - 
    /// </summary>
    public class VXU_V04_TIMINGMap :
        HL7TemplateMap<VXU_V04_TIMING>
    {
        public VXU_V04_TIMINGMap()
        {
            Map(x => x.TQ1, 0, x => x.Required = true);
            Map(x => x.TQ2, 1);
        }
    }
}