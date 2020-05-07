using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Node.Leaf
{
    public partial class AIGraphNodeLeafWaitTime : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat waitTime_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat waitTimeMax_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphNodeLeafWaitTime();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafWaitTime", 0, SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafWaitTime.ObjectType, null, properties, 0, 128);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafWaitTime", base.GetFieldProperties(), -1879145519, -297681796);
            
			
			
			return fieldProperties;
        }

		
    }
}