using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor
{
    public partial class SequenceActionActorPlayBodyLinkAnim : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin playPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stopPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pinningPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin masterPointPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin masterTargetPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finishedPin_;
		public string sceneAssetPath_;
		public bool bKeepInSyncVertically_;
		public float syncTime_;
		public bool syncFinish_;
		public int masterPointType_;
		public bool playAlive_;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem> penetrateRoleList_;
		public IList<Black.Sequence.Action.Actor.SequenceActionActorPlayBodyLinkAnimTransitionTime> transitionTimeList_;
		public IList<Black.Sequence.Action.Actor.SequenceActionActorPlayBodyLinkAnimStatus> statusList_;
		public bool bNotifyBodyLayer_;
		public bool bStopAI_;
		public uint facial_1_role_;
		public string facial_1_aniPath_;
		public float facial_1_blendTime_;
		public uint facial_2_role_;
		public string facial_2_aniPath_;
		public float facial_2_blendTime_;
		public uint facial_3_role_;
		public string facial_3_aniPath_;
		public float facial_3_blendTime_;
		public uint facial_4_role_;
		public string facial_4_aniPath_;
		public float facial_4_blendTime_;
		public string lastSceneAssetPath_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorPlayBodyLinkAnim();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.SequenceActionActorPlayBodyLinkAnim", 0, Black.Sequence.Action.Actor.SequenceActionActorPlayBodyLinkAnim.ObjectType, null, properties, 0, 1408);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.SequenceActionActorPlayBodyLinkAnim", base.GetFieldProperties(), 1741251185, 2095117162);
            
			
			
			return fieldProperties;
        }

		
    }
}