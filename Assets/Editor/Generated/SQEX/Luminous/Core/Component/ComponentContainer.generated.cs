using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Luminous.Core.Component
{
    public partial class ComponentContainer : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ComponentContainer();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Luminous.Core.Component.ComponentContainer", 0, SQEX.Luminous.Core.Component.ComponentContainer.ObjectType, null, properties, 1, 32);
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

            fieldProperties = new PropertyContainer("SQEX.Luminous.Core.Component.ComponentContainer", base.GetFieldProperties(), -1081009144, 1781957579);
            
			
			
			return fieldProperties;
        }

		
    }
}