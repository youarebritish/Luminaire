using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor.Component.Monster.ComponentData
{
    public partial class IActorMonsGambitComponentData : Black.Actor.Component.ActorComponentData
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new IActorMonsGambitComponentData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.Component.Monster.ComponentData.IActorMonsGambitComponentData", 0, Black.Actor.Component.Monster.ComponentData.IActorMonsGambitComponentData.ObjectType, null, properties, 0, 64);
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

            fieldProperties = new PropertyContainer("Black.Actor.Component.Monster.ComponentData.IActorMonsGambitComponentData", base.GetFieldProperties(), 1573238755, -778912207);
            
			
			
			
			
			return fieldProperties;
        }

		
    }
}