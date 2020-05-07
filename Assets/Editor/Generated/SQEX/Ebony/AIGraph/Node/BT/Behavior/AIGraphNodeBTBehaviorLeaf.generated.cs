using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Node.BT.Behavior
{
    public partial class AIGraphNodeBTBehaviorLeaf : SQEX.Ebony.AIGraph.Node.BT.Behavior.AIGraphNodeBTBehaviorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int leafIndex_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphNodeBTBehaviorLeaf();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Node.BT.Behavior.AIGraphNodeBTBehaviorLeaf", 0, SQEX.Ebony.AIGraph.Node.BT.Behavior.AIGraphNodeBTBehaviorLeaf.ObjectType, null, properties, 0, 224);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Node.BT.Behavior.AIGraphNodeBTBehaviorLeaf", base.GetFieldProperties(), -92917868, -114541189);
            return fieldProperties;
        }

		
    }
}