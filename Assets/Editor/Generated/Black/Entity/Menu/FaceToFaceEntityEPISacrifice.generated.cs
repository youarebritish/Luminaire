using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Menu
{
    public partial class FaceToFaceEntityEPISacrifice : Black.Entity.Menu.FaceToFaceEntityEPI
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new FaceToFaceEntityEPISacrifice();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Menu.FaceToFaceEntityEPISacrifice", 0, Black.Entity.Menu.FaceToFaceEntityEPISacrifice.ObjectType, null, properties, 0, 816);
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

            fieldProperties = new PropertyContainer("Black.Entity.Menu.FaceToFaceEntityEPISacrifice", base.GetFieldProperties(), 2120095085, 1586431950);
            return fieldProperties;
        }

		
    }
}