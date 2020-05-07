using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level
{
    public partial class SequenceActionSetBattleAreaOnOff : Black.Sequence.Action.Level.SequenceActionSetBattleAreaBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public int prefixType_;
		public uint teritoryFixId_;
		public uint seedPointFixid_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin isEnableInputPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin battleAreaEntityListInputPin_;
		public bool isBattleAreaActorKill_;
		public string package_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetBattleAreaOnOff();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.SequenceActionSetBattleAreaOnOff", 0, Black.Sequence.Action.Level.SequenceActionSetBattleAreaOnOff.ObjectType, null, properties, 0, 600);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.SequenceActionSetBattleAreaOnOff", base.GetFieldProperties(), -2128541797, 1308683506);
            
			
			
			return fieldProperties;
        }

		
    }
}