// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RRE_O12_ENCODING (GroupMap) - 
    /// </summary>
    public class RRE_O12_ENCODINGMap :
        HL7TemplateMap<RRE_O12_ENCODING>
    {
        public RRE_O12_ENCODINGMap()
        {
            Map(x => x.RXE, 0, x => x.Required = true);
            Map(x => x.NTE, 1);
            Map(x => x.TimingEncoded, 2, x => x.Required = true);
            Map(x => x.RXR, 3, x => x.Required = true);
            Map(x => x.RXC, 4);
        }
    }
}