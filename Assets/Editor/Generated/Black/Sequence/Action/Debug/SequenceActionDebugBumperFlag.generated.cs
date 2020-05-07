using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Debug
{
    public partial class SequenceActionDebugBumperFlag : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin max_score;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin invincible_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin lineUp2_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin lineUp3_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_max_score;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_invincible;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_line2;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_later2;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionDebugBumperFlag();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Debug.SequenceActionDebugBumperFlag", 0, Black.Sequence.Action.Debug.SequenceActionDebugBumperFlag.ObjectType, null, properties, 0, 976);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Debug.SequenceActionDebugBumperFlag", base.GetFieldProperties(), 1435851565, -2117171676);
            return fieldProperties;
        }

		
    }
}