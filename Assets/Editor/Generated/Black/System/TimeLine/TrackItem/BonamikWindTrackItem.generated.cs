using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem
{
    public partial class BonamikWindTrackItem : Black.System.TimeLine.TrackItem.BlendTrackItemBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint bnmwndId_;
		public float windMultiplier_;
		public float speedMultiplier_;
		public int windKind_;
		public int areaType_;
		public bool globalAddition_;
		public float radius_;
		public UnityEngine.Vector4 boxSize_;
		public bool isAttach_;
		public uint elementId_;
		public UnityEngine.Vector4 offset_;
		public UnityEngine.Vector4 rotation_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BonamikWindTrackItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.BonamikWindTrackItem", 0, Black.System.TimeLine.TrackItem.BonamikWindTrackItem.ObjectType, null, properties, 0, 288);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.BonamikWindTrackItem", base.GetFieldProperties(), -1405187234, -528592524);
            
			fieldProperties.AddIndirectlyProperty(new Property("name_", 182823483, "Ebony.Base.String", 8, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startTime_", 140908163, "float", 24, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("duration_", 1282328598, "float", 28, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("blendRate_", 930283391, "float", 136, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startInterpTime_", 1816728177, "float", 140, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endInterpTime_", 654645938, "float", 144, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("curveList_", 1657928633, "SQEX.Ebony.Framework.TimeControl.CurveList", 152, 24, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("curveList_.propertyList_", 3952472237, "SQEX.Ebony.Std.DynamicArray< AnchorReferenceValue* >", 160, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			
			
			fieldProperties.AddProperty(new Property("bnmwndId_", 3244951011, "SQEX.Ebony.Std.Fixid", 176, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("windMultiplier_", 3079316601, "float", 180, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("speedMultiplier_", 2153469272, "float", 184, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("windKind_", 455425718, "unsigned int", 188, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("areaType_", 3864051017, "Black.Entity.Data.Wind.BonamikWindEntity.eAREATYPE", 192, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("globalAddition_", 3085034019, "bool", 196, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("radius_", 2286360452, "float", 200, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("boxSize_", 4023026188, "Luminous.Math.VectorA", 208, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("isAttach_", 3970744625, "bool", 224, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("elementId_", 1896981983, "SQEX.Ebony.Std.Fixid", 228, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("offset_", 1294275471, "Luminous.Math.VectorA", 240, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("rotation_", 36328192, "Luminous.Math.VectorA", 256, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}