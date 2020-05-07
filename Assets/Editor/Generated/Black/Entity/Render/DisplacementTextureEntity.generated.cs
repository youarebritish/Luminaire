using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Render
{
    public partial class DisplacementTextureEntity : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool enabled_;
		public string texturePath0_;
		public string texturePath1_;
		public string texturePath2_;
		public string texturePath3_;
		public string texturePath4_;
		public float footCheckHeight_;
		public float displacementScaleFoot_;
		public float displacementScaleFootUp_;
		public float displacementRandRangeFoot_;
		public float sizeFoot_;
		public float displacementScaleBody_;
		public float displacementScaleBodyUp_;
		public float sizeBody_;
		public float displacementScaleSnowmobile_;
		public float displacementScaleSnowmobileUp_;
		public float sizeSnowmobileX_;
		public float sizeSnowmobileZ_;
		public float displacementMaxStrech_;
		public float displacementStrechBySpeed_;
		public float displacementStrechMinSpeed_;
		public float displacementScaleHand_;
		public float displacementScaleHandUp_;
		public float displacementRandRangeHand_;
		public float sizeHand_;
		public float displacementScaleKnee_;
		public float displacementScaleKneeUp_;
		public float displacementRandRangeKnee_;
		public float sizeKnee_;
		public float sizeGrid_;
		public float lengthGridFade_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new DisplacementTextureEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Render.DisplacementTextureEntity", 0, Black.Entity.Render.DisplacementTextureEntity.ObjectType, null, properties, 0, 304);
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

            fieldProperties = new PropertyContainer("Black.Entity.Render.DisplacementTextureEntity", base.GetFieldProperties(), -1673306602, 1966880369);
            
			
			
			return fieldProperties;
        }

		
    }
}