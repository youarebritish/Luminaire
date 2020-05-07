using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level.Mission.Titan
{
    public partial class SequenceActionSetupJumpingStrongpoint : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin spearSoldier_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin strongPoint_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetupJumpingStrongpoint();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.Mission.Titan.SequenceActionSetupJumpingStrongpoint", 0, Black.Sequence.Action.Level.Mission.Titan.SequenceActionSetupJumpingStrongpoint.ObjectType, null, properties, 0, 544);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.Mission.Titan.SequenceActionSetupJumpingStrongpoint", base.GetFieldProperties(), 850208677, 2089034784);
            return fieldProperties;
        }

		
    }
}