// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RDS_O13_ORDER (GroupMap) - 
    /// </summary>
    public class RDS_O13_ORDERMap :
        HL7TemplateMap<RDS_O13_ORDER>
    {
        public RDS_O13_ORDERMap()
        {
            Map(x => x.ORC, 0, x => x.Required = true);
            Map(x => x.Timing, 1);
            Map(x => x.OrderDetail, 2);
            Map(x => x.Encoding, 3);
            Map(x => x.RXD, 4, x => x.Required = true);
            Map(x => x.NTE, 5);
            Map(x => x.RXR, 6, x => x.Required = true);
            Map(x => x.RXC, 7);
            Map(x => x.Observation, 8);
            Map(x => x.FT1, 9);
        }
    }
}