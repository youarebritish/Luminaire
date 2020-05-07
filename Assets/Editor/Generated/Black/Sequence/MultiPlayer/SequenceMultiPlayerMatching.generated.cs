using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.MultiPlayer
{
    public partial class SequenceMultiPlayerMatching : Black.Sequence.Action.System.SequenceActionAccessOnlineBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin joinPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin quickMatchingPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin close_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin release_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin sortiePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin retryOpenPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin singlePlayPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin successjoin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin failed_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin slotPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin roomIdPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin roomIdUpperPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin roomKeyOverridePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin codeNumberPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin campNamePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin anyRegionPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin coopTypePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin isInRoomPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin playerCharacterPin_;
		public int slot_;
		public int roomId_;
		public bool isNeedOpenConnectDialog_;
		public bool isDebug_;
		public int coopType_;
		public int playerCharacter_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceMultiPlayerMatching();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.MultiPlayer.SequenceMultiPlayerMatching", 0, Black.Sequence.MultiPlayer.SequenceMultiPlayerMatching.ObjectType, null, properties, 0, 2200);
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

            fieldProperties = new PropertyContainer("Black.Sequence.MultiPlayer.SequenceMultiPlayerMatching", base.GetFieldProperties(), -1520664721, 1173485957);
            return fieldProperties;
        }

		
    }
}