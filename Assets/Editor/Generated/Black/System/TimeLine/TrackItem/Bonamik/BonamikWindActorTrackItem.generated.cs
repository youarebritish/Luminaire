using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Bonamik
{
    public partial class BonamikWindActorTrackItem : Black.System.TimeLine.TrackItem.BlendTrackItemBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int windType_;
		public uint bnmwndId_;
		public UnityEngine.Vector4 windForce_;
		public UnityEngine.Vector4 randomRange_;
		public float randomTime_;
		public float blastStrength_;
		public float blastRange_;
		public float blastPeakInRange_;
		public float blastSpeed_;
		public bool blastIsLoop_;
		public int blastLoop_;
		public float windMultiplier_;
		public float speedMultiplier_;
		public int windKind_;
		public int areaType_;
		public bool globalAddition_;
		public bool bOnlyThisActor_;
		public bool bFixedRotation_;
		public float radius_;
		public UnityEngine.Vector4 boxSize_;
		public int isAttach_;
		public uint elementId_;
		public UnityEngine.Vector4 attachOffset_;
		public UnityEngine.Vector4 position_;
		public UnityEngine.Vector4 rotation_;
		public bool isGlobalWindForGrass_;
		public float noiseMapSize_;
		public float noiseMapSpeed_;
		public float phaseShiftMapSize_;
		public float travelWindSpeed_;
		public float travelWindStrength_;
		public float maxWindStrength_;
		public bool enableGrassInteraction_;
		public float characterStr_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BonamikWindActorTrackItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Bonamik.BonamikWindActorTrackItem", 0, Black.System.TimeLine.TrackItem.Bonamik.BonamikWindActorTrackItem.ObjectType, null, properties, 0, 432);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Bonamik.BonamikWindActorTrackItem", base.GetFieldProperties(), 314083272, 1061867909);
            
			
			
			return fieldProperties;
        }

		
    }
}