using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.Levia
{
    public partial class AIGraphInvokeCordAnimationEnable : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool enable_;
		public float blendTime_;
		public bool isAnimationBlend_;
		public bool isAngularDampingBlend_;
		public bool isBoneGather_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeCordAnimationEnable();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Levia.AIGraphInvokeCordAnimationEnable", 0, Black.AIGraph.Extend.Invoke.Levia.AIGraphInvokeCordAnimationEnable.ObjectType, null, properties, 0, 40);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Levia.AIGraphInvokeCordAnimationEnable", base.GetFieldProperties(), 424330485, 227371910);
            return fieldProperties;
        }

		
    }
}