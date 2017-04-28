// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// DFT_P03_FINANCIAL_PROCEDURE (GroupMap) - 
    /// </summary>
    public class DFT_P03_FINANCIAL_PROCEDUREMap :
        HL7TemplateMap<DFT_P03_FINANCIAL_PROCEDURE>
    {
        public DFT_P03_FINANCIAL_PROCEDUREMap()
        {
            Map(x => x.PR1, 0, x => x.Required = true);
            Map(x => x.ROL, 1);
        }
    }
}