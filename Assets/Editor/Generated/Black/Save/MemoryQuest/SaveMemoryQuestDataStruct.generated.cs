using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.MemoryQuest
{
    public partial class SaveMemoryQuestDataStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public long worldTime_;
		public string areaFilePath;
		public SQEX.Luminous.Math.DoubleVector4 playerWorldPos;
		public UnityEngine.Vector4 playerRotation;
		public int weatherType_;
		public uint campPoint_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveMemoryQuestDataStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.MemoryQuest.SaveMemoryQuestDataStruct", 0, Black.Save.MemoryQuest.SaveMemoryQuestDataStruct.ObjectType, null, properties, 0, 96);
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

            fieldProperties = new PropertyContainer("Black.Save.MemoryQuest.SaveMemoryQuestDataStruct", null, 1223645893, 1185758535);
            
			
			
			return fieldProperties;
        }

		
    }
}