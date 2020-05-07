using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor.Component
{
    public partial class ActorComponentData : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ActorComponentData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.Component.ActorComponentData", 0, Black.Actor.Component.ActorComponentData.ObjectType, null, properties, 0, 64);
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

            fieldProperties = new PropertyContainer("Black.Actor.Component.ActorComponentData", base.GetFieldProperties(), 176092, 1098843350);
            
			
			
			return fieldProperties;
        }

		
    }
}