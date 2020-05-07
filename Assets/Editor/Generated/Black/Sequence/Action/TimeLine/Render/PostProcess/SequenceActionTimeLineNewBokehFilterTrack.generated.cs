using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Render.PostProcess
{
    public partial class SequenceActionTimeLineNewBokehFilterTrack : SQEX.Ebony.Framework.Sequence.Action.SequenceActionTimeLineTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int filterLevel_;
		public bool enabled_;
		public bool enableWeather_;
		public int bokehShape_;
		public float bokehShapeRotation_;
		public float foculLength_;
		public float fNumber_;
		public float focalPlane_;
		public float focalPlaneRadius_;
		public float nearCoCMultiplier_;
		public float farCoCMultiplier_;
		public float maxCoCSizeNear_;
		public float maxCoCSizeFar_;
		public bool vignetteBlur_enabled_;
		public float vignetteBlur_yScale_;
		public float vignetteBlur_start_;
		public float vignetteBlur_strength_;
		public float vignetteBlur_power_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineNewBokehFilterTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Render.PostProcess.SequenceActionTimeLineNewBokehFilterTrack", 0, Black.Sequence.Action.TimeLine.Render.PostProcess.SequenceActionTimeLineNewBokehFilterTrack.ObjectType, null, properties, 0, 448);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Render.PostProcess.SequenceActionTimeLineNewBokehFilterTrack", base.GetFieldProperties(), -1378842193, -982187144);
            
			fieldProperties.AddIndirectlyProperty(new Property("refInPorts_", 1035088696, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 24, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("refOutPorts_", 283683627, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 40, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triInPorts_", 291734708, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 96, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triOutPorts_", 3107891487, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 112, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("Isolated_", 56305607, "bool", 168, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("curveList_", 1657928633, "SQEX.Ebony.Framework.TimeControl.CurveList", 176, 24, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("curveList_.propertyList_", 3952472237, "SQEX.Ebony.Std.DynamicArray< AnchorReferenceValue* >", 184, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddIndirectlyProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 208, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.pinName_", 3330161590, "Base.String", 216, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.name_", 192292993, "Base.String", 232, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.connections_", 490033121, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 248, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("in_.delayType_", 261766523, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 280, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.delayTime_", 1689218608, "float", 284, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.delayMaxTime_", 1529341114, "float", 288, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("filterLevel_", 124193320, "Black.Graphics.ScreenEffect.BokehFilterLevel", 320, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("enabled_", 1722022099, "bool", 324, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddProperty(new Property("enableWeather_", 1384777099, "bool", 325, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("bokehShape_", 2200505952, "int", 328, 4, 1, Property.PrimitiveType.Int32, 0, (char)1));
			fieldProperties.AddProperty(new Property("bokehShapeRotation_", 2630922490, "float", 332, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("foculLength_", 3442808531, "float", 336, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("fNumber_", 2684869345, "float", 340, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("focalPlane_", 219737661, "float", 344, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("focalPlaneRadius_", 2764587371, "float", 348, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("nearCoCMultiplier_", 1139837890, "float", 352, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("farCoCMultiplier_", 3537477447, "float", 356, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("maxCoCSizeNear_", 2241816492, "float", 360, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("maxCoCSizeFar_", 3309306271, "float", 364, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("vignetteBlur_enabled_", 2030089333, "bool", 400, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddProperty(new Property("vignetteBlur_yScale_", 2819584729, "float", 404, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("vignetteBlur_start_", 3713456890, "float", 408, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("vignetteBlur_strength_", 454397675, "float", 412, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("vignetteBlur_power_", 2683979777, "float", 416, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			
			
			return fieldProperties;
        }

		
    }
}