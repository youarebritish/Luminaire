using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Multiplay
{
    public partial class SaveAvatarDataStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public sbyte BaseModelType;
		public float BaseScale;
		public float HeadScale;
		public uint FaceA;
		public uint FaceB;
		public float FaceBlendWeight;
		public float FaceBlendWeightMaterial;
		public float BodyBlendWeight;
		public uint Tops;
		public uint Bottoms;
		public uint Shoes;
		public uint Gloves;
		public uint Hair;
		public uint Beard;
		public uint Wear;
		public uint Eyebrow;
		public uint Accessory;
		public uint Eyelash;
		public uint VoiceType;
		public Black.Save.Multiplay.SaveAvatarColor SkinColor;
		public Black.Save.Multiplay.SaveAvatarColor LipColor;
		public Black.Save.Multiplay.SaveAvatarColor EyeColor;
		public Black.Save.Multiplay.SaveAvatarColor HairColor;
		public Black.Save.Multiplay.SaveAvatarColor HairtipColor;
		public Black.Save.Multiplay.SaveAvatarColor BeardColor;
		public Black.Save.Multiplay.SaveAvatarColor BeardtipColor;
		public Black.Save.Multiplay.SaveAvatarColor EyebrowColor;
		public Black.Save.Multiplay.SaveAvatarScalar HairNuance;
		public uint FaceSticker;
		public uint FacePaint;
		public uint BodyPaint;
		public uint ArmRightPaint;
		public uint ArmLeftPaint;
		public uint BackPaint;
		public float NeckThickness;
		public float BodyThickness;
		public float TrapeziusMuscleThickness;
		public float ChestSize;
		public float ArmThickness;
		public float ArmThicknessBalance;
		public float WaistSize;
		public float StomachThickness;
		public float HipSize;
		public float FootThickness;
		public float EyebrowTail_FR;
		public float EyebrowTop_FR;
		public float TemporalWidth;
		public float EyebrowHead_UD;
		public float EyebrowTop_UD;
		public float EyebrowTail_UD;
		public float EyebrowInterval;
		public float Eye_UD;
		public float EyeInterval;
		public float Eye_FB;
		public float TopEyelid_UD;
		public float EyeInclination;
		public float BottomEyelid_UD;
		public float NoseHeight;
		public float Nose_UD;
		public float NoseTopHeight;
		public float NoseTopWidth;
		public float NoseRidgeHeight;
		public float NoseRidgeWidth;
		public float NoseTip_UD;
		public float NoseTipContour;
		public float NoseTipSize;
		public float Nostril_UD;
		public float NostrilWidth;
		public float CheekTopWidth;
		public float CheekTop_FR;
		public float CheekContour;
		public float CheekMiddle_FR;
		public float CheekMiddleWidth;
		public float CheekBottomWidth;
		public float Mouth_UD;
		public float MouthWidth;
		public float Mouth_FR;
		public float LipThickness;
		public float LowerLip_FR;
		public float MouthCorner_UD;
		public float MouthCorner_FR;
		public float Jaw_UD;
		public float JawDistort_LR;
		public float Jaw_FR;
		public float Chin_UD;
		public float Chin_FR;
		public float ChinContour;
		public float ChinWidth;
		public float Gills_UD;
		public float GillsBottomWidth;
		public float Gills_FR;
		public float GillsTopWidth;
		public Black.Save.Multiplay.SaveAvatarColorSet TopsColor;
		public Black.Save.Multiplay.SaveAvatarColorSet BottomsColor;
		public Black.Save.Multiplay.SaveAvatarColorSet ShoesColor;
		public Black.Save.Multiplay.SaveAvatarColorSet GloveColor;
		public Black.Save.Multiplay.SaveAvatarColorSet WearColor;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveAvatarDataStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Multiplay.SaveAvatarDataStruct", 0, Black.Save.Multiplay.SaveAvatarDataStruct.ObjectType, null, properties, 0, 1668);
        }
		
        public  ObjectType GetObjectType()
        {
            return ObjectType;
        }

        protected  PropertyContainer GetFieldProperties()
        {
            if (fieldProperties != null)
            {
                return fieldProperties;
            }

            fieldProperties = new PropertyContainer("Black.Save.Multiplay.SaveAvatarDataStruct", null, 479340456, -1575570095);
            
			fieldProperties.AddProperty(new Property("BaseModelType", 3191480045, "uint8_t", 0, 1, 1, Property.PrimitiveType.Int8, 0, (char)0));
			fieldProperties.AddProperty(new Property("BaseScale", 265786490, "float", 4, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("HeadScale", 2362102171, "float", 8, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("FaceA", 3583798663, "SQEX.Ebony.Std.Fixid", 12, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("FaceB", 3600576282, "SQEX.Ebony.Std.Fixid", 16, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("FaceBlendWeight", 1416864779, "float", 20, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("FaceBlendWeightMaterial", 3691291762, "float", 24, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("BodyBlendWeight", 3799980360, "float", 28, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("Tops", 3468106877, "SQEX.Ebony.Std.Fixid", 32, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("Bottoms", 3714966203, "SQEX.Ebony.Std.Fixid", 36, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("Shoes", 1489107955, "SQEX.Ebony.Std.Fixid", 40, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("Gloves", 3775847607, "SQEX.Ebony.Std.Fixid", 44, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("Hair", 1424250329, "SQEX.Ebony.Std.Fixid", 48, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("Beard", 3364388149, "SQEX.Ebony.Std.Fixid", 52, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("Wear", 1692953790, "SQEX.Ebony.Std.Fixid", 56, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("Eyebrow", 2428409228, "SQEX.Ebony.Std.Fixid", 60, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("Accessory", 4160079225, "SQEX.Ebony.Std.Fixid", 64, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("Eyelash", 1349085602, "SQEX.Ebony.Std.Fixid", 68, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("VoiceType", 3276317361, "SQEX.Ebony.Std.Fixid", 72, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("SkinColor", 828885775, "Black.Save.Multiplay.SaveAvatarColor", 76, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("LipColor", 1999562133, "Black.Save.Multiplay.SaveAvatarColor", 92, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("EyeColor", 2252307693, "Black.Save.Multiplay.SaveAvatarColor", 108, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("HairColor", 2727662140, "Black.Save.Multiplay.SaveAvatarColor", 124, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("HairtipColor", 598911201, "Black.Save.Multiplay.SaveAvatarColor", 140, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("BeardColor", 1561558888, "Black.Save.Multiplay.SaveAvatarColor", 156, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("BeardtipColor", 1125402765, "Black.Save.Multiplay.SaveAvatarColor", 172, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("EyebrowColor", 1911745395, "Black.Save.Multiplay.SaveAvatarColor", 188, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("HairNuance", 3446380619, "Black.Save.Multiplay.SaveAvatarScalar", 204, 8, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("FaceSticker", 70524907, "SQEX.Ebony.Std.Fixid", 212, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("FacePaint", 3640168496, "SQEX.Ebony.Std.Fixid", 216, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("BodyPaint", 2470820291, "SQEX.Ebony.Std.Fixid", 220, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("ArmRightPaint", 1911144163, "SQEX.Ebony.Std.Fixid", 224, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("ArmLeftPaint", 395211756, "SQEX.Ebony.Std.Fixid", 228, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("BackPaint", 1103167278, "SQEX.Ebony.Std.Fixid", 232, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("NeckThickness", 2987374028, "float", 236, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("BodyThickness", 2772884357, "float", 240, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("TrapeziusMuscleThickness", 3881743927, "float", 244, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("ChestSize", 3981359063, "float", 248, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("ArmThickness", 2759449669, "float", 252, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("ArmThicknessBalance", 987545611, "float", 256, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("WaistSize", 1508396802, "float", 260, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("StomachThickness", 3118304544, "float", 264, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("HipSize", 2335549471, "float", 268, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("FootThickness", 2274527977, "float", 272, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("EyebrowTail_FR", 1733542567, "float", 276, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("EyebrowTop_FR", 82945584, "float", 280, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("TemporalWidth", 3382379141, "float", 284, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("EyebrowHead_UD", 3749905618, "float", 288, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("EyebrowTop_UD", 1825007841, "float", 292, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("EyebrowTail_UD", 2737786946, "float", 296, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("EyebrowInterval", 2955667965, "float", 300, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("Eye_UD", 4013394606, "float", 304, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("EyeInterval", 2647991503, "float", 308, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("Eye_FB", 727497211, "float", 312, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("TopEyelid_UD", 478286806, "float", 316, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("EyeInclination", 1803957134, "float", 320, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("BottomEyelid_UD", 2500592836, "float", 324, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("NoseHeight", 2728232841, "float", 328, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("Nose_UD", 1086792382, "float", 332, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("NoseTopHeight", 3510511962, "float", 336, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("NoseTopWidth", 3671044631, "float", 340, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("NoseRidgeHeight", 3232015198, "float", 344, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("NoseRidgeWidth", 464592291, "float", 348, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("NoseTip_UD", 3013175853, "float", 352, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("NoseTipContour", 4119235383, "float", 356, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("NoseTipSize", 2105094138, "float", 360, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("Nostril_UD", 1300246052, "float", 364, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("NostrilWidth", 2004441740, "float", 368, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("CheekTopWidth", 4254149912, "float", 372, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("CheekTop_FR", 1926462717, "float", 376, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("CheekContour", 1111076081, "float", 380, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("CheekMiddle_FR", 2449564993, "float", 384, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("CheekMiddleWidth", 195780164, "float", 388, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("CheekBottomWidth", 3832930630, "float", 392, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("Mouth_UD", 3996545184, "float", 396, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("MouthWidth", 2139045160, "float", 400, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("Mouth_FR", 3596986637, "float", 404, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("LipThickness", 4216608252, "float", 408, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("LowerLip_FR", 343636316, "float", 412, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("MouthCorner_UD", 1141229275, "float", 416, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("MouthCorner_FR", 673574514, "float", 420, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("Jaw_UD", 3833261267, "float", 424, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("JawDistort_LR", 3733598347, "float", 428, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("Jaw_FR", 1218071274, "float", 432, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("Chin_UD", 2401468491, "float", 436, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("Chin_FR", 1391707042, "float", 440, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("ChinContour", 2712992301, "float", 444, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("ChinWidth", 3892902171, "float", 448, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("Gills_UD", 1923395902, "float", 452, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("GillsBottomWidth", 351558499, "float", 456, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("Gills_FR", 2122020379, "float", 460, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("GillsTopWidth", 1050197399, "float", 464, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("TopsColor", 2207060976, "Black.Save.Multiplay.SaveAvatarColorSet", 468, 240, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("BottomsColor", 2640869242, "Black.Save.Multiplay.SaveAvatarColorSet", 708, 240, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ShoesColor", 2604698930, "Black.Save.Multiplay.SaveAvatarColorSet", 948, 240, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("GloveColor", 3433089409, "Black.Save.Multiplay.SaveAvatarColorSet", 1188, 240, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("WearColor", 1842467713, "Black.Save.Multiplay.SaveAvatarColorSet", 1428, 240, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}