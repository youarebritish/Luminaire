using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Node
{
    public partial class BattleAreaEntity : Black.Entity.Node.PointNodeEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool isEnable_;
		public uint teritoryFixId_;
		public uint seedPointFixid_;
		public int areaType_;
		public int groupNo_;
		public uint battleAreaConditionFixId_;
		public bool isAutoMakeBattleTeritory_;
		public int triggerType_;
		public int seedCollisionType_;
		public UnityEngine.Vector4 scaling_;
		public float radius_;
		public UnityEngine.Color color_;
		public float summonSuccessRate_;
		public int summonIfritLot_;
		public int summonIfritDirection_;
		public int summonSivaLot_;
		public int summonSivaDirection_;
		public int summonRamuhLot_;
		public int summonRamuhDirection_;
		public int summonTitanLot_;
		public int summonTitanDirection_;
		public int summonLeviathanLot_;
		public int summonLeviathanDirection_;
		public int summonBahamutLot_;
		public int summonBahamutDirection_;
		public int elementFirePower_;
		public int elementIcePower_;
		public int elementThunderPower_;
		public int elementEarthPower_;
		public int elementWaterPower_;
		public int elementLightPower_;
		public int elementDarkPower_;
		public bool isAreaInfoRelease_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BattleAreaEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Node.BattleAreaEntity", 0, Black.Entity.Node.BattleAreaEntity.ObjectType, null, properties, 0, 512);
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

            fieldProperties = new PropertyContainer("Black.Entity.Node.BattleAreaEntity", base.GetFieldProperties(), -1056227527, -31039531);
            return fieldProperties;
        }

		
    }
}