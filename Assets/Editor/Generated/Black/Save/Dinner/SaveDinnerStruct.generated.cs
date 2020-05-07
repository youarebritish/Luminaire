using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Dinner
{
    public partial class SaveDinnerStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint foodRecordId;
		public Black.Save.Dinner.SaveDinnerRecipeStruct recipe;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveDinnerStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Dinner.SaveDinnerStruct", 0, Black.Save.Dinner.SaveDinnerStruct.ObjectType, null, properties, 0, 3112);
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

            fieldProperties = new PropertyContainer("Black.Save.Dinner.SaveDinnerStruct", null, 204600937, -741481900);
            
			fieldProperties.AddProperty(new Property("foodRecordId", 4085127365, "SQEX.Ebony.Std.Fixid", 0, 40, 10, Property.PrimitiveType.Fixid, 0, (char)8));
			fieldProperties.AddProperty(new Property("recipe", 3967719375, "Black.Save.Dinner.SaveDinnerRecipeStruct", 40, 3072, 256, Property.PrimitiveType.ClassField, 0, (char)8));
			
			
			return fieldProperties;
        }

		
    }
}