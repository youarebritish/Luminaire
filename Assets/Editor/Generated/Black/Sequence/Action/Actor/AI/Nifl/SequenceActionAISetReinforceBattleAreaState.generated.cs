using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.AI.Nifl
{
    public partial class SequenceActionAISetReinforceBattleAreaState : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin addTrigger_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin removeTrigger_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin aircraft_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin battleArea_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin territoryArea_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAISetReinforceBattleAreaState();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.AI.Nifl.SequenceActionAISetReinforceBattleAreaState", 0, Black.Sequence.Action.Actor.AI.Nifl.SequenceActionAISetReinforceBattleAreaState.ObjectType, null, properties, 0, 760);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.AI.Nifl.SequenceActionAISetReinforceBattleAreaState", base.GetFieldProperties(), -2052834354, 1223502463);
            return fieldProperties;
        }

		
    }
}