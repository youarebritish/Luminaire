using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AI.StrongPoint
{
    public partial class StrongPointMission : Black.AI.StrongPoint.StrongPoint
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new StrongPointMission();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AI.StrongPoint.StrongPointMission", 0, Black.AI.StrongPoint.StrongPointMission.ObjectType, null, properties, 0, 1328);
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

            fieldProperties = new PropertyContainer("Black.AI.StrongPoint.StrongPointMission", base.GetFieldProperties(), -918835579, -1349227251);
            
			
			
			return fieldProperties;
        }

		
    }
}