// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// EHC_E01_PRODUCT_SERVICE_LINE_ITEM (GroupMap) - 
    /// </summary>
    public class EHC_E01_PRODUCT_SERVICE_LINE_ITEMMap :
        HL7TemplateMap<EHC_E01_PRODUCT_SERVICE_LINE_ITEM>
    {
        public EHC_E01_PRODUCT_SERVICE_LINE_ITEMMap()
        {
            Map(x => x.PSL, 0, x => x.Required = true);
            Map(x => x.NTE, 1);
            Map(x => x.ADJ, 2);
            Map(x => x.AUT, 3);
            Map(x => x.LOC, 4);
            Map(x => x.ROL, 5);
        }
    }
}