// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RRA_O18_RESPONSE (GroupMap) - 
    /// </summary>
    public class RRA_O18_RESPONSEMap :
        HL7TemplateMap<RRA_O18_RESPONSE>
    {
        public RRA_O18_RESPONSEMap()
        {
            Map(x => x.Patient, 0);
            Map(x => x.Order, 1, x => x.Required = true);
        }
    }
}