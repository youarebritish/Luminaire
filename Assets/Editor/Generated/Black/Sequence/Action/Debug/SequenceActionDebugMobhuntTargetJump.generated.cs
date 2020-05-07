using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Debug
{
    public partial class SequenceActionDebugMobhuntTargetJump : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin destinationValueId_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin seedPointValueId_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin finishIn_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin failedGetQuestId_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin successedGetQuestId_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin failedGetSeedPointId_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin successedGetSeedPointId_;
		public uint destinationEntryId_;
		public uint seedPointFixid_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin questMarkerPosValue_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin questMarkerRadiusValue_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin seedPointValue_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionDebugMobhuntTargetJump();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Debug.SequenceActionDebugMobhuntTargetJump", 0, Black.Sequence.Action.Debug.SequenceActionDebugMobhuntTargetJump.ObjectType, null, properties, 0, 1448);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Debug.SequenceActionDebugMobhuntTargetJump", base.GetFieldProperties(), -195049386, 1062605403);
            return fieldProperties;
        }

		
    }
}