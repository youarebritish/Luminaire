using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Variable
{
    public partial class SequenceConstCurveBase : SQEX.Ebony.Framework.Sequence.Variable.SequenceConstBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin timePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin isEndPin_;
		public float time_;
		public SQEX.Ebony.Framework.TimeControl.AnchorPointList anchorPointList_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceConstCurveBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Variable.SequenceConstCurveBase", 0, SQEX.Ebony.Framework.Sequence.Variable.SequenceConstCurveBase.ObjectType, null, properties, 0, 296);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Variable.SequenceConstCurveBase", base.GetFieldProperties(), 2132165967, -1595136248);
            return fieldProperties;
        }

		
    }
}