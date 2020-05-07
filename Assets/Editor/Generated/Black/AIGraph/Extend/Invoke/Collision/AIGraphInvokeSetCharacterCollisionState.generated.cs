using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.Collision
{
    public partial class AIGraphInvokeSetCharacterCollisionState : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool bEnable;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeSetCharacterCollisionState();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Collision.AIGraphInvokeSetCharacterCollisionState", 0, Black.AIGraph.Extend.Invoke.Collision.AIGraphInvokeSetCharacterCollisionState.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Collision.AIGraphInvokeSetCharacterCollisionState", base.GetFieldProperties(), 143883257, -150318068);
            return fieldProperties;
        }

		
    }
}