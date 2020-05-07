using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Menu.Battle
{
    public partial class SequenceActionGetCommandTargetList : Black.Sequence.Action.Menu.Battle.SequenceActionCombatCommandAccessBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin abilityId_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin self_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin commandTargetListPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionGetCommandTargetList();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Menu.Battle.SequenceActionGetCommandTargetList", 0, Black.Sequence.Action.Menu.Battle.SequenceActionGetCommandTargetList.ObjectType, null, properties, 0, 680);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Menu.Battle.SequenceActionGetCommandTargetList", base.GetFieldProperties(), -722655315, -1790686915);
            return fieldProperties;
        }

		
    }
}