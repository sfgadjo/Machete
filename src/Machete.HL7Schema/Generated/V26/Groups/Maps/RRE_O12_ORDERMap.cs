// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RRE_O12_ORDER (GroupMap) - 
    /// </summary>
    public class RRE_O12_ORDERMap :
        HL7TemplateMap<RRE_O12_ORDER>
    {
        public RRE_O12_ORDERMap()
        {
            Map(x => x.ORC, 0, x => x.Required = true);
            Map(x => x.Timing, 1);
            Map(x => x.Encoding, 2);
        }
    }
}