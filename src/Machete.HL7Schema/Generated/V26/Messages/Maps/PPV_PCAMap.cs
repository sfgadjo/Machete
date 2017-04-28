// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PPV_PCA (MessageMap) - 
    /// </summary>
    public class PPV_PCAMap :
        HL7TemplateMap<PPV_PCA>
    {
        public PPV_PCAMap()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.MSA, 3, x => x.Required = true);
            Map(x => x.ERR, 4);
            Map(x => x.QAK, 5);
            Map(x => x.QRD, 6, x => x.Required = true);
            Map(x => x.Patient, 7, x => x.Required = true);
        }
    }
}