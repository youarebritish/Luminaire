using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Luminous.Physics.RigidDynamics
{
    public partial class RigidBody : SQEX.Luminous.Core.Object.Object
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new RigidBody();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Luminous.Physics.RigidDynamics.RigidBody", 0, SQEX.Luminous.Physics.RigidDynamics.RigidBody.ObjectType, null, properties, 0, 512);
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

            fieldProperties = new PropertyContainer("SQEX.Luminous.Physics.RigidDynamics.RigidBody", base.GetFieldProperties(), -1044887331, -1732245857);
            return fieldProperties;
        }

		
    }
}