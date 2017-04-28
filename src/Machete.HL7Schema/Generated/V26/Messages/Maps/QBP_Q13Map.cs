// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// QBP_Q13 (MessageMap) - 
    /// </summary>
    public class QBP_Q13Map :
        HL7TemplateMap<QBP_Q13>
    {
        public QBP_Q13Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.QPD, 3, x => x.Required = true);
            Map(x => x.RDF, 4);
            Map(x => x.RCP, 5, x => x.Required = true);
            Map(x => x.DSC, 6);
        }
    }
}