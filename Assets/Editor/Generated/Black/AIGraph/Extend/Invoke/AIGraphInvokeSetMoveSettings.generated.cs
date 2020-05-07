using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke
{
    public partial class AIGraphInvokeSetMoveSettings : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool validateGear_;
		public float maxVelocity_;
		public float minVelocity_;
		public float slow_walk_;
		public float walk_;
		public float jog_;
		public float run_;
		public float dash_;
		public bool backToDefault_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeSetMoveSettings();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.AIGraphInvokeSetMoveSettings", 0, Black.AIGraph.Extend.Invoke.AIGraphInvokeSetMoveSettings.ObjectType, null, properties, 0, 64);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.AIGraphInvokeSetMoveSettings", base.GetFieldProperties(), -634439761, -448546467);
            return fieldProperties;
        }

		
    }
}