using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Debug
{
    public partial class SequenceActionDebugCommandMenuVehicle : Black.Sequence.Action.Debug.SequenceActionDebugCommandMenuBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionDebugCommandMenuVehicle();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Debug.SequenceActionDebugCommandMenuVehicle", 0, Black.Sequence.Action.Debug.SequenceActionDebugCommandMenuVehicle.ObjectType, null, properties, 0, 712);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Debug.SequenceActionDebugCommandMenuVehicle", base.GetFieldProperties(), -538077973, 38525952);
            return fieldProperties;
        }

		
    }
}