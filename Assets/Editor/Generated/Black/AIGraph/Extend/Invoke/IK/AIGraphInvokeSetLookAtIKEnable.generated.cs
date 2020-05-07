using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.IK
{
    public partial class AIGraphInvokeSetLookAtIKEnable : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int lookAtSlot_;
		public bool enable_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeSetLookAtIKEnable();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.IK.AIGraphInvokeSetLookAtIKEnable", 0, Black.AIGraph.Extend.Invoke.IK.AIGraphInvokeSetLookAtIKEnable.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.IK.AIGraphInvokeSetLookAtIKEnable", base.GetFieldProperties(), -1643500849, -1366575335);
            
			
			
			fieldProperties.AddProperty(new Property("lookAtSlot_", 3068853696, "Black.Actor.Component.IK.LOOKAT_SLOT", 24, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("enable_", 3925052483, "bool", 28, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}