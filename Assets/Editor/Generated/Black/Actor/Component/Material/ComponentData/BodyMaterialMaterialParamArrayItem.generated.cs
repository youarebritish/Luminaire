using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor.Component.Material.ComponentData
{
    public partial class BodyMaterialMaterialParamArrayItem : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string MaterialName;
		public string ParamName;
		public float MinValue;
		public float MaxValue;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BodyMaterialMaterialParamArrayItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.Component.Material.ComponentData.BodyMaterialMaterialParamArrayItem", 0, Black.Actor.Component.Material.ComponentData.BodyMaterialMaterialParamArrayItem.ObjectType, null, properties, 0, 48);
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

            fieldProperties = new PropertyContainer("Black.Actor.Component.Material.ComponentData.BodyMaterialMaterialParamArrayItem", base.GetFieldProperties(), 367803582, -85005402);
            return fieldProperties;
        }

		
    }
}