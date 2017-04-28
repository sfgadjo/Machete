// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// URD (SegmentMap) - Results/update Definition
    /// </summary>
    public class URDMap :
        HL7SegmentMap<URD>
    {
        public URDMap()
        {
            Id = "URD";

            Name = "Results/update Definition";

            Value(x => x.RUDateTime, 1, x => {x.Format = "LONGDATETIME1";});
            Value(x => x.ReportPriority, 2);
            Entity(x => x.RUWhoSubjectDefinition, 3, x => {x.Required = true;});
            Entity(x => x.RUWhatSubjectDefinition, 4);
            Entity(x => x.RUWhatDepartmentCode, 5);
            Value(x => x.RUDisplayPrintLocations, 6);
            Value(x => x.RUResultLevel, 7);
        }
    }
}