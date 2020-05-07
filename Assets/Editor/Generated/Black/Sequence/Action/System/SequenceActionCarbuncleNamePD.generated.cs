using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.System
{
    public partial class SequenceActionCarbuncleNamePD : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inputNamePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outputNamePin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionCarbuncleNamePD();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.System.SequenceActionCarbuncleNamePD", 0, Black.Sequence.Action.System.SequenceActionCarbuncleNamePD.ObjectType, null, properties, 0, 544);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.System.SequenceActionCarbuncleNamePD", base.GetFieldProperties(), -749614301, 261704999);
            return fieldProperties;
        }

		
    }
}