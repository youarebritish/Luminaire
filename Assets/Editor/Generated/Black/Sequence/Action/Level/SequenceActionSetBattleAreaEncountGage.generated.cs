using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level
{
    public partial class SequenceActionSetBattleAreaEncountGage : Black.Sequence.Action.Level.SequenceActionSetBattleAreaBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin battleAreaPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public float encountGage_;
		public float second_;
		public bool resultReset_;
		public bool conditionChange_;
		public uint conditionIncreaseFixid_;
		public uint conditionDecreaseFixid_;
		public uint conditionMaxFixid_;
		public uint conditionOffFixid_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetBattleAreaEncountGage();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.SequenceActionSetBattleAreaEncountGage", 0, Black.Sequence.Action.Level.SequenceActionSetBattleAreaEncountGage.ObjectType, null, properties, 0, 488);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.SequenceActionSetBattleAreaEncountGage", base.GetFieldProperties(), 1592732593, -130319030);
            return fieldProperties;
        }

		
    }
}