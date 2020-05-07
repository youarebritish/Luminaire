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
            return fieldProperties;
        }

		
    }
}