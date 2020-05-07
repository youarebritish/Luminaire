using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Node.BT.Composite
{
    public partial class AIGraphNodeBTCompositeForceSequence : SQEX.Ebony.AIGraph.Node.BT.Composite.AIGraphNodeBTCompositeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool bEvalFailWhenAllChildrenEvalFail;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphNodeBTCompositeForceSequence();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Node.BT.Composite.AIGraphNodeBTCompositeForceSequence", 0, SQEX.Ebony.AIGraph.Node.BT.Composite.AIGraphNodeBTCompositeForceSequence.ObjectType, null, properties, 0, 240);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Node.BT.Composite.AIGraphNodeBTCompositeForceSequence", base.GetFieldProperties(), -1854407412, -1477465581);
            return fieldProperties;
        }

		
    }
}