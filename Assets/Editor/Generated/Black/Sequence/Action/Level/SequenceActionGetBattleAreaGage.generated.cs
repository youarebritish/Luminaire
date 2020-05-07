using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level
{
    public partial class SequenceActionGetBattleAreaGage : Black.Sequence.Action.Level.SequenceActionSetBattleAreaBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stop_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin gageInPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin battleAreaPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin more_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin less_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin gageOutPin_;
		public bool updateStatusFlag_;
		public bool changeActivate_;
		public float gage_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionGetBattleAreaGage();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.SequenceActionGetBattleAreaGage", 0, Black.Sequence.Action.Level.SequenceActionGetBattleAreaGage.ObjectType, null, properties, 0, 968);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.SequenceActionGetBattleAreaGage", base.GetFieldProperties(), -644932297, 586974390);
            return fieldProperties;
        }

		
    }
}