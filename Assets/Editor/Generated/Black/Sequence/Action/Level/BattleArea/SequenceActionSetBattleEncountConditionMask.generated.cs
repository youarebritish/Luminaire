using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level.BattleArea
{
    public partial class SequenceActionSetBattleEncountConditionMask : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public bool conditionIncreaseMask_;
		public bool conditionDecreaseMask_;
		public bool conditionMaxMask_;
		public bool conditionOffMask_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetBattleEncountConditionMask();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.BattleArea.SequenceActionSetBattleEncountConditionMask", 0, Black.Sequence.Action.Level.BattleArea.SequenceActionSetBattleEncountConditionMask.ObjectType, null, properties, 0, 376);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.BattleArea.SequenceActionSetBattleEncountConditionMask", base.GetFieldProperties(), 1432106954, -1606002562);
            return fieldProperties;
        }

		
    }
}