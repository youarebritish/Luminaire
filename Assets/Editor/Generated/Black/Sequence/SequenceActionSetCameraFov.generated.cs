using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence
{
    public partial class SequenceActionSetCameraFov : Black.Sequence.Action.Camera.SequenceActionOverrideCameraFov
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int isOverrideFOVMode_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetCameraFov();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.SequenceActionSetCameraFov", 0, Black.Sequence.SequenceActionSetCameraFov.ObjectType, null, properties, 0, 920);
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

            fieldProperties = new PropertyContainer("Black.Sequence.SequenceActionSetCameraFov", base.GetFieldProperties(), -1076849471, -1707395436);
            return fieldProperties;
        }

		
    }
}