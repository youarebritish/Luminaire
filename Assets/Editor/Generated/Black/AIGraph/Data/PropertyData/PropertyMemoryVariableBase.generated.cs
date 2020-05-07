using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Data.PropertyData
{
    public partial class PropertyMemoryVariableBase : SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int targetSlotType_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new PropertyMemoryVariableBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Data.PropertyData.PropertyMemoryVariableBase", 0, Black.AIGraph.Data.PropertyData.PropertyMemoryVariableBase.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Data.PropertyData.PropertyMemoryVariableBase", base.GetFieldProperties(), 639676163, 75043450);
            return fieldProperties;
        }

		
    }
}