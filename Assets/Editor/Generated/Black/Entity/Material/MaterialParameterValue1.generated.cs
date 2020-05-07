using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Material
{
    public partial class MaterialParameterValue1 : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string materialName_;
		public string name_;
		public float Value1_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new MaterialParameterValue1();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Material.MaterialParameterValue1", 0, Black.Entity.Material.MaterialParameterValue1.ObjectType, null, properties, 0, 48);
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

            fieldProperties = new PropertyContainer("Black.Entity.Material.MaterialParameterValue1", base.GetFieldProperties(), 960157963, 2066404231);
            return fieldProperties;
        }

		
    }
}