using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Level
{
    public partial class LevelPackage : Black.Entity.EntityPackage
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new LevelPackage();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Level.LevelPackage", 0, Black.Entity.Level.LevelPackage.ObjectType, null, properties, 0, 608);
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

            fieldProperties = new PropertyContainer("Black.Entity.Level.LevelPackage", base.GetFieldProperties(), -1322716771, 971468115);
            return fieldProperties;
        }

		
    }
}