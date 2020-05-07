using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level
{
    public partial class SequenceActionChangeBattleAreaElement : Black.Sequence.Action.Level.SequenceActionSetBattleAreaBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin ElementInPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin battleAreaPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public int element_;
		public int elementValue_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionChangeBattleAreaElement();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.SequenceActionChangeBattleAreaElement", 0, Black.Sequence.Action.Level.SequenceActionChangeBattleAreaElement.ObjectType, null, properties, 0, 568);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.SequenceActionChangeBattleAreaElement", base.GetFieldProperties(), -808606523, -2087818737);
            return fieldProperties;
        }

		
    }
}