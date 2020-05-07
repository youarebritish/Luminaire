using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Node.BT.Composite
{
    public partial class AIGraphNodeBTCompositePriorityUpActiveSelector : SQEX.Ebony.AIGraph.Node.BT.Composite.AIGraphNodeBTCompositeActiveSelector
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphNodeBTCompositePriorityUpActiveSelector();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Node.BT.Composite.AIGraphNodeBTCompositePriorityUpActiveSelector", 0, SQEX.Ebony.AIGraph.Node.BT.Composite.AIGraphNodeBTCompositePriorityUpActiveSelector.ObjectType, null, properties, 0, 216);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Node.BT.Composite.AIGraphNodeBTCompositePriorityUpActiveSelector", base.GetFieldProperties(), -271888614, -158852131);
            
			
			
			return fieldProperties;
        }

		
    }
}