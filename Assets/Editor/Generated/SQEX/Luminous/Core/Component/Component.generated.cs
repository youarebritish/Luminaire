using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Luminous.Core.Component
{
    public partial class Component : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new Component();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Luminous.Core.Component.Component", 0, SQEX.Luminous.Core.Component.Component.ObjectType, null, properties, 1, 16);
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

            fieldProperties = new PropertyContainer("SQEX.Luminous.Core.Component.Component", base.GetFieldProperties(), 1522892175, 784953559);
            
			
			
			
			
			return fieldProperties;
        }

		
    }
}