using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Bonamik
{
    public partial class BonamikWindGeneralTrackItem : Black.System.TimeLine.TrackItem.BlendTrackItemBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int windType_;
		public uint bnmwndId_;
		public UnityEngine.Vector4 windForce_;
		public UnityEngine.Vector4 randomRange_;
		public float randomTime_;
		public float blastStrength_;
		public float blastRange_;
		public float blastPeakInRange_;
		public float blastSpeed_;
		public bool blastIsLoop_;
		public int blastLoop_;
		public float windMultiplier_;
		public float speedMultiplier_;
		public int windKind_;
		public int areaType_;
		public bool globalAddition_;
		public float radius_;
		public UnityEngine.Vector4 boxSize_;
		public UnityEngine.Vector4 position_;
		public UnityEngine.Vector4 rotation_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BonamikWindGeneralTrackItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Bonamik.BonamikWindGeneralTrackItem", 0, Black.System.TimeLine.TrackItem.Bonamik.BonamikWindGeneralTrackItem.ObjectType, null, properties, 0, 368);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Bonamik.BonamikWindGeneralTrackItem", base.GetFieldProperties(), 1756632349, -349247785);
            
			fieldProperties.AddIndirectlyProperty(new Property("name_", 182823483, "Ebony.Base.String", 8, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startTime_", 140908163, "float", 24, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("duration_", 1282328598, "float", 28, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("blendRate_", 930283391, "float", 136, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startInterpTime_", 1816728177, "float", 140, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endInterpTime_", 654645938, "float", 144, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("curveList_", 1657928633, "SQEX.Ebony.Framework.TimeControl.CurveList", 152, 24, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("curveList_.propertyList_", 3952472237, "SQEX.Ebony.Std.DynamicArray< AnchorReferenceValue* >", 160, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			
			
			fieldProperties.AddProperty(new Property("windType_", 2345646048, "Black.System.TimeLine.TrackItem.Bonamik.BonamikWindGeneralTrackItem.eWINDTYPE", 176, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("bnmwndId_", 3244951011, "SQEX.Ebony.Std.Fixid", 180, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("windForce_", 2667354487, "Luminous.Math.VectorA", 192, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("randomRange_", 413357744, "Luminous.Math.VectorA", 208, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("randomTime_", 3343243252, "float", 224, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("blastStrength_", 3407531385, "float", 228, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("blastRange_", 3397672251, "float", 232, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("blastPeakInRange_", 4011029651, "float", 236, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("blastSpeed_", 4214185697, "float", 240, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("blastIsLoop_", 3430654936, "bool", 244, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("blastLoop_", 2367890936, "int", 248, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("windMultiplier_", 3079316601, "float", 252, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("speedMultiplier_", 2153469272, "float", 256, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("windKind_", 455425718, "unsigned int", 260, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("areaType_", 3864051017, "Black.Entity.Data.Wind.BonamikWindEntity.eAREATYPE", 264, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("globalAddition_", 3085034019, "bool", 268, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("radius_", 2286360452, "float", 272, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("boxSize_", 4023026188, "Luminous.Math.VectorA", 288, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("position_", 987254735, "Luminous.Math.VectorA", 304, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("rotation_", 36328192, "Luminous.Math.VectorA", 320, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}