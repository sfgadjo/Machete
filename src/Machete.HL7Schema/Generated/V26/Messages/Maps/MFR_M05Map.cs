// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MFR_M05 (MessageMap) - 
    /// </summary>
    public class MFR_M05Map :
        HL7TemplateMap<MFR_M05>
    {
        public MFR_M05Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.MSA, 3, x => x.Required = true);
            Map(x => x.ERR, 4);
            Map(x => x.QAK, 5);
            Map(x => x.QRD, 6, x => x.Required = true);
            Map(x => x.QRF, 7);
            Map(x => x.MFI, 8, x => x.Required = true);
            Map(x => x.MfQuery, 9, x => x.Required = true);
            Map(x => x.DSC, 10);
        }
    }
}