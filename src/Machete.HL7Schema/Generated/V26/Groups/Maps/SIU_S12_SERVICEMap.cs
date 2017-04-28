// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SIU_S12_SERVICE (GroupMap) - 
    /// </summary>
    public class SIU_S12_SERVICEMap :
        HL7TemplateMap<SIU_S12_SERVICE>
    {
        public SIU_S12_SERVICEMap()
        {
            Map(x => x.AIS, 0, x => x.Required = true);
            Map(x => x.NTE, 1);
        }
    }
}