using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.IK
{
    public partial class AIGraphInvokeSetAimAtIKEnable : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int aimAtSlot_;
		public bool enable_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeSetAimAtIKEnable();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.IK.AIGraphInvokeSetAimAtIKEnable", 0, Black.AIGraph.Extend.Invoke.IK.AIGraphInvokeSetAimAtIKEnable.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.IK.AIGraphInvokeSetAimAtIKEnable", base.GetFieldProperties(), -928528660, 328282509);
            return fieldProperties;
        }

		
    }
}