using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.MultiPlayer
{
    public partial class IngredientDataSync : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new IngredientDataSync();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.MultiPlayer.IngredientDataSync", 0, Black.MultiPlayer.IngredientDataSync.ObjectType, null, properties, 4, 112);
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

            fieldProperties = new PropertyContainer("Black.MultiPlayer.IngredientDataSync", base.GetFieldProperties(), 247779651, 1290087252);
            
			
			
			return fieldProperties;
        }

		
    }
}