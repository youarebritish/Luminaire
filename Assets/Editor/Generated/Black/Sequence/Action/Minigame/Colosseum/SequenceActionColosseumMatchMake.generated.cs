using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Minigame.Colosseum
{
    public partial class SequenceActionColosseumMatchMake : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin daysNumber_Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin matchMaxNumber_Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin group_odds_List_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin group_D_Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin group_C_Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin group_B_Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin group_A_Pin_;
		public int weekday_;
		public int groupMin_;
		public int groupMax_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionColosseumMatchMake();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Minigame.Colosseum.SequenceActionColosseumMatchMake", 0, Black.Sequence.Action.Minigame.Colosseum.SequenceActionColosseumMatchMake.ObjectType, null, properties, 0, 1000);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Minigame.Colosseum.SequenceActionColosseumMatchMake", base.GetFieldProperties(), 1198212875, -1576731282);
            return fieldProperties;
        }

		
    }
}