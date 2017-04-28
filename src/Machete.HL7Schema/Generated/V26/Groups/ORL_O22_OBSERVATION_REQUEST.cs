// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// ORL_O22_OBSERVATION_REQUEST (Group) - 
    /// </summary>
    public interface ORL_O22_OBSERVATION_REQUEST :
        HL7Template
    {
        /// <summary>
        /// OBR
        /// </summary>
        Segment<OBR> OBR { get; }

        /// <summary>
        /// ROL
        /// </summary>
        SegmentList<ROL> ROL { get; }

        /// <summary>
        /// SPECIMEN
        /// </summary>
        GroupList<ORL_O22_SPECIMEN> Specimen { get; }
    }
}