// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OCD (ComponentMap) - Occurrence Code and Date
    /// </summary>
    public class OCDMap :
        HL7ComponentMap<OCD>
    {
        public OCDMap()
        {
            Entity(x => x.OccurrenceCode, 1);
            Value(x => x.OccurrenceDate, 2, x => {x.Format = "LONGDATETIME2";});
        }
    }
}