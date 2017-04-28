// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ADT_AXX_PATIENT (GroupMap) - 
    /// </summary>
    public class ADT_AXX_PATIENTMap :
        HL7TemplateMap<ADT_AXX_PATIENT>
    {
        public ADT_AXX_PATIENTMap()
        {
            Map(x => x.PID, 0, x => x.Required = true);
            Map(x => x.PD1, 1);
            Map(x => x.ARV, 2);
            Map(x => x.MRG, 3, x => x.Required = true);
            Map(x => x.PV1, 4);
        }
    }
}