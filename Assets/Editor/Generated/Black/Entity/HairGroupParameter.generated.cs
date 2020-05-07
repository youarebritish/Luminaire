using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity
{
    public partial class HairGroupParameter : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string groupName1_;
		public string groupName2_;
		public string groupName3_;
		public string groupName4_;
		public UnityEngine.Vector4 width_;
		public UnityEngine.Vector4 shadowWidth_;
		public UnityEngine.Vector4 thinTipOffset_;
		public UnityEngine.Vector4 strandMultiplier_;
		public UnityEngine.Vector4 multiplicationRootOffset_;
		public UnityEngine.Vector4 multiplicationMiddleOffset_;
		public UnityEngine.Vector4 multiplicationTipOffset_;
		public UnityEngine.Vector4 vertsPerSegment_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new HairGroupParameter();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.HairGroupParameter", 0, Black.Entity.HairGroupParameter.ObjectType, null, properties, 0, 208);
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

            fieldProperties = new PropertyContainer("Black.Entity.HairGroupParameter", base.GetFieldProperties(), 766625306, -2137803352);
            
			
			
			fieldProperties.AddProperty(new Property("groupName1_", 459041159, "Ebony.Base.String", 8, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("groupName2_", 3680093744, "Ebony.Base.String", 24, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("groupName3_", 458746969, "Ebony.Base.String", 40, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("groupName4_", 458599874, "Ebony.Base.String", 56, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("width_", 2754776768, "Luminous.Math.VectorA", 80, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("shadowWidth_", 529276380, "Luminous.Math.VectorA", 96, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("thinTipOffset_", 2870584157, "Luminous.Math.VectorA", 112, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("strandMultiplier_", 4188322031, "Luminous.Math.VectorA", 128, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("multiplicationRootOffset_", 3631532657, "Luminous.Math.VectorA", 144, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("multiplicationMiddleOffset_", 2962896850, "Luminous.Math.VectorA", 160, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("multiplicationTipOffset_", 4032638440, "Luminous.Math.VectorA", 176, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("vertsPerSegment_", 2912702820, "Luminous.Math.VectorA", 192, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}