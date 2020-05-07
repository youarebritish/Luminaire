using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Config
{
    public partial class SaveMultiplayerName
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public sbyte AvatarName;
		public object avatar_snapshot;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveMultiplayerName();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Config.SaveMultiplayerName", 0, Black.Save.Config.SaveMultiplayerName.ObjectType, null, properties, 0, 88);
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

            fieldProperties = new PropertyContainer("Black.Save.Config.SaveMultiplayerName", null, -1289344029, -2025813685);
            
			
			
			fieldProperties.AddProperty(new Property("AvatarName", 1652507647, "char", 0, 64, 64, Property.PrimitiveType.Int8, 0, (char)8));
			fieldProperties.AddProperty(new Property("avatar_snapshot", 3433826561, "Luminous.Core.Memory.Buffer", 64, 24, 1, Property.PrimitiveType.Buffer, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}