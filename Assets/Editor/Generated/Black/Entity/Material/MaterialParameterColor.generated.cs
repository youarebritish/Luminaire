using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Material
{
    public partial class MaterialParameterColor : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string materialName_;
		public string name_;
		public UnityEngine.Color color_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new MaterialParameterColor();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Material.MaterialParameterColor", 0, Black.Entity.Material.MaterialParameterColor.ObjectType, null, properties, 0, 64);
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

            fieldProperties = new PropertyContainer("Black.Entity.Material.MaterialParameterColor", base.GetFieldProperties(), 876329529, -1699221965);
            return fieldProperties;
        }

		
    }
}