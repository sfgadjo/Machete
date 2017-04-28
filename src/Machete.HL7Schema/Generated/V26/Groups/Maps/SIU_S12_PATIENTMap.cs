// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SIU_S12_PATIENT (GroupMap) - 
    /// </summary>
    public class SIU_S12_PATIENTMap :
        HL7TemplateMap<SIU_S12_PATIENT>
    {
        public SIU_S12_PATIENTMap()
        {
            Map(x => x.PID, 0, x => x.Required = true);
            Map(x => x.PD1, 1);
            Map(x => x.PV1, 2);
            Map(x => x.PV2, 3);
            Map(x => x.OBX, 4);
            Map(x => x.DG1, 5);
        }
    }
}