using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Data.PropertyData
{
    public partial class PropertyMemoryVariableInt : Black.AIGraph.Data.PropertyData.PropertyMemoryVariableBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int kind_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new PropertyMemoryVariableInt();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Data.PropertyData.PropertyMemoryVariableInt", 0, Black.AIGraph.Data.PropertyData.PropertyMemoryVariableInt.ObjectType, null, properties, 0, 40);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Data.PropertyData.PropertyMemoryVariableInt", base.GetFieldProperties(), -1630038637, 1447416893);
            
			
			
			return fieldProperties;
        }

		
    }
}