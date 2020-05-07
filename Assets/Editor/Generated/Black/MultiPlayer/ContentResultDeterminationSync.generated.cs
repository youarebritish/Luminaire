using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.MultiPlayer
{
    public partial class ContentResultDeterminationSync : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ContentResultDeterminationSync();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.MultiPlayer.ContentResultDeterminationSync", 0, Black.MultiPlayer.ContentResultDeterminationSync.ObjectType, null, properties, 1, 2304);
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

            fieldProperties = new PropertyContainer("Black.MultiPlayer.ContentResultDeterminationSync", base.GetFieldProperties(), -1863949719, 146843846);
            
			
			
			return fieldProperties;
        }

		
    }
}