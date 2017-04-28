// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RER_RER (MessageMap) - 
    /// </summary>
    public class RER_RERMap :
        HL7TemplateMap<RER_RER>
    {
        public RER_RERMap()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.MSA, 1, x => x.Required = true);
            Map(x => x.ERR, 2);
            Map(x => x.SFT, 3);
            Map(x => x.UAC, 4);
            Map(x => x.Definition, 5, x => x.Required = true);
            Map(x => x.DSC, 6);
        }
    }
}