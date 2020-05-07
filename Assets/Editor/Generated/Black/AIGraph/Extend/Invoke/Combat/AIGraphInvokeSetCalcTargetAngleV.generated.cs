using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.Combat
{
    public partial class AIGraphInvokeSetCalcTargetAngleV : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool bOn;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeSetCalcTargetAngleV();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Combat.AIGraphInvokeSetCalcTargetAngleV", 0, Black.AIGraph.Extend.Invoke.Combat.AIGraphInvokeSetCalcTargetAngleV.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Combat.AIGraphInvokeSetCalcTargetAngleV", base.GetFieldProperties(), 1731535061, -1538107805);
            
			
			
			fieldProperties.AddProperty(new Property("bOn", 2065055696, "bool", 24, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}