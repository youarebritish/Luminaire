using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Sample
{
    public partial class SequenceActionSamplePropertySequence : SQEX.Ebony.Framework.Sequence.Action.SequenceActionWithCurveControl
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool bool1_;
		public bool bool1R_;
		public int int1_;
		public int int1R_;
		public float float1_;
		public float float1R_;
		public UnityEngine.Vector4 vect1_;
		public UnityEngine.Vector4 vect1R_;
		public UnityEngine.Color color1_;
		public UnityEngine.Color color1R_;
		public string str1_;
		public string str1R_;
		public string fileExt1_;
		public string fileExt1R_;
		public string matchFolder1_;
		public string matchFolder1R_;
		public uint fixId1_;
		public uint fixId1R_;
		public int enum1_;
		public int enum1R_;
		public bool pointer1_;
		public bool pointer1R_;
		public bool buttonUi_;
		public bool buttonUiR_;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> pathList_;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> strList_;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem> fixIdList_;
		public IList<bool> primitiveBoolList_;
		public IList<int> primitiveIntList_;
		public IList<float> primitiveFloatList_;
		public IList<Black.Camera.CameraManager.BlackCameraParamType> primitiveEnumLongList_;
		public IList<string> primitiveStringList_;
		public IList<UnityEngine.Vector4> primitiveVectorList_;
		public IList<UnityEngine.Color> primitivecolorList_;
		public Black.System.TimeLine.TrackItem.Render.Light.LightBaseTrackItem struct1_;
		public bool deprecatedTest_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSamplePropertySequence();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Sample.SequenceActionSamplePropertySequence", 0, Black.Sequence.Action.Sample.SequenceActionSamplePropertySequence.ObjectType, null, properties, 0, 736);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Sample.SequenceActionSamplePropertySequence", base.GetFieldProperties(), 816959911, 1668750301);
            
			fieldProperties.AddIndirectlyProperty(new Property("refInPorts_", 1035088696, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 24, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("refOutPorts_", 283683627, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 40, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triInPorts_", 291734708, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 96, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triOutPorts_", 3107891487, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 112, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("Isolated_", 56305607, "bool", 168, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("curveList_", 1657928633, "SQEX.Ebony.Framework.TimeControl.CurveList", 176, 24, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("curveList_.propertyList_", 3952472237, "SQEX.Ebony.Std.DynamicArray< AnchorReferenceValue* >", 184, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddIndirectlyProperty(new Property("struct1_.name_", 4152728438, "Ebony.Base.String", 608, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("struct1_.startTime_", 2593618680, "float", 624, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("struct1_.duration_", 182690855, "float", 628, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("struct1_.intensity_", 3845637120, "float", 688, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("struct1_.radius_", 3315008761, "float", 692, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("struct1_.range_", 3642218252, "float", 696, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("struct1_.shadowEnabled_", 131977948, "bool", 700, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("struct1_.shadowResolution_", 3235291785, "int", 704, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("struct1_.shadowZNear_", 2671933491, "float", 708, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("struct1_.shadowSlopeBias_", 1403561373, "float", 712, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("struct1_.shadowZBias_", 868658602, "float", 716, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("struct1_.shadowPower_", 639964000, "float", 720, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("struct1_.chrOnlyShadow_", 1605062120, "bool", 724, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("bool1_", 3708852577, "bool", 208, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("bool1R_", 4279607015, "bool", 209, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("int1_", 1591999430, "int", 212, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("int1R_", 973457990, "int", 216, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("float1_", 362392249, "float", 220, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("float1R_", 2802022863, "float", 224, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("vect1_", 3040279947, "Luminous.Math.VectorA", 240, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("vect1R_", 1501900169, "Luminous.Math.VectorA", 256, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("color1_", 2542669948, "SQEX.Luminous.RenderInterface.Color", 272, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("color1R_", 2008010316, "SQEX.Luminous.RenderInterface.Color", 288, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("str1_", 356599108, "Ebony.Base.String", 304, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("str1R_", 3500431300, "Ebony.Base.String", 320, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("fileExt1_", 2733552550, "Ebony.Base.String", 336, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("fileExt1R_", 920993766, "Ebony.Base.String", 352, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("matchFolder1_", 4164045150, "Ebony.Base.String", 368, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("matchFolder1R_", 4163016078, "Ebony.Base.String", 384, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("fixId1_", 3347620217, "SQEX.Ebony.Std.Fixid", 400, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("fixId1R_", 36774031, "SQEX.Ebony.Std.Fixid", 404, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("enum1_", 3773704756, "Black.Camera.CameraManager.BlackCurveType", 408, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("enum1R_", 2177953780, "Black.Camera.CameraManager.BlackCurveType", 412, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("pointer1_", 3541441658, "bool", 416, 8, 1, Property.PrimitiveType.Pointer, 0, (char)1));
			fieldProperties.AddProperty(new Property("pointer1R_", 1890847426, "bool", 424, 8, 1, Property.PrimitiveType.Pointer, 0, (char)1));
			fieldProperties.AddProperty(new Property("buttonUi_", 2215860928, "bool", 432, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("buttonUiR_", 3382206648, "bool", 433, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("pathList_", 1542541383, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem* >", 440, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("strList_", 561392677, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem* >", 456, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("fixIdList_", 1392735706, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem* >", 472, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("primitiveBoolList_", 2010904587, "SQEX.Ebony.Std.DynamicArray< bool >", 488, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("primitiveIntList_", 2502563584, "SQEX.Ebony.Std.DynamicArray< int >", 504, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("primitiveFloatList_", 380876097, "SQEX.Ebony.Std.DynamicArray< float >", 520, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("primitiveEnumLongList_", 243565334, "SQEX.Ebony.Std.DynamicArray< Black.Camera.CameraManager.BlackCameraParamType >", 536, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("primitiveStringList_", 4145142736, "SQEX.Ebony.Std.DynamicArray< Ebony.Base.String >", 552, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("primitiveVectorList_", 3377439346, "SQEX.Ebony.Std.DynamicArray< Luminous.Math.VectorA >", 568, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("primitivecolorList_", 3221264366, "SQEX.Ebony.Std.DynamicArray< Luminous.RenderInterface.Color >", 584, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("struct1_", 3684028820, "Black.System.TimeLine.TrackItem.Render.Light.LightBaseTrackItem", 600, 128, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("deprecatedTest_", 3328725613, "bool", 728, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}