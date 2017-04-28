// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// SQR_S25_RESOURCES (Group) - 
    /// </summary>
    public interface SQR_S25_RESOURCES :
        HL7Template
    {
        /// <summary>
        /// RGS
        /// </summary>
        Segment<RGS> RGS { get; }

        /// <summary>
        /// SERVICE
        /// </summary>
        GroupList<SQR_S25_SERVICE> Service { get; }

        /// <summary>
        /// GENERAL_RESOURCE
        /// </summary>
        GroupList<SQR_S25_GENERAL_RESOURCE> GeneralResource { get; }

        /// <summary>
        /// PERSONNEL_RESOURCE
        /// </summary>
        GroupList<SQR_S25_PERSONNEL_RESOURCE> PersonnelResource { get; }

        /// <summary>
        /// LOCATION_RESOURCE
        /// </summary>
        GroupList<SQR_S25_LOCATION_RESOURCE> LocationResource { get; }
    }
}