using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor
{
    public partial class SequenceActionActorPlayLmAnimation : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin playPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stopPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stopAllPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin forceStopPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin forceStopAllPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actorPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin motionIdPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin aniPathPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin blendTimePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin playbackRatePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin startTimePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finishedPin_;
		public bool isHook_;
		public string aniPath_;
		public uint motionId_;
		public float blendTime_;
		public float playbackRate_;
		public float startTime_;
		public bool isMirrored_;
		public uint hookMessage_;
		public bool postToBody_;
		public uint layerId_;
		public int matchTrigger_;
		public int rootRotationType_;
		public int rootTranslationType_;
		public bool freezeSource_;
		public bool freezeTarget_;
		public bool noAnimFacingRecompute_;
		public bool noAnimOriginRecompute_;
		public bool lockAnimFacing_;
		public bool lockAnimOrigin_;
		public bool stopWhenReplay_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorPlayLmAnimation();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.SequenceActionActorPlayLmAnimation", 0, Black.Sequence.Action.Actor.SequenceActionActorPlayLmAnimation.ObjectType, null, properties, 0, 1568);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.SequenceActionActorPlayLmAnimation", base.GetFieldProperties(), 706358633, -1141218308);
            return fieldProperties;
        }

		
    }
}