using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Actor
{
    public partial class CharacterPackage : Black.Entity.Actor.ActorPackageBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new CharacterPackage();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Actor.CharacterPackage", 0, Black.Entity.Actor.CharacterPackage.ObjectType, null, properties, 0, 624);
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

            fieldProperties = new PropertyContainer("Black.Entity.Actor.CharacterPackage", base.GetFieldProperties(), -1799914922, 1712996706);
            return fieldProperties;
        }

		
    }
}