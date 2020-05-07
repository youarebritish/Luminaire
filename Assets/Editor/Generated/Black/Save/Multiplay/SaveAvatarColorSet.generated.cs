using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Multiplay
{
    public partial class SaveAvatarColorSet
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public Black.Save.Multiplay.SaveAvatarColor Color1;
		public Black.Save.Multiplay.SaveAvatarColor Color2;
		public Black.Save.Multiplay.SaveAvatarColor Color3;
		public Black.Save.Multiplay.SaveAvatarColor Color4;
		public Black.Save.Multiplay.SaveAvatarColor Color5;
		public Black.Save.Multiplay.SaveAvatarColor Color6;
		public Black.Save.Multiplay.SaveAvatarColor Color7;
		public Black.Save.Multiplay.SaveAvatarColor Color8;
		public Black.Save.Multiplay.SaveAvatarColor Color9;
		public Black.Save.Multiplay.SaveAvatarColor Color10;
		public Black.Save.Multiplay.SaveAvatarColor Color11;
		public Black.Save.Multiplay.SaveAvatarColor Color12;
		public Black.Save.Multiplay.SaveAvatarColor Color13;
		public Black.Save.Multiplay.SaveAvatarColor Color14;
		public Black.Save.Multiplay.SaveAvatarColor Color15;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveAvatarColorSet();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Multiplay.SaveAvatarColorSet", 0, Black.Save.Multiplay.SaveAvatarColorSet.ObjectType, null, properties, 0, 240);
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

            fieldProperties = new PropertyContainer("Black.Save.Multiplay.SaveAvatarColorSet", null, 73179319, -1316285610);
            
			
			
			return fieldProperties;
        }

		
    }
}