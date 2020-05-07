using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.AI.AIMode
{
    public partial class SequenceActionExecAIModeLead : Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin target_;
		public uint routeId_;
		public int movement_;
		public float speedRate_;
		public float enableWaitDistance_;
		public float disableWaitDistance_;
		public float arrivalDistacne_;
		public float successDistance_;
		public float failedDistance_;
		public bool isWaitOnPointEntity_;
		public bool isLookBack_;
		public bool disableLookAtIK;
		public bool isTryToKeepLead_;
		public uint sceneId_;
		public uint waitStartScriptGroupId_;
		public uint waitOutScriptGroupId_;
		public uint arrivalScriptGroupId_;
		public bool isAutoLoadVoice_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionExecAIModeLead();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModeLead", 0, Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModeLead.ObjectType, null, properties, 0, 1504);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModeLead", base.GetFieldProperties(), -52565586, 1539837766);
            return fieldProperties;
        }

		
    }
}