// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PEX_P07_NK1_TIMING_QTY (GroupMap) - 
    /// </summary>
    public class PEX_P07_NK1_TIMING_QTYMap :
        HL7TemplateMap<PEX_P07_NK1_TIMING_QTY>
    {
        public PEX_P07_NK1_TIMING_QTYMap()
        {
            Map(x => x.TQ1, 0, x => x.Required = true);
            Map(x => x.TQ2, 1);
        }
    }
}