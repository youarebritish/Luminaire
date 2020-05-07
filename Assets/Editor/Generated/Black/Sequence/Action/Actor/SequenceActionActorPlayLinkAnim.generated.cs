using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor
{
    public partial class SequenceActionActorPlayLinkAnim : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stopPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin masterPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin slave1Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin slave2Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin slave3Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin slave4Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin slave5Pin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finishedPin_;
		public string sceneAssetPath_;
		public uint animID_;
		public float syncTime_;
		public bool bApplySlide_;
		public bool bKeepInSync_;
		public bool bKeepInSyncVertically_;
		public bool bSetInPosition_;
		public float alignAccelerationTime_;
		public float alignUniformTime_;
		public float alignDecelerationTime_;
		public bool bNotifyBodyLayer_;
		public float animTransitionTimeMaster_;
		public float animTransitionTimeSlave1_;
		public float animTransitionTimeSlave2_;
		public float animTransitionTimeSlave3_;
		public float animTransitionTimeSlave4_;
		public float animTransitionTimeSlave5_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorPlayLinkAnim();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.SequenceActionActorPlayLinkAnim", 0, Black.Sequence.Action.Actor.SequenceActionActorPlayLinkAnim.ObjectType, null, properties, 0, 1248);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.SequenceActionActorPlayLinkAnim", base.GetFieldProperties(), 1950567818, -1178302052);
            return fieldProperties;
        }

		
    }
}