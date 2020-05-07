using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Node.Leaf
{
    public partial class AIGraphNodeLeafAssert : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyString text_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphNodeLeafAssert();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafAssert", 0, SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafAssert.ObjectType, null, properties, 0, 112);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafAssert", base.GetFieldProperties(), -1600787815, 1160991399);
            return fieldProperties;
        }

		
    }
}