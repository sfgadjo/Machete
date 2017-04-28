// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RDR_RDR_DISPENSE (GroupMap) - 
    /// </summary>
    public class RDR_RDR_DISPENSEMap :
        HL7TemplateMap<RDR_RDR_DISPENSE>
    {
        public RDR_RDR_DISPENSEMap()
        {
            Map(x => x.RXE, 0, x => x.Required = true);
            Map(x => x.RXD, 1, x => x.Required = true);
            Map(x => x.RXR, 2, x => x.Required = true);
            Map(x => x.TQ1, 3, x => x.Required = true);
            Map(x => x.RXC, 4);
            Map(x => x.TQ2, 5);
        }
    }
}