using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Variable
{
    public partial class SequenceConstVCurve : SQEX.Ebony.Framework.Sequence.Variable.SequenceConstCurveBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin valuePinZ_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin valuePinY_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin valuePinX_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin valuePinVector_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceConstVCurve();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Variable.SequenceConstVCurve", 0, SQEX.Ebony.Framework.Sequence.Variable.SequenceConstVCurve.ObjectType, null, properties, 0, 648);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Variable.SequenceConstVCurve", base.GetFieldProperties(), -815233650, -201796759);
            return fieldProperties;
        }

		
    }
}