// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OUL_R23_PATIENT (GroupMap) - 
    /// </summary>
    public class OUL_R23_PATIENTMap :
        HL7TemplateMap<OUL_R23_PATIENT>
    {
        public OUL_R23_PATIENTMap()
        {
            Map(x => x.PID, 0, x => x.Required = true);
            Map(x => x.PD1, 1);
            Map(x => x.NTE, 2);
            Map(x => x.OBX, 3);
            Map(x => x.Visit, 4);
        }
    }
}