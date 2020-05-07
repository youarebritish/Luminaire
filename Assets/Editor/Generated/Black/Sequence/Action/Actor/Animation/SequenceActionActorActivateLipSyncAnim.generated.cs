using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.Animation
{
    public partial class SequenceActionActorActivateLipSyncAnim : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actor_;
		public bool setDefaultParam;
		public int language_;
		public float interpParam_Time_;
		public float interpParam_Weight_;
		public bool interpParam_DebugDraw_;
		public float weightPhoneme_01_;
		public float weightPhoneme_02_;
		public float weightPhoneme_03_;
		public float weightPhoneme_04_;
		public float weightPhoneme_05_;
		public float weightPhoneme_06_;
		public float weightPhoneme_07_;
		public float weightPhoneme_08_;
		public float weightPhoneme_09_;
		public float weightPhoneme_10_;
		public float weightPhoneme_11_;
		public float weightPhoneme_12_;
		public float weightPhoneme_13_;
		public float weightPhoneme_14_;
		public float weightPhoneme_15_;
		public float weightPhoneme_16_;
		public float weightPhoneme_17_;
		public float weightPhoneme_18_;
		public float weightPhoneme_19_;
		public float weightPhoneme_20_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorActivateLipSyncAnim();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.Animation.SequenceActionActorActivateLipSyncAnim", 0, Black.Sequence.Action.Actor.Animation.SequenceActionActorActivateLipSyncAnim.ObjectType, null, properties, 0, 472);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.Animation.SequenceActionActorActivateLipSyncAnim", base.GetFieldProperties(), 342617665, -579427884);
            return fieldProperties;
        }

		
    }
}