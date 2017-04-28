// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// IIM (SegmentMap) - Inventory Item Master
    /// </summary>
    public class IIMMap :
        HL7SegmentMap<IIM>
    {
        public IIMMap()
        {
            Id = "IIM";

            Name = "Inventory Item Master";

            Entity(x => x.PrimaryKeyValue, 1, x => {x.Required = true;});
            Entity(x => x.ServiceItemCode, 2, x => {x.Required = true;});
            Value(x => x.InventoryLotNumber, 3);
            Value(x => x.InventoryExpirationDate, 4, x => {x.Format = "LONGDATETIME4";});
            Entity(x => x.InventoryManufacturerName, 5);
            Entity(x => x.InventoryLocation, 6);
            Value(x => x.InventoryReceivedDate, 7, x => {x.Format = "LONGDATETIME7";});
            Value(x => x.InventoryReceivedQuantity, 8);
            Entity(x => x.InventoryReceivedQuantityUnit, 9);
            Entity(x => x.InventoryReceivedItemCost, 10);
            Value(x => x.InventoryOnHandDate, 11, x => {x.Format = "LONGDATETIME11";});
            Value(x => x.InventoryOnHandQuantity, 12);
            Entity(x => x.InventoryOnHandQuantityUnit, 13);
            Entity(x => x.ProcedureCode, 14);
            Entity(x => x.ProcedureCodeModifier, 15);
        }
    }
}