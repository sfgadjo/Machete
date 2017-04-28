// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// DFT_P03_COMMON_ORDER (GroupMap) - 
    /// </summary>
    public class DFT_P03_COMMON_ORDERMap :
        HL7TemplateMap<DFT_P03_COMMON_ORDER>
    {
        public DFT_P03_COMMON_ORDERMap()
        {
            Map(x => x.ORC, 0);
            Map(x => x.TimingQuantity, 1);
            Map(x => x.Order, 2);
            Map(x => x.Observation, 3);
        }
    }
}