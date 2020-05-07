using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Node.Leaf
{
    public partial class AIGraphNodeLeafBase : SQEX.Ebony.AIGraph.AIGraphSubstanceBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphNodeLeafBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase", 0, SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase.ObjectType, null, properties, 0, 56);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase", base.GetFieldProperties(), 146570641, 25329154);
            return fieldProperties;
        }

		
    }
}