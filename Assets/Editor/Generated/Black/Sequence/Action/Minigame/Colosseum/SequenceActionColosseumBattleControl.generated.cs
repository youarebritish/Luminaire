using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Minigame.Colosseum
{
    public partial class SequenceActionColosseumBattleControl : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin okPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin groupA1Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin groupB1Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin groupC1Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin groupD1Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin restTimePin_;
		public uint swfOkInFixID_;
		public uint swfOkOutFixID_;
		public uint swfOkDecideFixID_;
		public uint swfOkFocusFixID_;
		public uint swfOkTextFieldFixID_;
		public uint swfrestTimeTextFieldFixID_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inBattleStartEffectEnd_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inRageEffectEnd_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inBattleEndStartEnd_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outBattleEnd_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outBattleStartEffectStart_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outBattleEndEffectStart_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outOneMonsterDie_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outOneTeamAllDie_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outOneMonsterRage_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outBattleStartFailed_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin layoutCharacterOutput_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin loseTeamIdxPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin rageCharacterPin_;
		public float battleTimeLimit_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionColosseumBattleControl();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Minigame.Colosseum.SequenceActionColosseumBattleControl", 0, Black.Sequence.Action.Minigame.Colosseum.SequenceActionColosseumBattleControl.ObjectType, null, properties, 0, 2256);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Minigame.Colosseum.SequenceActionColosseumBattleControl", base.GetFieldProperties(), 2076677538, -27597186);
            
			fieldProperties.AddProperty(new Property("okPin_", 1024220315, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 176, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("groupA1Pin_", 2278938306, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 264, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("groupB1Pin_", 3674081789, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 352, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("groupC1Pin_", 4047089092, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 440, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("groupD1Pin_", 387324551, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 528, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("restTimePin_", 1054440470, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 616, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfOkInFixID_", 2515263553, "SQEX.Ebony.Std.Fixid", 704, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfOkOutFixID_", 2901357672, "SQEX.Ebony.Std.Fixid", 708, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfOkDecideFixID_", 1099403794, "SQEX.Ebony.Std.Fixid", 712, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfOkFocusFixID_", 3732784084, "SQEX.Ebony.Std.Fixid", 716, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfOkTextFieldFixID_", 1358760885, "SQEX.Ebony.Std.Fixid", 720, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfrestTimeTextFieldFixID_", 2199933118, "SQEX.Ebony.Std.Fixid", 724, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 728, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inBattleStartEffectEnd_", 2703451843, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 824, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inRageEffectEnd_", 1817838880, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 920, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inBattleEndStartEnd_", 1796570533, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1016, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1112, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outBattleEnd_", 1097117047, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1208, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outBattleStartEffectStart_", 1990938223, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1304, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outBattleEndEffectStart_", 2237304702, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1400, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outOneMonsterDie_", 812210310, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1496, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outOneTeamAllDie_", 3363351848, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1592, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outOneMonsterRage_", 1817105373, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1688, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outBattleStartFailed_", 2188696391, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1784, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("layoutCharacterOutput_", 1482700400, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1880, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("loseTeamIdxPin_", 2773861060, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1968, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rageCharacterPin_", 649021503, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2056, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("battleTimeLimit_", 3226506350, "float", 2144, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}