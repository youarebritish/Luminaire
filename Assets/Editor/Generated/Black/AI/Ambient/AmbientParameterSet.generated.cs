using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AI.Ambient
{
    public partial class AmbientParameterSet : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float chatterMaxActivationDistance_;
		public float chatterMinSustainDistance_;
		public float chatterCoolDown_;
		public float individualChatterCoolDown_;
		public uint chatterScriptGroup_;
		public int numberOfActors_;
		public float spawnPointCameraZfar_;
		public float maxSpawnRadius_;
		public float minDespawnDistance_;
		public float spawnScoreHysteresis_;
		public float inCameraScoreMultiplier_;
		public float spawnAttemptInterval_;
		public float minAliveTime_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AmbientParameterSet();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AI.Ambient.AmbientParameterSet", 0, Black.AI.Ambient.AmbientParameterSet.ObjectType, null, properties, 0, 120);
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

            fieldProperties = new PropertyContainer("Black.AI.Ambient.AmbientParameterSet", base.GetFieldProperties(), -1422824044, 288541398);
            
			
			
			return fieldProperties;
        }

		
    }
}