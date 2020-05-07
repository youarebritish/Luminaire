using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.Enemy
{
    public partial class AIGraphInvokeClearArrivalInfo : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeClearArrivalInfo();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Enemy.AIGraphInvokeClearArrivalInfo", 0, Black.AIGraph.Extend.Invoke.Enemy.AIGraphInvokeClearArrivalInfo.ObjectType, null, properties, 0, 24);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Enemy.AIGraphInvokeClearArrivalInfo", base.GetFieldProperties(), 1553607905, -1392523214);
            return fieldProperties;
        }

		
    }
}