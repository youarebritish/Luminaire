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
            return fieldProperties;
        }

		
    }
}