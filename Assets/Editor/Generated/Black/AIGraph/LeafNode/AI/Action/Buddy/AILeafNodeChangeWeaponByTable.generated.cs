using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Action.Buddy
{
    public partial class AILeafNodeChangeWeaponByTable : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid paramID;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum targetSlotType;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeChangeWeaponByTable();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Action.Buddy.AILeafNodeChangeWeaponByTable", 0, Black.AIGraph.LeafNode.AI.Action.Buddy.AILeafNodeChangeWeaponByTable.ObjectType, null, properties, 0, 120);
        }
		
        public override ObjectType GetObjectType()
        {
            return ObjectType;
        }

        protected override PropertyContainer GetFieldProperties()
        {
            if (fieldProperties != null)
            {
                return fieldProperties;
            }

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Action.Buddy.AILeafNodeChangeWeaponByTable", base.GetFieldProperties(), -167806862, 1161066252);
            return fieldProperties;
        }

		
    }
}