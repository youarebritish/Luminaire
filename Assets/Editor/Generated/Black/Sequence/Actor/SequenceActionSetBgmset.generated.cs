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
            
			
			
			return fieldProperties;
        }

		
    }
}