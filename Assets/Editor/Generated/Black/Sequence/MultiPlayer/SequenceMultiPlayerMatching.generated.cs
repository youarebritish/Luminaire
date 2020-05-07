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
            
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 192, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("joinPin_", 2848238693, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 288, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("quickMatchingPin_", 1671286071, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 384, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("close_", 552510516, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 480, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("release_", 2803113459, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 576, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("sortiePin_", 760471283, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 672, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("retryOpenPin_", 1501177201, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 768, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("singlePlayPin_", 2337046155, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 864, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 960, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("successjoin_", 1749670477, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1056, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("failed_", 2601209585, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1152, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("slotPin_", 3956440973, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1248, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("roomIdPin_", 3998404755, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1336, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("roomIdUpperPin_", 2632507069, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1424, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("roomKeyOverridePin_", 1923631101, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1512, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("codeNumberPin_", 813577969, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1600, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("campNamePin_", 3314815835, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1688, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("anyRegionPin_", 3518783265, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1776, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("coopTypePin_", 3263009024, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1864, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isInRoomPin_", 3483164049, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1952, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("playerCharacterPin_", 1875791275, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2040, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("slot_", 1761545578, "int", 2128, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("roomId_", 1842576920, "int", 2132, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("isNeedOpenConnectDialog_", 3621368994, "bool", 2136, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isDebug_", 815646837, "bool", 2137, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("coopType_", 2267675581, "int", 2140, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("playerCharacter_", 2905667168, "Black.Save.SAVE_PLAYER", 2144, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}