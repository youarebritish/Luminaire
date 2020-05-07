using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.Animation
{
    public partial class AIGraphInvokeSwitchToRagdoll : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int ragdollRange_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeSwitchToRagdoll();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Animation.AIGraphInvokeSwitchToRagdoll", 0, Black.AIGraph.Extend.Invoke.Animation.AIGraphInvokeSwitchToRagdoll.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Animation.AIGraphInvokeSwitchToRagdoll", base.GetFieldProperties(), -654877692, -235418668);
            
			
			
			return fieldProperties;
        }

		
    }
}