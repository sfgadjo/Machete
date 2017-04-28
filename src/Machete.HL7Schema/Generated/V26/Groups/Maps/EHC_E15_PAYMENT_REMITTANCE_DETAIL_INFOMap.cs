// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// EHC_E15_PAYMENT_REMITTANCE_DETAIL_INFO (GroupMap) - 
    /// </summary>
    public class EHC_E15_PAYMENT_REMITTANCE_DETAIL_INFOMap :
        HL7TemplateMap<EHC_E15_PAYMENT_REMITTANCE_DETAIL_INFO>
    {
        public EHC_E15_PAYMENT_REMITTANCE_DETAIL_INFOMap()
        {
            Map(x => x.IPR, 0, x => x.Required = true);
            Map(x => x.IVC, 1, x => x.Required = true);
            Map(x => x.ProductServiceSection, 2, x => x.Required = true);
        }
    }
}