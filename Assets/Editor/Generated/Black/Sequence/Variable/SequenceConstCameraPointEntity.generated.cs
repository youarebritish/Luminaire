using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Variable
{
    public partial class SequenceConstCameraPointEntity : Black.Sequence.Variable.SequenceConstPointEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin cameraDistanceVarOutPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceConstCameraPointEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Variable.SequenceConstCameraPointEntity", 0, Black.Sequence.Variable.SequenceConstCameraPointEntity.ObjectType, null, properties, 0, 280);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Variable.SequenceConstCameraPointEntity", base.GetFieldProperties(), 1683907167, 1823157702);
            return fieldProperties;
        }

		
    }
}