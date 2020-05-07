using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.EventScript
{
    public partial class SaveEventScriptGroupDataStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint groupId;
		public long lastElapsedGameTime;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveEventScriptGroupDataStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.EventScript.SaveEventScriptGroupDataStruct", 0, Black.Save.EventScript.SaveEventScriptGroupDataStruct.ObjectType, null, properties, 0, 16);
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

            fieldProperties = new PropertyContainer("Black.Save.EventScript.SaveEventScriptGroupDataStruct", null, -2114477247, -909380189);
            return fieldProperties;
        }

		
    }
}