using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Variable
{
    public partial class SequenceConstRandom : SQEX.Ebony.Framework.Sequence.Variable.SequenceConstBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inMin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inMax_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outInt_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outFloat_;
		public float min_;
		public float max_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceConstRandom();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Variable.SequenceConstRandom", 0, SQEX.Ebony.Framework.Sequence.Variable.SequenceConstRandom.ObjectType, null, properties, 0, 448);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Variable.SequenceConstRandom", base.GetFieldProperties(), -1249500682, 787712409);
            return fieldProperties;
        }

		
    }
}