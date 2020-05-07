using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AI.NihilSystem.MilitaryFacility.Node
{
    public partial class ActorMilitaryFacility : Black.Actor.Node.ActorNodePoint
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ActorMilitaryFacility();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AI.NihilSystem.MilitaryFacility.Node.ActorMilitaryFacility", 0, Black.AI.NihilSystem.MilitaryFacility.Node.ActorMilitaryFacility.ObjectType, null, properties, 0, 928);
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

            fieldProperties = new PropertyContainer("Black.AI.NihilSystem.MilitaryFacility.Node.ActorMilitaryFacility", base.GetFieldProperties(), 2095195517, 1814525174);
            
			
			
			return fieldProperties;
        }

		
    }
}