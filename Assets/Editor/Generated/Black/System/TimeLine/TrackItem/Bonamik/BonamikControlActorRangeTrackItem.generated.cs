using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Bonamik
{
    public partial class BonamikControlActorRangeTrackItem : Black.System.TimeLine.TrackItem.BlendTrackItemBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int ctrlType_;
		public int selectGroup_;
		public float animationBlendCoeff_;
		public float emissiveWindStr_;
		public float emissiveWaveAmp_;
		public float emissiveWaveTime_;
		public bool resetPose_;
		public float coneStrScale_;
		public float localForceScale_;
		public float timeStepScale_;
		public int preRoll_;
		public float addMass_;
		public bool stableMode_;
		public int subStep_;
		public int solverIter_;
		public int linkIter_;
		public int collIter_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BonamikControlActorRangeTrackItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Bonamik.BonamikControlActorRangeTrackItem", 0, Black.System.TimeLine.TrackItem.Bonamik.BonamikControlActorRangeTrackItem.ObjectType, null, properties, 0, 248);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Bonamik.BonamikControlActorRangeTrackItem", base.GetFieldProperties(), 1107179332, -390636217);
            return fieldProperties;
        }

		
    }
}