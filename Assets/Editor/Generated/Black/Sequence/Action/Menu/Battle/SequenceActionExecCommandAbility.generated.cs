using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Menu.Battle
{
    public partial class SequenceActionExecCommandAbility : Black.Sequence.Action.Menu.Battle.SequenceActionCombatCommandAccessBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin abilityId_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin self_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin target_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionExecCommandAbility();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Menu.Battle.SequenceActionExecCommandAbility", 0, Black.Sequence.Action.Menu.Battle.SequenceActionExecCommandAbility.ObjectType, null, properties, 0, 632);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Menu.Battle.SequenceActionExecCommandAbility", base.GetFieldProperties(), 201044553, -310707759);
            return fieldProperties;
        }

		
    }
}