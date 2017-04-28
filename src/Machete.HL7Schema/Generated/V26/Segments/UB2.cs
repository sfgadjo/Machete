// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// UB2 (Segment) - UB92 Data
    /// </summary>
    public interface UB2 :
        HL7Segment
    {
        /// <summary>
        /// UB2-1: Set ID - UB2
        /// </summary>
        Value<int> SetId { get; }

        /// <summary>
        /// UB2-2: Co-Insurance Days (9)
        /// </summary>
        Value<string> CoInsuranceDays9 { get; }

        /// <summary>
        /// UB2-3: Condition Code (24-30)
        /// </summary>
        Value<string> ConditionCode2430 { get; }

        /// <summary>
        /// UB2-4: Covered Days (7)
        /// </summary>
        Value<string> CoveredDays7 { get; }

        /// <summary>
        /// UB2-5: Non-Covered Days (8)
        /// </summary>
        Value<string> NonCoveredDays8 { get; }

        /// <summary>
        /// UB2-6: Value Amount & Code
        /// </summary>
        Value<UVC> ValueAmountCode { get; }

        /// <summary>
        /// UB2-7: Occurrence Code & Date (32-35)
        /// </summary>
        Value<OCD> OccurrenceCodeDate3235 { get; }

        /// <summary>
        /// UB2-8: Occurrence Span Code/Dates (36)
        /// </summary>
        Value<OSP> OccurrenceSpanCodeDates { get; }

        /// <summary>
        /// UB2-9: UB92 Locator 2 (State)
        /// </summary>
        Value<string> UB92Locator2State { get; }

        /// <summary>
        /// UB2-10: UB92 Locator 11 (State)
        /// </summary>
        Value<string> UB92Locator11State { get; }

        /// <summary>
        /// UB2-11: UB92 Locator 31 (National)
        /// </summary>
        Value<string> UB92Locator31National { get; }

        /// <summary>
        /// UB2-12: Document Control Number
        /// </summary>
        Value<string> DocumentControlNumber { get; }

        /// <summary>
        /// UB2-13: UB92 Locator 49 (National)
        /// </summary>
        Value<string> UB92Locator49National { get; }

        /// <summary>
        /// UB2-14: UB92 Locator 56 (State)
        /// </summary>
        Value<string> UB92Locator56State { get; }

        /// <summary>
        /// UB2-15: UB92 Locator 57 (National)
        /// </summary>
        Value<string> UB92Locator57National { get; }

        /// <summary>
        /// UB2-16: UB92 Locator 78 (State)
        /// </summary>
        Value<string> UB92Locator78State { get; }

        /// <summary>
        /// UB2-17: Special Visit Count
        /// </summary>
        Value<decimal> SpecialVisitCount { get; }
    }
}