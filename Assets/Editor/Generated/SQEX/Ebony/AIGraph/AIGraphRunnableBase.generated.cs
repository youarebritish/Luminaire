using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph
{
    public partial class AIGraphRunnableBase : SQEX.Ebony.Framework.Node.GraphNode
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int uid_;
		public int startNodeUid_;
		public bool bDisable_;
		public bool bSkipblackBoardInitialization_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphRunnableBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.AIGraphRunnableBase", 0, SQEX.Ebony.AIGraph.AIGraphRunnableBase.ObjectType, null, properties, 0, 48);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.AIGraphRunnableBase", base.GetFieldProperties(), -1596447987, 509830927);
            return fieldProperties;
        }

		
    }
}