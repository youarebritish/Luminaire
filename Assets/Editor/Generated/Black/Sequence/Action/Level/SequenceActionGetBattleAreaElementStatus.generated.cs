using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level
{
    public partial class SequenceActionGetBattleAreaElementStatus : Black.Sequence.Action.Level.SequenceActionSetBattleAreaBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stop_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin battleAreaPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin none_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin change_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin fire_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin fira_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin firaga_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin blizzard_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin blizzara_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin blizzaga_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin thunder_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin thundara_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin thundaga_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin fireDown_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin firaDown_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin firagaDown_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin blizzardDown_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin blizzaraDown_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin blizzagaDown_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin thunderDown_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin thundaraDown_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin thundagaDown_;
		public bool updateStatusFlag_;
		public bool changeActivate_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionGetBattleAreaElementStatus();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.SequenceActionGetBattleAreaElementStatus", 0, Black.Sequence.Action.Level.SequenceActionGetBattleAreaElementStatus.ObjectType, null, properties, 0, 2536);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.SequenceActionGetBattleAreaElementStatus", base.GetFieldProperties(), 730524110, 1980199585);
            
			
			
			return fieldProperties;
        }

		
    }
}