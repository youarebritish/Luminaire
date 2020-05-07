using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor.Component.Enemy.Individual.ComponentData
{
    public partial class NiflSoldierWireArmIndividualComponentData : Black.Actor.Component.Enemy.Individual.ComponentData.EnemyIndividualComponentDataBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int wireWeaponSlot_;
		public uint wireAttachJoint_;
		public UnityEngine.Vector4 wireAttachRotation_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new NiflSoldierWireArmIndividualComponentData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.Component.Enemy.Individual.ComponentData.NiflSoldierWireArmIndividualComponentData", 0, Black.Actor.Component.Enemy.Individual.ComponentData.NiflSoldierWireArmIndividualComponentData.ObjectType, null, properties, 0, 96);
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

            fieldProperties = new PropertyContainer("Black.Actor.Component.Enemy.Individual.ComponentData.NiflSoldierWireArmIndividualComponentData", base.GetFieldProperties(), 1123837994, -731442856);
            return fieldProperties;
        }

		
    }
}