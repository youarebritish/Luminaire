using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event.Menu
{
    public partial class SequenceEventInteractionSubCursorChanged : Black.Sequence.Event.Menu.SequenceEventUiBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin targetActorListPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventInteractionSubCursorChanged();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.Menu.SequenceEventInteractionSubCursorChanged", 0, Black.Sequence.Event.Menu.SequenceEventInteractionSubCursorChanged.ObjectType, null, properties, 0, 432);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.Menu.SequenceEventInteractionSubCursorChanged", base.GetFieldProperties(), -1096626814, 243020945);
            return fieldProperties;
        }

		
    }
}