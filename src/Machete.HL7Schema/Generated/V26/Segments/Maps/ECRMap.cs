// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ECR (SegmentMap) - Equipment Command Response
    /// </summary>
    public class ECRMap :
        HL7SegmentMap<ECR>
    {
        public ECRMap()
        {
            Id = "ECR";

            Name = "Equipment Command Response";

            Entity(x => x.CommandResponse, 1, x => {x.Required = true;});
            Value(x => x.DateTimeCompleted, 2, x => {x.Format = "LONGDATETIME2";x.Required = true;});
            Value(x => x.CommandResponseParameters, 3);
        }
    }
}