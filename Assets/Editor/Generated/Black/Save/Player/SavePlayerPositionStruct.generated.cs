using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Player
{
    public partial class SavePlayerPositionStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool available_;
		public double[] double_vector_;
		public UnityEngine.Vector4 rotation_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SavePlayerPositionStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Player.SavePlayerPositionStruct", 0, Black.Save.Player.SavePlayerPositionStruct.ObjectType, null, properties, 0, 64);
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

            fieldProperties = new PropertyContainer("Black.Save.Player.SavePlayerPositionStruct", null, -1276031611, -1240206129);
            return fieldProperties;
        }

		
    }
}