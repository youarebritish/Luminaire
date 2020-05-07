using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke
{
    public partial class AIGraphInvokeSetAnimationBlackboard_Float : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint paramType_;
		public float paramValue_;
		public bool isRandom_;
		public float minRandomValue_;
		public float maxRandomValue_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeSetAnimationBlackboard_Float();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.AIGraphInvokeSetAnimationBlackboard_Float", 0, Black.AIGraph.Extend.Invoke.AIGraphInvokeSetAnimationBlackboard_Float.ObjectType, null, properties, 0, 48);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.AIGraphInvokeSetAnimationBlackboard_Float", base.GetFieldProperties(), 1816211909, -275033114);
            return fieldProperties;
        }

		
    }
}