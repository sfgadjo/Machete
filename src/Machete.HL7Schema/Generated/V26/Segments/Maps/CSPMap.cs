// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// CSP (SegmentMap) - Clinical Study Phase
    /// </summary>
    public class CSPMap :
        HL7SegmentMap<CSP>
    {
        public CSPMap()
        {
            Id = "CSP";

            Name = "Clinical Study Phase";

            Entity(x => x.StudyPhaseIdentifier, 1, x => {x.Required = true;});
            Value(x => x.DateTimeStudyPhaseBegan, 2, x => {x.Format = "LONGDATETIME2";x.Required = true;});
            Value(x => x.DateTimeStudyPhaseEnded, 3, x => {x.Format = "LONGDATETIME3";});
            Entity(x => x.StudyPhaseEvaluability, 4);
        }
    }
}