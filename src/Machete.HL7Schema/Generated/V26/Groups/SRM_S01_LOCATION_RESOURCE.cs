// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// SRM_S01_LOCATION_RESOURCE (Group) - 
    /// </summary>
    public interface SRM_S01_LOCATION_RESOURCE :
        HL7Template
    {
        /// <summary>
        /// AIL
        /// </summary>
        Segment<AIL> AIL { get; }

        /// <summary>
        /// APR
        /// </summary>
        Segment<APR> APR { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }
    }
}