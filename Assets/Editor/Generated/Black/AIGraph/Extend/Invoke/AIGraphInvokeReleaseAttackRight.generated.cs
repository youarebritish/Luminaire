using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke
{
    public partial class AIGraphInvokeReleaseAttackRight : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeReleaseAttackRight();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.AIGraphInvokeReleaseAttackRight", 0, Black.AIGraph.Extend.Invoke.AIGraphInvokeReleaseAttackRight.ObjectType, null, properties, 0, 24);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.AIGraphInvokeReleaseAttackRight", base.GetFieldProperties(), -1439069967, 1267621396);
            return fieldProperties;
        }

		
    }
}