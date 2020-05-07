using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor
{
    public partial class SequenceActionActorBind : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin bind_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin unBind_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actor_;
		public int filterLevel_;
		public bool isScopeEnd_;
		public bool isCollision_;
		public bool isBGCollisionDisable_;
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
		public float bgEnabledInterpolationTime_;
		public float bgEnabledSearchGroundLength_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorBind();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.SequenceActionActorBind", 0, Black.Sequence.Action.Actor.SequenceActionActorBind.ObjectType, null, properties, 0, 600);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.SequenceActionActorBind", base.GetFieldProperties(), -1408613984, -1123484212);
            return fieldProperties;
        }

		
    }
}