using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Dinner
{
    public partial class SaveDinnerRecipeStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint id;
		public bool exist;
		public int count;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveDinnerRecipeStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Dinner.SaveDinnerRecipeStruct", 0, Black.Save.Dinner.SaveDinnerRecipeStruct.ObjectType, null, properties, 0, 12);
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

            fieldProperties = new PropertyContainer("Black.Save.Dinner.SaveDinnerRecipeStruct", null, 1733885035, -53797648);
            return fieldProperties;
        }

		
    }
}