// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MFN_M16_STERILIZATION (GroupMap) - 
    /// </summary>
    public class MFN_M16_STERILIZATIONMap :
        HL7TemplateMap<MFN_M16_STERILIZATION>
    {
        public MFN_M16_STERILIZATIONMap()
        {
            Map(x => x.STZ, 0, x => x.Required = true);
            Map(x => x.NTE, 1);
        }
    }
}