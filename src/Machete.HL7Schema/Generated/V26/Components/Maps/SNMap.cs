// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SN (ComponentMap) - Structured Numeric
    /// </summary>
    public class SNMap :
        HL7ComponentMap<SN>
    {
        public SNMap()
        {
            Value(x => x.Comparator, 1);
            Value(x => x.Num1, 2);
            Value(x => x.SeparatorSuffix, 3);
            Value(x => x.Num2, 4);
        }
    }
}