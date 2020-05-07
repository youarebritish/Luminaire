using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.System
{
    public partial class SequenceActionGetKeyboardIconLabel : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin upLabel_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin downLabel_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin rightLabel_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin leftLabel_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionGetKeyboardIconLabel();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.System.SequenceActionGetKeyboardIconLabel", 0, Black.Sequence.Action.System.SequenceActionGetKeyboardIconLabel.ObjectType, null, properties, 0, 528);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.System.SequenceActionGetKeyboardIconLabel", base.GetFieldProperties(), 411515614, -1529870628);
            return fieldProperties;
        }

		
    }
}