// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// MO (Component) - Money
    /// </summary>
    public interface MO :
        HL7Component
    {
        /// <summary>
        /// MO-1  Quantity
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> Quantity { get; }

        /// <summary>
        /// MO-2  Denomination
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Denomination { get; }
    }
}