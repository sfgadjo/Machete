// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// SQR_S25_GENERAL_RESOURCE (Group) - 
    /// </summary>
    public interface SQR_S25_GENERAL_RESOURCE :
        HL7Template
    {
        /// <summary>
        /// AIG
        /// </summary>
        Segment<AIG> AIG { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }
    }
}