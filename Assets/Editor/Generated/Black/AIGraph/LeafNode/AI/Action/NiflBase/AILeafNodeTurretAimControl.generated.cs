using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Action.NiflBase
{
    public partial class AILeafNodeTurretAimControl : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum targetSlotType;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat shootingTime;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat coolTime;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeTurretAimControl();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Action.NiflBase.AILeafNodeTurretAimControl", 0, Black.AIGraph.LeafNode.AI.Action.NiflBase.AILeafNodeTurretAimControl.ObjectType, null, properties, 0, 168);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Action.NiflBase.AILeafNodeTurretAimControl", base.GetFieldProperties(), -1136497463, 2137831947);
            
			
			
			return fieldProperties;
        }

		
    }
}