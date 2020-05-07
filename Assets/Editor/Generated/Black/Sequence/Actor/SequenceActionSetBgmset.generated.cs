using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor
{
    public partial class SequenceActionSetBgmset : Black.Sequence.Actor.SequenceActionBgmBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int bgmset_mode_;
		public int normal_bgm_id_;
		public int battle_bgm_id_;
		public int pinch_bgm_id_;
		public uint bgmset_fix_id_;
		public int bgmtype_mode_;
		public string idxFilePath_;
		public float fadeIn_;
		public float fadeOut_;
		public bool isSameSkip_;
		public bool isSetFade_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetBgmset();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SequenceActionSetBgmset", 0, Black.Sequence.Actor.SequenceActionSetBgmset.ObjectType, null, properties, 0, 432);
        }
		
        public override ObjectType GetObjectType()
        {
            return ObjectType;
        }

        protected override PropertyContainer GetFieldProperties()
        {
            if (fieldProperties != null)
            {
                return fieldProperties;
            }

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SequenceActionSetBgmset", base.GetFieldProperties(), -446417162, 39606297);
            
			fieldProperties.AddProperty(new Property("bgmset_mode_", 2772390812, "Black.Sound.Bgm.BGMSET_MODE", 376, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("normal_bgm_id_", 151278902, "SeadSoundID", 380, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("battle_bgm_id_", 3256204127, "SeadSoundID", 384, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("pinch_bgm_id_", 2917223055, "SeadSoundID", 388, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("bgmset_fix_id_", 675568466, "SQEX.Ebony.Std.Fixid", 392, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("bgmtype_mode_", 1084392658, "Black.Sound.BGMManager.BGM_TYPE", 396, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("idxFilePath_", 3786101086, "Ebony.Base.String", 400, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("fadeIn_", 2393447373, "float", 416, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("fadeOut_", 1067947950, "float", 420, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("isSameSkip_", 2882864173, "bool", 424, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isSetFade_", 1843133254, "bool", 425, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}