using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Tray
{
    public partial class AIGraphTrayBase : SQEX.Ebony.AIGraph.AIGraphSubstanceBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public IList<SQEX.Ebony.AIGraph.Node.AIGraphNodeBase> nodes_;
		public IList<SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBase> properties_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool debug_BlockWarningRunningWithNoChildren_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphTrayBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Tray.AIGraphTrayBase", 0, SQEX.Ebony.AIGraph.Tray.AIGraphTrayBase.ObjectType, null, properties, 0, 160);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Tray.AIGraphTrayBase", base.GetFieldProperties(), 575897381, -2143755722);
            
			fieldProperties.AddProperty(new Property("nodes_", 61650911, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.AIGraph.Node.AIGraphNodeBase*, MEMORY_CATEGORY_AI_GRAPH >", 48, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddProperty(new Property("properties_", 2753876537, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBase*, MEMORY_CATEGORY_AI_GRAPH >", 64, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddProperty(new Property("debug_BlockWarningRunningWithNoChildren_", 2490290986, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 80, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}