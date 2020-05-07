using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Core
{
    public partial class AIGraphContainer : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public IList<SQEX.Ebony.AIGraph.Node.AIGraphNodeEntryPoint> entryPoint_;
		public IList<SQEX.Ebony.AIGraph.Tray.AIGraphTrayBase> trays_;
		public IList<SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase> leafs_;
		public int layer_;
		public IList<SQEX.Ebony.AIGraph.Data.ConstantValue.ConstantValueData> constantValueList_;
		public IList<SQEX.Ebony.AIGraph.Core.AIGraphCompiledExpression> compiledExpressionCacheList_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphContainer();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Core.AIGraphContainer", 0, SQEX.Ebony.AIGraph.Core.AIGraphContainer.ObjectType, null, properties, 0, 224);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Core.AIGraphContainer", base.GetFieldProperties(), -1622162244, 1428221721);
            
			
			
			return fieldProperties;
        }

		
    }
}