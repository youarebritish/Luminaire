using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Node
{
    public partial class PointNodeEntity : Black.Entity.Node.PointNodeEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool scriptVisible_;
		public int pointType_;
		public uint paramId_;
		public uint interactionParamId_;
		public uint interactionItemId_;
		public int positionAttribute_;
		public int warpAutoTurnMode_;
		public int warpPostCameraMode_;
		public int warpPostCameraBlendMode_;
		public float warpPostCameraBlendTime_;
		public float warpPostCameraBlendSpeed_;
		public uint warpGroupId_;
		public float magicThunderDamageRangeRadius_;
		public float wallCoverRangeRadius_;
		public int wallCoverDirection_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new PointNodeEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Node.PointNodeEntity", 0, Black.Entity.Node.PointNodeEntity.ObjectType, null, properties, 0, 368);
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

            fieldProperties = new PropertyContainer("Black.Entity.Node.PointNodeEntity", base.GetFieldProperties(), 996580910, -808608432);
            
			
			
			return fieldProperties;
        }

		
    }
}