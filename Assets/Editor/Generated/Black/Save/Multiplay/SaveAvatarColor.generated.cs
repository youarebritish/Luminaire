using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Multiplay
{
    public partial class SaveAvatarColor
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float R;
		public float G;
		public float B;
		public bool IsDefault;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveAvatarColor();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Multiplay.SaveAvatarColor", 0, Black.Save.Multiplay.SaveAvatarColor.ObjectType, null, properties, 0, 16);
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

            fieldProperties = new PropertyContainer("Black.Save.Multiplay.SaveAvatarColor", null, -1901913412, -169482275);
            
			
			
			return fieldProperties;
        }

		
    }
}