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
            
			fieldProperties.AddIndirectlyProperty(new Property("StageScore1.TotalScore", 506148770, "int", 16, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("StageScore1.Point1", 1794800787, "int", 20, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("StageScore1.Point2", 1811578406, "int", 24, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("StageScore1.Point3", 1828356025, "int", 28, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("StageScore1.Point4", 1845133644, "int", 32, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("StageScore1.Point5", 1861911263, "int", 36, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("StageScore1.Point6", 1878688882, "int", 40, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("StageScore2.TotalScore", 1510035697, "int", 44, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("StageScore2.Point1", 3873540956, "int", 48, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("StageScore2.Point2", 3923873813, "int", 52, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("StageScore2.Point3", 3907096194, "int", 56, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("StageScore2.Point4", 3823208099, "int", 60, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("StageScore2.Point5", 3806430480, "int", 64, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("StageScore2.Point6", 3856763337, "int", 68, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("StageScore3.TotalScore", 4249599340, "int", 72, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("StageScore3.Point1", 2067035913, "int", 76, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("StageScore3.Point2", 2016703056, "int", 80, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("StageScore3.Point3", 2033480675, "int", 84, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("StageScore3.Point4", 2117368770, "int", 88, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("StageScore3.Point5", 2134146389, "int", 92, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("StageScore3.Point6", 2083813532, "int", 96, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("StageScore4.TotalScore", 1380419867, "int", 100, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("StageScore4.Point1", 4047583538, "int", 104, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("StageScore4.Point2", 4030805919, "int", 108, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("StageScore4.Point3", 4014028300, "int", 112, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("StageScore4.Point4", 3997250681, "int", 116, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("StageScore4.Point5", 3980473062, "int", 120, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("StageScore4.Point6", 3963695443, "int", 124, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
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