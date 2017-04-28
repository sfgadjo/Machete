// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// DSC (Segment) - Continuation Pointer
    /// </summary>
    public interface DSC :
        HL7Segment
    {
        /// <summary>
        /// DSC-1: Continuation Pointer
        /// </summary>
        Value<string> ContinuationPointer { get; }

        /// <summary>
        /// DSC-2: Continuation Style
        /// </summary>
        Value<string> ContinuationStyle { get; }
    }
}