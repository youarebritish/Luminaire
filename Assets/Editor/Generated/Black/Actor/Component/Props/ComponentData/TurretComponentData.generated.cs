using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor.Component.Props.ComponentData
{
    public partial class TurretComponentData : Black.Actor.Component.ActorComponentData
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint pitchBaseJoint_;
		public float turnLimitHorizonal_;
		public float turnLimitVerticalUpper_;
		public float turnLimitVerticalLower_;
		public float turnSpeedVertical_;
		public float turnSpeedHorizontal_;
		public float heatingSpeed_;
		public float coolingSpeed_;
		public float overheatTime_;
		public float recoverTime_;
		public uint overheatVfx_;
		public IList<SQEX.Ebony.Framework.Utility.FixidArrayItem> playerAttackParamIDList;
		public IList<SQEX.Ebony.Framework.Utility.FixidArrayItem> enemyAttackParamIDList;
		public uint shotMessageId_;
		public uint shotEndMessageId_;
		public IList<Black.Actor.Component.Props.ComponentData.TurretMaterialParamArrayItem> materialParams_;
		public uint cameraBaseJoint_;
		public bool isCameraYawByJoint_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new TurretComponentData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.Component.Props.ComponentData.TurretComponentData", 0, Black.Actor.Component.Props.ComponentData.TurretComponentData.ObjectType, null, properties, 0, 176);
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

            fieldProperties = new PropertyContainer("Black.Actor.Component.Props.ComponentData.TurretComponentData", base.GetFieldProperties(), 1051950933, -227847231);
            
			
			
			return fieldProperties;
        }

		
    }
}