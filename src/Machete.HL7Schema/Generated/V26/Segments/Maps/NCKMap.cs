// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// NCK (SegmentMap) - System Clock
    /// </summary>
    public class NCKMap :
        HL7SegmentMap<NCK>
    {
        public NCKMap()
        {
            Id = "NCK";

            Name = "System Clock";

            Value(x => x.SystemDateTime, 1, x => {x.Format = "LONGDATETIME1";x.Required = true;});
        }
    }
}