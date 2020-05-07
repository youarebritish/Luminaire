using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Node
{
    public partial class SpecialCameraAreaEntity : Black.Entity.Node.SpecialAreaEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint paramId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SpecialCameraAreaEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Node.SpecialCameraAreaEntity", 0, Black.Entity.Node.SpecialCameraAreaEntity.ObjectType, null, properties, 0, 480);
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

            fieldProperties = new PropertyContainer("Black.Entity.Node.SpecialCameraAreaEntity", base.GetFieldProperties(), 1178769517, 843940752);
            return fieldProperties;
        }

		
    }
}