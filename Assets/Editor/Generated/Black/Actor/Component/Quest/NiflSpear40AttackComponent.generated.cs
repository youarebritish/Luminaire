using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor.Component.Quest
{
    public partial class NiflSpear40AttackComponent
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new NiflSpear40AttackComponent();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.Component.Quest.NiflSpear40AttackComponent", 0, Black.Actor.Component.Quest.NiflSpear40AttackComponent.ObjectType, null, properties, 0, 1232);
        }
		
        public  ObjectType GetObjectType()
        {
            return ObjectType;
        }

        protected  PropertyContainer GetFieldProperties()
        {
            if (fieldProperties != null)
            {
                return fieldProperties;
            }

            fieldProperties = new PropertyContainer("Black.Actor.Component.Quest.NiflSpear40AttackComponent", null, 1937573592, 1588451978);
            
			
			
			
			
			return fieldProperties;
        }

		
    }
}