using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level
{
    public partial class SequenceActionSetDinerPlaceGroupInformation : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin iconConditionPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin objectConditionPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin mapIconGroupIdPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetDinerPlaceGroupInformation();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.SequenceActionSetDinerPlaceGroupInformation", 0, Black.Sequence.Action.Level.SequenceActionSetDinerPlaceGroupInformation.ObjectType, null, properties, 0, 632);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.SequenceActionSetDinerPlaceGroupInformation", base.GetFieldProperties(), -2105050042, -67191618);
            return fieldProperties;
        }

		
    }
}