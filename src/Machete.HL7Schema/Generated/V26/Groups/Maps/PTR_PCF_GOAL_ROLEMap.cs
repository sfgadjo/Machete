// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PTR_PCF_GOAL_ROLE (GroupMap) - 
    /// </summary>
    public class PTR_PCF_GOAL_ROLEMap :
        HL7TemplateMap<PTR_PCF_GOAL_ROLE>
    {
        public PTR_PCF_GOAL_ROLEMap()
        {
            Map(x => x.ROL, 0, x => x.Required = true);
            Map(x => x.VAR, 1);
        }
    }
}