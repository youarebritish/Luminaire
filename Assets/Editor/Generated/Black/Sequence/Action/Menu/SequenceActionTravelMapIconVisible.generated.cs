using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Menu
{
    public partial class SequenceActionTravelMapIconVisible : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin show_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin hide_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin focus_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin unfocus_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin indexInput_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTravelMapIconVisible();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Menu.SequenceActionTravelMapIconVisible", 0, Black.Sequence.Action.Menu.SequenceActionTravelMapIconVisible.ObjectType, null, properties, 0, 744);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Menu.SequenceActionTravelMapIconVisible", base.GetFieldProperties(), 1627114812, -382752609);
            return fieldProperties;
        }

		
    }
}