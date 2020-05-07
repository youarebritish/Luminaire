using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Data.ConstantValue
{
    public partial class ConstantValueInt : SQEX.Ebony.AIGraph.Data.ConstantValue.ConstantValueBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int value_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ConstantValueInt();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Data.ConstantValue.ConstantValueInt", 0, SQEX.Ebony.AIGraph.Data.ConstantValue.ConstantValueInt.ObjectType, null, properties, 0, 16);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Data.ConstantValue.ConstantValueInt", base.GetFieldProperties(), -859826694, 1347306027);
            
			
			
			fieldProperties.AddProperty(new Property("value_", 273093519, "int", 8, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}