using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke
{
    public partial class AIGraphInvokeSetAnimationBlackboard_Int : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint paramType_;
		public int paramValue_;
		public bool isRandom_;
		public int minRandomValue_;
		public int maxRandomValue_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeSetAnimationBlackboard_Int();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.AIGraphInvokeSetAnimationBlackboard_Int", 0, Black.AIGraph.Extend.Invoke.AIGraphInvokeSetAnimationBlackboard_Int.ObjectType, null, properties, 0, 48);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.AIGraphInvokeSetAnimationBlackboard_Int", base.GetFieldProperties(), 2133410845, -1149200383);
            
			
			
			return fieldProperties;
        }

		
    }
}