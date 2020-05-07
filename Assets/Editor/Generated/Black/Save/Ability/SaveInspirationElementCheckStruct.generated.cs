using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Ability
{
    public partial class SaveInspirationElementCheckStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int count;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveInspirationElementCheckStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Ability.SaveInspirationElementCheckStruct", 0, Black.Save.Ability.SaveInspirationElementCheckStruct.ObjectType, null, properties, 0, 4);
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

            fieldProperties = new PropertyContainer("Black.Save.Ability.SaveInspirationElementCheckStruct", null, -1206440097, 1048210888);
            return fieldProperties;
        }

		
    }
}