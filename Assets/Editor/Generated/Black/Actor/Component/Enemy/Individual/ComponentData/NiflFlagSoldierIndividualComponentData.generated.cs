using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor.Component.Enemy.Individual.ComponentData
{
    public partial class NiflFlagSoldierIndividualComponentData : Black.Actor.Component.Enemy.Individual.ComponentData.EnemyIndividualComponentDataBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float needTimeForCalling_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new NiflFlagSoldierIndividualComponentData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.Component.Enemy.Individual.ComponentData.NiflFlagSoldierIndividualComponentData", 0, Black.Actor.Component.Enemy.Individual.ComponentData.NiflFlagSoldierIndividualComponentData.ObjectType, null, properties, 0, 72);
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

            fieldProperties = new PropertyContainer("Black.Actor.Component.Enemy.Individual.ComponentData.NiflFlagSoldierIndividualComponentData", base.GetFieldProperties(), -546557796, 162449678);
            
			fieldProperties.AddProperty(new Property("needTimeForCalling_", 627547566, "float", 64, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}