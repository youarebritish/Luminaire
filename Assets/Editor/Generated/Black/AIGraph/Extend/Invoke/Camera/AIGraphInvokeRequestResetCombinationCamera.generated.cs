using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.Camera
{
    public partial class AIGraphInvokeRequestResetCombinationCamera : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeRequestResetCombinationCamera();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Camera.AIGraphInvokeRequestResetCombinationCamera", 0, Black.AIGraph.Extend.Invoke.Camera.AIGraphInvokeRequestResetCombinationCamera.ObjectType, null, properties, 0, 24);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Camera.AIGraphInvokeRequestResetCombinationCamera", base.GetFieldProperties(), 364347594, -1379749268);
            return fieldProperties;
        }

		
    }
}