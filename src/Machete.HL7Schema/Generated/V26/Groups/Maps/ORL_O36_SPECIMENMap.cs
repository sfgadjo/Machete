// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORL_O36_SPECIMEN (GroupMap) - 
    /// </summary>
    public class ORL_O36_SPECIMENMap :
        HL7TemplateMap<ORL_O36_SPECIMEN>
    {
        public ORL_O36_SPECIMENMap()
        {
            Map(x => x.SPM, 0, x => x.Required = true);
            Map(x => x.OBX, 1);
            Map(x => x.NTE, 2);
            Map(x => x.SpecimenContainer, 3, x => x.Required = true);
        }
    }
}