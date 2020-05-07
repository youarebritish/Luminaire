using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.MultiPlayer
{
    public partial class SequenceMultiPlayerLobbyConnect : Black.Sequence.Action.System.SequenceActionAccessOnlineBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin disconnectPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin reconnectPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin success_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin fail_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin destinationIPAddressPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin destinationPortPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin failReasonOutPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin failParam1OutPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin serverIdOutPin_;
		public bool isRetail_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceMultiPlayerLobbyConnect();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.MultiPlayer.SequenceMultiPlayerLobbyConnect", 0, Black.Sequence.MultiPlayer.SequenceMultiPlayerLobbyConnect.ObjectType, null, properties, 0, 1120);
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

            fieldProperties = new PropertyContainer("Black.Sequence.MultiPlayer.SequenceMultiPlayerLobbyConnect", base.GetFieldProperties(), 100995036, 1918452992);
            return fieldProperties;
        }

		
    }
}