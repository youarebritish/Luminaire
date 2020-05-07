using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Luminous.Core.Object
{
    public partial class Object : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new Object();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Luminous.Core.Object.Object", 0, SQEX.Luminous.Core.Object.Object.ObjectType, null, properties, 1, 16);
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

            fieldProperties = new PropertyContainer("SQEX.Luminous.Core.Object.Object", base.GetFieldProperties(), 254102316, 1792615884);
            return fieldProperties;
        }

		
    }
}