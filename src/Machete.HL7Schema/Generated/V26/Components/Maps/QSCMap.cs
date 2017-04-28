// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// QSC (ComponentMap) - Query Selection Criteria
    /// </summary>
    public class QSCMap :
        HL7ComponentMap<QSC>
    {
        public QSCMap()
        {
            Value(x => x.SegmentFieldName, 1);
            Value(x => x.RelationalOperator, 2);
            Value(x => x.Value, 3);
            Value(x => x.RelationalConjunction, 4);
        }
    }
}