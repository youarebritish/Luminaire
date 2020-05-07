using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level.BattleArea
{
    public partial class SequenceActionSetBattleAreaEncountCondition : Black.Sequence.Action.Level.SequenceActionSetBattleAreaBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin battleAreaPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public bool conditionIncreaseChange_;
		public uint conditionIncreaseFixid_;
		public bool conditionDecreaseChange_;
		public uint conditionDecreaseFixid_;
		public bool conditionMaxChange_;
		public uint conditionMaxFixid_;
		public bool conditionOffChange_;
		public uint conditionOffFixid_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetBattleAreaEncountCondition();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.BattleArea.SequenceActionSetBattleAreaEncountCondition", 0, Black.Sequence.Action.Level.BattleArea.SequenceActionSetBattleAreaEncountCondition.ObjectType, null, properties, 0, 488);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.BattleArea.SequenceActionSetBattleAreaEncountCondition", base.GetFieldProperties(), -599566247, -1670541530);
            return fieldProperties;
        }

		
    }
}