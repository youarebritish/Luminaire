using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Luminous.Physics.RigidDynamics
{
    public partial class OverlapReport
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new OverlapReport();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Luminous.Physics.RigidDynamics.OverlapReport", 0, SQEX.Luminous.Physics.RigidDynamics.OverlapReport.ObjectType, null, properties, 5, 96);
        }
		
        public  ObjectType GetObjectType()
        {
            return ObjectType;
        }

        protected  PropertyContainer GetFieldProperties()
        {
            if (fieldProperties != null)
            {
                return fieldProperties;
            }

            fieldProperties = new PropertyContainer("SQEX.Luminous.Physics.RigidDynamics.OverlapReport", null, -331564633, 922702881);
            
			
			
			
			
			return fieldProperties;
        }

		
    }
}