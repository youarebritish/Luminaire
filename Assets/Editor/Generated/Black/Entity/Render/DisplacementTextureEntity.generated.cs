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
            
			
			
			fieldProperties.AddProperty(new Property("enabled_", 1722022099, "bool", 64, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("texturePath0_", 2322976482, "SQEX.Ebony.Base.String", 72, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("texturePath1_", 3396493835, "SQEX.Ebony.Base.String", 88, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("texturePath2_", 3396346740, "SQEX.Ebony.Base.String", 104, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("texturePath3_", 2322432029, "SQEX.Ebony.Base.String", 120, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("texturePath4_", 2323564862, "SQEX.Ebony.Base.String", 136, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("footCheckHeight_", 1183360545, "float", 152, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("displacementScaleFoot_", 1452297765, "float", 156, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("displacementScaleFootUp_", 266774926, "float", 160, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("displacementRandRangeFoot_", 2281055039, "float", 164, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("sizeFoot_", 3432500557, "float", 168, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("displacementScaleBody_", 1284865181, "float", 172, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("displacementScaleBodyUp_", 4252134022, "float", 176, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("sizeBody_", 1270916101, "float", 180, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("displacementScaleSnowmobile_", 4049605826, "float", 184, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("displacementScaleSnowmobileUp_", 3764470185, "float", 188, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("sizeSnowmobileX_", 256344092, "float", 192, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("sizeSnowmobileZ_", 3477837962, "float", 196, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("displacementMaxStrech_", 2825369854, "float", 200, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("displacementStrechBySpeed_", 3756918542, "float", 204, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("displacementStrechMinSpeed_", 1935083449, "float", 208, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("displacementScaleHand_", 1072582046, "float", 212, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("displacementScaleHandUp_", 3257811773, "float", 216, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("displacementRandRangeHand_", 732227680, "float", 220, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("sizeHand_", 3927608166, "float", 224, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("displacementScaleKnee_", 1391845748, "float", 228, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("displacementScaleKneeUp_", 165650827, "float", 232, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("displacementRandRangeKnee_", 401309538, "float", 236, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("sizeKnee_", 2238861788, "float", 240, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("sizeGrid_", 1976403753, "float", 244, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("lengthGridFade_", 2628805096, "float", 248, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}