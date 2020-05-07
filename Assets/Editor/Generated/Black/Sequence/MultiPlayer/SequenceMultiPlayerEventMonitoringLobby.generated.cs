using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.MultiPlayer
{
    public partial class SequenceMultiPlayerEventMonitoringLobby : Black.Sequence.MultiPlayer.SequenceMultiPlayerSyncEventBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin enable_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin disable_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin progress1_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin progress2_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin progress3_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin progress4_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin errorOutputPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin remainTimeVarOut1Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin remainTimeVarOut2Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin remainTimeVarOut3Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin remainTimeVarOut4Pin_;
		public float checkIntervalTime_;
		public float progressTime1_;
		public float progressTime2_;
		public float progressTime3_;
		public float progressTime4_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceMultiPlayerEventMonitoringLobby();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.MultiPlayer.SequenceMultiPlayerEventMonitoringLobby", 0, Black.Sequence.MultiPlayer.SequenceMultiPlayerEventMonitoringLobby.ObjectType, null, properties, 0, 1384);
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

            fieldProperties = new PropertyContainer("Black.Sequence.MultiPlayer.SequenceMultiPlayerEventMonitoringLobby", base.GetFieldProperties(), -1025441981, -790432683);
            return fieldProperties;
        }

		
    }
}