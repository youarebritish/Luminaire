using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Node
{
    public partial class ClimateChangeArea2Entity : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool enableTrigger_;
		public UnityEngine.Vector4 scaling_;
		public int triggerType_;
		public uint climateId_;
		public string weatherKey_;
		public short priorityLevel_;
		public float transitionTime_;
		public bool isIndoorEnv_;
		public bool drawSky_;
		public bool useMainLight_;
		public bool updateWeather_;
		public bool updateFoliage_;
		public bool updateHeightMap_;
		public bool updateOceans_;
		public bool useFullResWaterSSR_;
		public bool rainOcclusionMapSettingOverride_;
		public float rainOcclusionMapHeight_;
		public float rainOcclusionMapDepth_;
		public bool useAniso_;
		public string preset_;
		public float fadeSec_;
		public uint eventId_;
		public uint eventEndId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ClimateChangeArea2Entity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Node.ClimateChangeArea2Entity", 0, Black.Entity.Node.ClimateChangeArea2Entity.ObjectType, null, properties, 0, 384);
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

            fieldProperties = new PropertyContainer("Black.Entity.Node.ClimateChangeArea2Entity", base.GetFieldProperties(), 592108503, -923010447);
            return fieldProperties;
        }

		
    }
}