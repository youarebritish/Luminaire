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
            
			fieldProperties.AddProperty(new Property("id", 926444256, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid", 200, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("nodeIndex_", 207217860, "int", 232, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("layer_", 3015166475, "SQEX.Ebony.AIGraph.AIGRAPH_LAYER", 236, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}