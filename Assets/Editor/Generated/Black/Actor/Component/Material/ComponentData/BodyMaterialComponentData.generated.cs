using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor.Component.Material.ComponentData
{
    public partial class BodyMaterialComponentData : Black.Actor.Component.ActorComponentData
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int createComponentType_;
		public IList<Black.Actor.Component.Material.ComponentData.BodyMaterialMaterialParamArrayItem> materials_;
		public float dirtyPowerByMoving_;
		public float dirtyPowerByDownTrigger_;
		public float dirtyPowerDuringRain_;
		public float dirtyPowerDuringSandSmall_;
		public float dirtyPowerDuringSandBig_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BodyMaterialComponentData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.Component.Material.ComponentData.BodyMaterialComponentData", 0, Black.Actor.Component.Material.ComponentData.BodyMaterialComponentData.ObjectType, null, properties, 0, 112);
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

            fieldProperties = new PropertyContainer("Black.Actor.Component.Material.ComponentData.BodyMaterialComponentData", base.GetFieldProperties(), 354323975, 27954390);
            
			
			
			return fieldProperties;
        }

		
    }
}