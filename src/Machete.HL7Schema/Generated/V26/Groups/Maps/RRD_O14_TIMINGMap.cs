// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RRD_O14_TIMING (GroupMap) - 
    /// </summary>
    public class RRD_O14_TIMINGMap :
        HL7TemplateMap<RRD_O14_TIMING>
    {
        public RRD_O14_TIMINGMap()
        {
            Map(x => x.TQ1, 0, x => x.Required = true);
            Map(x => x.TQ2, 1);
        }
    }
}