// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RSP_Z90_QUERY_RESPONSE (Group) - 
    /// </summary>
    public interface RSP_Z90_QUERY_RESPONSE :
        HL7Template
    {
        /// <summary>
        /// PATIENT
        /// </summary>
        Group<RSP_Z90_PATIENT> Patient { get; }

        /// <summary>
        /// COMMON_ORDER
        /// </summary>
        GroupList<RSP_Z90_COMMON_ORDER> CommonOrder { get; }

        /// <summary>
        /// SPECIMEN
        /// </summary>
        GroupList<RSP_Z90_SPECIMEN> Specimen { get; }
    }
}