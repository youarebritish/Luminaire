using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.Animation
{
    public partial class AIGraphInvokeActivateFootIK : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool enabled_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeActivateFootIK();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Animation.AIGraphInvokeActivateFootIK", 0, Black.AIGraph.Extend.Invoke.Animation.AIGraphInvokeActivateFootIK.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Animation.AIGraphInvokeActivateFootIK", base.GetFieldProperties(), 1102726995, 1953906574);
            
			
			
			fieldProperties.AddProperty(new Property("enabled_", 1722022099, "bool", 24, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}