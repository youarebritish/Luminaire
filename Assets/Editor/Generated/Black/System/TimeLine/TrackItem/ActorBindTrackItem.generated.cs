using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem
{
    public partial class ActorBindTrackItem : SQEX.Ebony.Framework.TimeControl.TimeLine.TrackItem
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool isCharCollisionDisable_;
		public bool isBGCollisionDisable_;
		public float bgEnabledInterpolationTime_;
		public float bgEnabledSearchGroundLength_;
		public bool isInashaDisable_;
		public bool isResetMove_;
		public bool isWeaponOff_;
		public bool isTeleport_;
		public bool isActiveMask_;
		public bool isActiveCommandMask_;
		public bool isIkMask_;
		public bool isResetAI_;
		public bool isResetBody_;
		public bool isResetAnim_;
		public bool noAnimBlend_;
		public bool resetMotionPlaybackRateScaler_;
		public bool isResetBonamik_;
		public int bonamikPreRollStep_;
		public bool useMvBonamikPreRoll_;
		public bool isTrajectoryAlignDisable_;
		public bool isAnimRootFullControl_;
		public bool isResetMasts_;
		public bool isPresence_;
		public bool setCanUserCommand_;
		public bool isSoundFootDisable_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ActorBindTrackItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.ActorBindTrackItem", 0, Black.System.TimeLine.TrackItem.ActorBindTrackItem.ObjectType, null, properties, 0, 128);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.ActorBindTrackItem", base.GetFieldProperties(), 630843904, -69983489);
            
			
			
			return fieldProperties;
        }

		
    }
}