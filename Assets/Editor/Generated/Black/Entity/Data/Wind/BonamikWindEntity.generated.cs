using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data.Wind
{
    public partial class BonamikWindEntity : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float scaling_;
		public bool isEnable_;
		public bool isEnableDraw_;
		public bool enableWeather_;
		public float windMultiplier_;
		public float speedMultiplier_;
		public float charaWindScale_;
		public float grassWindScale_;
		public float treeWindScale_;
		public int windType_;
		public int areaType_;
		public bool globalAddition_;
		public float areaRadius_;
		public float cylinderLength_;
		public UnityEngine.Vector4 boxSize_;
		public string bnmwndPath_;
		public float customWavePeriodMultiplication_;
		public UnityEngine.Vector4 windForce_;
		public UnityEngine.Vector4 randomRange_;
		public float randomTime_;
		public UnityEngine.Vector4 waveAmp_;
		public UnityEngine.Vector4 waveFreq_;
		public UnityEngine.Vector4 waveAmpOffset_;
		public UnityEngine.Vector4 waveFreqOffset_;
		public float waveTime_;
		public float tornadoStrength_;
		public float tornadoRadius_;
		public float blastStrength_;
		public float blastRange_;
		public float blastPeakInRange_;
		public float blastSpeed_;
		public bool blastIsLoop_;
		public int blastLoop_;
		public float windScale_;
		public bool isGlobalWindForGrass_;
		public float noiseMapSize_;
		public float noiseMapSpeed_;
		public float phaseShiftMapSize_;
		public float travelWindSpeed_;
		public float travelWindStrength_;
		public float maxWindStrength_;
		public bool enableGrassInteraction_;
		public float characterStr_;
		public float grassGscale_;
		public float grassBscale_;
		public float treeGscale_;
		public float treeBscale_;
		public float treeLODdistance1_;
		public float treeLODdistance2_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BonamikWindEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.Wind.BonamikWindEntity", 0, Black.Entity.Data.Wind.BonamikWindEntity.ObjectType, null, properties, 0, 592);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.Wind.BonamikWindEntity", base.GetFieldProperties(), -1920326348, -65371055);
            return fieldProperties;
        }

		
    }
}