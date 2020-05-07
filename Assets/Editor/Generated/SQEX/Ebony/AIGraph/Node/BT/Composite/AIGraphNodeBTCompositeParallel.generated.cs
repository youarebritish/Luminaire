using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Node.BT.Composite
{
    public partial class AIGraphNodeBTCompositeParallel : SQEX.Ebony.AIGraph.Node.BT.Composite.AIGraphNodeBTCompositeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphNodeBTCompositeParallel();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Node.BT.Composite.AIGraphNodeBTCompositeParallel", 0, SQEX.Ebony.AIGraph.Node.BT.Composite.AIGraphNodeBTCompositeParallel.ObjectType, null, properties, 0, 216);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Node.BT.Composite.AIGraphNodeBTCompositeParallel", base.GetFieldProperties(), -2084129462, 617502009);
            
			
			
			return fieldProperties;
        }

		
    }
}