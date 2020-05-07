using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Material
{
    public partial class MaterialParameterValue4 : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string materialName_;
		public string name_;
		public UnityEngine.Vector4 Value4_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new MaterialParameterValue4();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Material.MaterialParameterValue4", 0, Black.Entity.Material.MaterialParameterValue4.ObjectType, null, properties, 0, 64);
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

            fieldProperties = new PropertyContainer("Black.Entity.Material.MaterialParameterValue4", base.GetFieldProperties(), 960157968, -1213824064);
            return fieldProperties;
        }

		
    }
}