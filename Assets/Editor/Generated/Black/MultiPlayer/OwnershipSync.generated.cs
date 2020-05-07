using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.MultiPlayer
{
    public partial class OwnershipSync : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new OwnershipSync();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.MultiPlayer.OwnershipSync", 0, Black.MultiPlayer.OwnershipSync.ObjectType, null, properties, 6, 640);
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

            fieldProperties = new PropertyContainer("Black.MultiPlayer.OwnershipSync", base.GetFieldProperties(), 1185326739, -1709098466);
            
			
			
			return fieldProperties;
        }

		
    }
}