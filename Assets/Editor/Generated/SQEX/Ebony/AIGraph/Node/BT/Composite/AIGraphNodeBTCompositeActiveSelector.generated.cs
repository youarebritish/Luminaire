using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Node.BT.Composite
{
    public partial class AIGraphNodeBTCompositeActiveSelector : SQEX.Ebony.AIGraph.Node.BT.Composite.AIGraphNodeBTCompositeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphNodeBTCompositeActiveSelector();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Node.BT.Composite.AIGraphNodeBTCompositeActiveSelector", 0, SQEX.Ebony.AIGraph.Node.BT.Composite.AIGraphNodeBTCompositeActiveSelector.ObjectType, null, properties, 0, 216);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Node.BT.Composite.AIGraphNodeBTCompositeActiveSelector", base.GetFieldProperties(), 413991232, -518336537);
            
			
			
			return fieldProperties;
        }

		
    }
}