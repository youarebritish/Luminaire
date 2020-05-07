using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor.Component.Props.ComponentData
{
    public partial class TurretMaterialParamArrayItem : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string MaterialName;
		public string ParamName;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new TurretMaterialParamArrayItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.Component.Props.ComponentData.TurretMaterialParamArrayItem", 0, Black.Actor.Component.Props.ComponentData.TurretMaterialParamArrayItem.ObjectType, null, properties, 0, 40);
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

            fieldProperties = new PropertyContainer("Black.Actor.Component.Props.ComponentData.TurretMaterialParamArrayItem", base.GetFieldProperties(), 1709214244, -1022045204);
            return fieldProperties;
        }

		
    }
}