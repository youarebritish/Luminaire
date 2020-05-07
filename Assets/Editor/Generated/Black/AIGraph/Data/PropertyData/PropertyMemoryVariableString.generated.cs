using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Data.PropertyData
{
    public partial class PropertyMemoryVariableString : Black.AIGraph.Data.PropertyData.PropertyMemoryVariableBase
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

            var dummy = new PropertyMemoryVariableString();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Data.PropertyData.PropertyMemoryVariableString", 0, Black.AIGraph.Data.PropertyData.PropertyMemoryVariableString.ObjectType, null, properties, 0, 40);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Data.PropertyData.PropertyMemoryVariableString", base.GetFieldProperties(), 634156360, 1587298464);
            return fieldProperties;
        }

		
    }
}