using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Mobhunt
{
    public partial class SaveMobhuntDataStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint id_;
		public bool isCleared_;
		public bool isRecieved_;
		public bool isReported_;
		public bool isKilledAll_;
		public bool isNew_;
		public IList<Black.Save.Mobhunt.SaveMobhuntVDataStructNew> mobhuntVDataNewArray_;
		public sbyte killCount0_;
		public sbyte killCount1_;
		public sbyte killCount2_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveMobhuntDataStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Mobhunt.SaveMobhuntDataStruct", 0, Black.Save.Mobhunt.SaveMobhuntDataStruct.ObjectType, null, properties, 0, 40);
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

            fieldProperties = new PropertyContainer("Black.Save.Mobhunt.SaveMobhuntDataStruct", null, -2065400598, -1936981960);
            
			
			
			return fieldProperties;
        }

		
    }
}