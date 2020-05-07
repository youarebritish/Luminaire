using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Mobhunt
{
    public partial class SaveMobhuntMainStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int version_;
		public Black.Save.Mobhunt.SaveMobhuntStruct mobhuntDinnerData;
		public int killCount_;
		public int killCount1_;
		public int killCount2_;
		public int currenDinnerId_;
		public int rank_;
		public int exp_;
		public int currentDinnerQuestTargetId_;
		public Black.Save.Mobhunt.SaveMobhuntVDataStruct mobhuntVData;
		public bool isFistMobhuntClear_;
		public bool isAdamanClear_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveMobhuntMainStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Mobhunt.SaveMobhuntMainStruct", 0, Black.Save.Mobhunt.SaveMobhuntMainStruct.ObjectType, null, properties, 0, 166568);
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

            fieldProperties = new PropertyContainer("Black.Save.Mobhunt.SaveMobhuntMainStruct", null, -518804172, -297682609);
            
			
			
			return fieldProperties;
        }

		
    }
}