using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.Camera
{
    public partial class AIGraphInvokeCallCameraSequence : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint functionId_;
		public bool isStart_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeCallCameraSequence();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Camera.AIGraphInvokeCallCameraSequence", 0, Black.AIGraph.Extend.Invoke.Camera.AIGraphInvokeCallCameraSequence.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Camera.AIGraphInvokeCallCameraSequence", base.GetFieldProperties(), -1915245376, 507434564);
            return fieldProperties;
        }

		
    }
}