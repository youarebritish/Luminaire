//----------------------
// <auto-generated>
// This file was automatically generated. Any changes to it will be lost if and when the file is regenerated.
// </auto-generated>
//----------------------
#pragma warning disable

using System;
using SQEX.Luminous.Core.Object;
using System.Collections.Generic;
using CodeDom = System.CodeDom;

namespace Black.System.TimeLine.TrackItem.Camera.Struct
{
    [Serializable, CodeDom.Compiler.GeneratedCode("Luminaire", "0.1")]
    public partial class InGameCameraSeamlessClone : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int backToSeamlessCloneReleasePreset_;
		public int backToNormalCoordInterpType_;
		public float backToNormalInterpTime_;
		public float backToNormalCameraTime1_;
		public float backToNormalCameraTime2_;
		public float backToNormalCameraAccel_;
		public int backToNormalInterpBlendMode_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameCameraSeamlessClone();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraSeamlessClone", 0, Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraSeamlessClone.ObjectType, Construct, properties, 0, 40);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraSeamlessClone", base.GetFieldProperties(), 1348943769, -1858667549);
            
			
			
			fieldProperties.AddProperty(new Property("backToSeamlessCloneReleasePreset_", 322051202, "Black.Camera.SeamlessCloneReleasePreset", 8, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("backToNormalCoordInterpType_", 3566273640, "Black.Camera.CoordInterpType", 12, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("backToNormalInterpTime_", 381639208, "float", 16, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("backToNormalCameraTime1_", 2883680934, "float", 20, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("backToNormalCameraTime2_", 3957007265, "float", 24, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("backToNormalCameraAccel_", 1107066602, "float", 28, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("backToNormalInterpBlendMode_", 3356501455, "SQEX.Ebony.Framework.TimeControl.InterpMode", 32, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new InGameCameraSeamlessClone();
        }
		
    }
}