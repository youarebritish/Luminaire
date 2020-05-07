using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Multiplay
{
    public partial class SaveAvatarStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int version;
		public Black.Save.Multiplay.SaveAvatarDataStruct avatar;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveAvatarStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Multiplay.SaveAvatarStruct", 0, Black.Save.Multiplay.SaveAvatarStruct.ObjectType, null, properties, 0, 1672);
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

            fieldProperties = new PropertyContainer("Black.Save.Multiplay.SaveAvatarStruct", null, -1262150652, 2094231887);
            return fieldProperties;
        }

		
    }
}