using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Node
{
    public partial class PackageLoadAreaSimpleEntity : Black.Entity.Node.PackageLoadEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool triggerEnable_;
		public float triggerRadius_;
		public float triggerHeight_;
		public float triggerWidth_;
		public float triggerDepth_;
		public UnityEngine.Vector4 triggerOffset_;
		public string lodLowPackageName_;
		public bool isLowPackageLoad_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new PackageLoadAreaSimpleEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Node.PackageLoadAreaSimpleEntity", 0, Black.Entity.Node.PackageLoadAreaSimpleEntity.ObjectType, null, properties, 0, 544);
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

            fieldProperties = new PropertyContainer("Black.Entity.Node.PackageLoadAreaSimpleEntity", base.GetFieldProperties(), 540167991, 774288417);
            
			fieldProperties.AddProperty(new Property("triggerEnable_", 1412487753, "bool", 472, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("triggerRadius_", 1726467370, "float", 476, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("triggerHeight_", 3110277449, "float", 480, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("triggerWidth_", 2849620798, "float", 484, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("triggerDepth_", 123604937, "float", 488, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("triggerOffset_", 315293853, "Luminous.Math.VectorA", 496, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("lodLowPackageName_", 3550387762, "Ebony.Base.String", 512, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("isLowPackageLoad_", 2013131144, "bool", 528, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}