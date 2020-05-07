using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Node.BT
{
    public partial class AIGraphNodeBTBehaviorMindTaskTray : SQEX.Ebony.AIGraph.Node.BT.AIGraphNodeBTBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid id;
		public int nodeIndex_;
		public int layer_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphNodeBTBehaviorMindTaskTray();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Node.BT.AIGraphNodeBTBehaviorMindTaskTray", 0, Black.AIGraph.Extend.Node.BT.AIGraphNodeBTBehaviorMindTaskTray.ObjectType, null, properties, 0, 376);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Node.BT.AIGraphNodeBTBehaviorMindTaskTray", base.GetFieldProperties(), 406068198, 209540399);
            return fieldProperties;
        }

		
    }
}