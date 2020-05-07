using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Config
{
    public partial class SaveEpgFinalScore
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public sbyte ClearedMDay;
		public sbyte ClearedMonth;
		public short ClearedYear;
		public long PlayTime;
		public Black.Save.Config.SaveEpgStageScore StageScore1;
		public Black.Save.Config.SaveEpgStageScore StageScore2;
		public Black.Save.Config.SaveEpgStageScore StageScore3;
		public Black.Save.Config.SaveEpgStageScore StageScore4;
		public bool IsCleared;
		public int ItemScore;
		public int TotalScore;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveEpgFinalScore();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Config.SaveEpgFinalScore", 0, Black.Save.Config.SaveEpgFinalScore.ObjectType, null, properties, 0, 144);
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

            fieldProperties = new PropertyContainer("Black.Save.Config.SaveEpgFinalScore", null, 1697653825, 1318909800);
            
			fieldProperties.AddProperty(new Property("ClearedMDay", 3172167432, "char", 0, 1, 1, Property.PrimitiveType.Int8, 0, (char)0));
			fieldProperties.AddProperty(new Property("ClearedMonth", 3701886039, "char", 1, 1, 1, Property.PrimitiveType.Int8, 0, (char)0));
			fieldProperties.AddProperty(new Property("ClearedYear", 2473866390, "short", 2, 2, 1, Property.PrimitiveType.Int16, 0, (char)0));
			fieldProperties.AddProperty(new Property("PlayTime", 564247098, "int64_t", 8, 8, 1, Property.PrimitiveType.Int64, 0, (char)0));
			fieldProperties.AddProperty(new Property("StageScore1", 2634126084, "Black.Save.Config.SaveEpgStageScore", 16, 28, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("StageScore2", 2684458941, "Black.Save.Config.SaveEpgStageScore", 44, 28, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("StageScore3", 2667681322, "Black.Save.Config.SaveEpgStageScore", 72, 28, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("StageScore4", 2583793227, "Black.Save.Config.SaveEpgStageScore", 100, 28, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("IsCleared", 99008323, "bool", 128, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("ItemScore", 4080024340, "uint32_t", 132, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("TotalScore", 2725963789, "uint32_t", 136, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}