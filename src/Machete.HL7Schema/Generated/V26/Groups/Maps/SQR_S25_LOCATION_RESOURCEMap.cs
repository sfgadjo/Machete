// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SQR_S25_LOCATION_RESOURCE (GroupMap) - 
    /// </summary>
    public class SQR_S25_LOCATION_RESOURCEMap :
        HL7TemplateMap<SQR_S25_LOCATION_RESOURCE>
    {
        public SQR_S25_LOCATION_RESOURCEMap()
        {
            Map(x => x.AIL, 0, x => x.Required = true);
            Map(x => x.NTE, 1);
        }
    }
}