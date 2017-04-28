// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RAS_O17_ORDER (Group) - 
    /// </summary>
    public interface RAS_O17_ORDER :
        HL7Template
    {
        /// <summary>
        /// ORC
        /// </summary>
        Segment<ORC> ORC { get; }

        /// <summary>
        /// TIMING
        /// </summary>
        GroupList<RAS_O17_TIMING> Timing { get; }

        /// <summary>
        /// ORDER_DETAIL
        /// </summary>
        Group<RAS_O17_ORDER_DETAIL> OrderDetail { get; }

        /// <summary>
        /// ENCODING
        /// </summary>
        Group<RAS_O17_ENCODING> Encoding { get; }

        /// <summary>
        /// ADMINISTRATION
        /// </summary>
        GroupList<RAS_O17_ADMINISTRATION> Administration { get; }

        /// <summary>
        /// CTI
        /// </summary>
        SegmentList<CTI> CTI { get; }
    }
}