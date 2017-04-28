// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PPR_PC1_GOAL_OBSERVATION (GroupMap) - 
    /// </summary>
    public class PPR_PC1_GOAL_OBSERVATIONMap :
        HL7TemplateMap<PPR_PC1_GOAL_OBSERVATION>
    {
        public PPR_PC1_GOAL_OBSERVATIONMap()
        {
            Map(x => x.OBX, 0, x => x.Required = true);
            Map(x => x.NTE, 1);
        }
    }
}