using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.Nifl.AirShip
{
    public partial class AIGraphInvokeAirShipShootAnchor : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeAirShipShootAnchor();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Nifl.AirShip.AIGraphInvokeAirShipShootAnchor", 0, Black.AIGraph.Extend.Invoke.Nifl.AirShip.AIGraphInvokeAirShipShootAnchor.ObjectType, null, properties, 0, 24);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Nifl.AirShip.AIGraphInvokeAirShipShootAnchor", base.GetFieldProperties(), 1339628195, 1833003750);
            
			
			
			
			
			return fieldProperties;
        }

		
    }
}