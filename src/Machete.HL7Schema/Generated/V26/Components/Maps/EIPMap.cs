// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// EIP (ComponentMap) - Entity Identifier Pair
    /// </summary>
    public class EIPMap :
        HL7V26ComponentMap<EIP>
    {
        public EIPMap()
        {
            Entity(x => x.PlacerAssignedIdentifier, 0);
            Entity(x => x.FillerAssignedIdentifier, 1);
        }
    }
}