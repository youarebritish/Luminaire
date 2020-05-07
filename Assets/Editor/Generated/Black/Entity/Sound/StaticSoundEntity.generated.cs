using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Sound
{
    public partial class StaticSoundEntity : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool streaming_;
		public float soundVolume_;
		public float fadeTimeVol;
		public float soundPitch_;
		public float fadeTimePitch;
		public float soundFadeInTime_;
		public float soundFadeOutTime_;
		public bool soundVisibleFlag_;
		public bool soundLoopFlag_;
		public string idxFilePath_;
		public int soundNumber_;
		public bool usePrimitiveFlag_;
		public float scaling_;
		public UnityEngine.Vector4 scalingVec_;
		public int soundobjType_;
		public float audibleRange_;
		public float innerRange_;
		public IList<Black.Entity.Sound.StaticSoundPositionArrayItem> positionEntityList_;
		public float pan;
		public float frpan;
		public float udpan;
		public float fadeTimePan;
		public float interiorFactor_;
		public bool useNavSoundFlag_;
		public int priorityType_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new StaticSoundEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Sound.StaticSoundEntity", 0, Black.Entity.Sound.StaticSoundEntity.ObjectType, null, properties, 0, 608);
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

            fieldProperties = new PropertyContainer("Black.Entity.Sound.StaticSoundEntity", base.GetFieldProperties(), -1681302104, -164729774);
            
			
			
			return fieldProperties;
        }

		
    }
}