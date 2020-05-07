using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Variable
{
    public partial class SequenceConstantGraphicsConfig : SQEX.Ebony.Framework.Sequence.SequenceVariable
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin NVVXAO_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin NVShadowLib_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin NVHairworks_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin NVFlow_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin NVTurf_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceConstantGraphicsConfig();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Variable.SequenceConstantGraphicsConfig", 0, Black.Sequence.Variable.SequenceConstantGraphicsConfig.ObjectType, null, properties, 0, 528);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Variable.SequenceConstantGraphicsConfig", base.GetFieldProperties(), -1886865888, -2106962103);
            
			
			
			return fieldProperties;
        }

		
    }
}