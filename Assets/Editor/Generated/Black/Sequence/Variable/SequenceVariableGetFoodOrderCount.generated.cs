using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Variable
{
    public partial class SequenceVariableGetFoodOrderCount : SQEX.Ebony.Framework.Sequence.SequenceVariable
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin foodIdPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin orderCountPin_;
		public uint foodId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceVariableGetFoodOrderCount();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Variable.SequenceVariableGetFoodOrderCount", 0, Black.Sequence.Variable.SequenceVariableGetFoodOrderCount.ObjectType, null, properties, 0, 272);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Variable.SequenceVariableGetFoodOrderCount", base.GetFieldProperties(), -1737777806, -1075418708);
            return fieldProperties;
        }

		
    }
}