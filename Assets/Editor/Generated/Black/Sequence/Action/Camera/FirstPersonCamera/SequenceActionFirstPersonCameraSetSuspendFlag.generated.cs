using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Camera.FirstPersonCamera
{
    public partial class SequenceActionFirstPersonCameraSetSuspendFlag : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin suspend_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin resume_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionFirstPersonCameraSetSuspendFlag();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Camera.FirstPersonCamera.SequenceActionFirstPersonCameraSetSuspendFlag", 0, Black.Sequence.Action.Camera.FirstPersonCamera.SequenceActionFirstPersonCameraSetSuspendFlag.ObjectType, null, properties, 0, 464);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Camera.FirstPersonCamera.SequenceActionFirstPersonCameraSetSuspendFlag", base.GetFieldProperties(), 1676414094, -1593189313);
            return fieldProperties;
        }

		
    }
}