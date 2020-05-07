using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.Collision
{
    public partial class AIGraphInvokeChangeProxy : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool bDynamic;
		public float fInterpolateTime;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeChangeProxy();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Collision.AIGraphInvokeChangeProxy", 0, Black.AIGraph.Extend.Invoke.Collision.AIGraphInvokeChangeProxy.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Collision.AIGraphInvokeChangeProxy", base.GetFieldProperties(), -1960289609, -1643262660);
            return fieldProperties;
        }

		
    }
}