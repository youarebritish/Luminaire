using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor.Component.PadControl
{
    public partial class IActorPadControl
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new IActorPadControl();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.Component.PadControl.IActorPadControl", 0, Black.Actor.Component.PadControl.IActorPadControl.ObjectType, null, properties, 32, 16);
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

            fieldProperties = new PropertyContainer("Black.Actor.Component.PadControl.IActorPadControl", null, 111289812, 1382251678);
            return fieldProperties;
        }

		
    }
}