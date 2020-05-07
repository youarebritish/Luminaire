using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Common
{
    public partial class SaveCommonStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint presenceId_;
		public bool forbidSaveAnywhereFlag_;
		public int reserved_;
		public long reserved2_;
		public int noxScore_;
		public Black.Save.Multiplay.SavePlantMapDataStruct plantMapData_;
		public Black.Save.Common.SaveEpiScore ignis_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveCommonStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Common.SaveCommonStruct", 0, Black.Save.Common.SaveCommonStruct.ObjectType, null, properties, 0, 5008);
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

            fieldProperties = new PropertyContainer("Black.Save.Common.SaveCommonStruct", null, -1051156837, 1652488587);
            return fieldProperties;
        }

		
    }
}