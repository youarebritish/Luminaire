using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Menu
{
    public partial class SequenceActionReqItemInfoMenu : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin msgIdPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public uint msgId_;
		public float displayTime_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionReqItemInfoMenu();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Menu.SequenceActionReqItemInfoMenu", 0, Black.Sequence.Action.Menu.SequenceActionReqItemInfoMenu.ObjectType, null, properties, 0, 464);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Menu.SequenceActionReqItemInfoMenu", base.GetFieldProperties(), -984647832, -2030652532);
            return fieldProperties;
        }

		
    }
}