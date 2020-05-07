using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.Camera
{
    public partial class AIGraphInvokeFirstPersonCameraSetSuspendFlag : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool flag_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeFirstPersonCameraSetSuspendFlag();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Camera.AIGraphInvokeFirstPersonCameraSetSuspendFlag", 0, Black.AIGraph.Extend.Invoke.Camera.AIGraphInvokeFirstPersonCameraSetSuspendFlag.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Camera.AIGraphInvokeFirstPersonCameraSetSuspendFlag", base.GetFieldProperties(), 2024554677, 743410612);
            
			
			
			fieldProperties.AddProperty(new Property("flag_", 2154253848, "bool", 24, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}