using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Node.BT.Composite
{
    public partial class AIGraphNodeBTCompositeSequence : SQEX.Ebony.AIGraph.Node.BT.Composite.AIGraphNodeBTCompositeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphNodeBTCompositeSequence();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Node.BT.Composite.AIGraphNodeBTCompositeSequence", 0, SQEX.Ebony.AIGraph.Node.BT.Composite.AIGraphNodeBTCompositeSequence.ObjectType, null, properties, 0, 208);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Node.BT.Composite.AIGraphNodeBTCompositeSequence", base.GetFieldProperties(), -466899937, -928471473);
            return fieldProperties;
        }

		
    }
}