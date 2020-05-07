using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Operator.Calculate
{
    public partial class SequenceOperatorCalculateMatrixTransformCoord : Black.Sequence.Operator.SequenceOperatorCalculateBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin matrixPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin offsetPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin plusSignPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin resultPin_;
		public int useMatrixType_;
		public UnityEngine.Vector4 offset_;
		public bool plusSign_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceOperatorCalculateMatrixTransformCoord();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Operator.Calculate.SequenceOperatorCalculateMatrixTransformCoord", 0, Black.Sequence.Operator.Calculate.SequenceOperatorCalculateMatrixTransformCoord.ObjectType, null, properties, 0, 528);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Operator.Calculate.SequenceOperatorCalculateMatrixTransformCoord", base.GetFieldProperties(), 2068505923, -394840808);
            
			
			
			return fieldProperties;
        }

		
    }
}