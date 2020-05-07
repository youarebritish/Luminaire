using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level
{
    public partial class SequenceActionSetBattleAreaCondition : Black.Sequence.Action.Level.SequenceActionSetBattleAreaBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin battleAreaPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin valueBattleAreaConditionFixid_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin valueBattleAreaFixid_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin isChanged_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin isFailed_;
		public int prefixType_;
		public uint battleTeritoryFixid_;
		public uint battleTeritoryFixid_sub_;
		public uint battleAreaConditionFixid_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetBattleAreaCondition();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.SequenceActionSetBattleAreaCondition", 0, Black.Sequence.Action.Level.SequenceActionSetBattleAreaCondition.ObjectType, null, properties, 0, 856);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.SequenceActionSetBattleAreaCondition", base.GetFieldProperties(), -467376209, -1087188832);
            
			
			
			return fieldProperties;
        }

		
    }
}