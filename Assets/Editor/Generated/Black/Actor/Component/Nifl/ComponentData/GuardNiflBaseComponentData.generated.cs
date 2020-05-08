using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor.Component.Nifl.ComponentData
{
    public partial class GuardNiflBaseComponentData : Black.Actor.Component.ActorComponentData
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new GuardNiflBaseComponentData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.Component.Nifl.ComponentData.GuardNiflBaseComponentData", 0, Black.Actor.Component.Nifl.ComponentData.GuardNiflBaseComponentData.ObjectType, Construct, properties, 0, 64);
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

            fieldProperties = new PropertyContainer("Black.Actor.Component.Nifl.ComponentData.GuardNiflBaseComponentData", base.GetFieldProperties(), 801886968, 707822489);
            
			
			
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new GuardNiflBaseComponentData();
        }
		
    }
}