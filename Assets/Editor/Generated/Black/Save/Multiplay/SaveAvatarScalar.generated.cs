using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Multiplay
{
    public partial class SaveAvatarScalar
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float Value;
		public bool IsDefault;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveAvatarScalar();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Multiplay.SaveAvatarScalar", 0, Black.Save.Multiplay.SaveAvatarScalar.ObjectType, null, properties, 0, 8);
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

            fieldProperties = new PropertyContainer("Black.Save.Multiplay.SaveAvatarScalar", null, -393543420, -958162168);
            
			
			
			return fieldProperties;
        }

		
    }
}