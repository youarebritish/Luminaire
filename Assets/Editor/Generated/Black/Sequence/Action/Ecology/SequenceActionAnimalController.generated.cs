using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Ecology
{
    public partial class SequenceActionAnimalController : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public int characterType_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin idel_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin walk_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin jump_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin water_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin die_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin fly_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin inDistance_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outDistance_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actor_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin actorIdIdel_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin actorIdWalk_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin actorIdJump_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin actorIdWater_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin actorIdDie_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin actorIdFly_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin actorIdInDistance_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin actorIdOutDistance_;
		public float upperLength_;
		public float downLength_;
		public float deepWater_;
		public int target_;
		public float distance_;
		public int dieTime_;
		public string idel_aniPath_;
		public string idel_aniPath01_;
		public float idel_rate_;
		public float idel_completionTimer_;
		public string walk_aniPath_;
		public float walk_rate_;
		public string jump_aniPath_;
		public float jump_rate_;
		public string water_aniPath_;
		public string water_aniPath01_;
		public float water_rate_;
		public string die_aniPath_;
		public float die_rate_;
		public string fly_aniPath_;
		public string fly_st_aniPath_;
		public string fly_ed_aniPath_;
		public float fly_rate_;
		public uint motionId00_;
		public uint motionId01_;
		public int initState_;
		public bool isUseInteraction_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAnimalController();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Ecology.SequenceActionAnimalController", 0, Black.Sequence.Action.Ecology.SequenceActionAnimalController.ObjectType, null, properties, 0, 5632);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Ecology.SequenceActionAnimalController", base.GetFieldProperties(), -1613542778, 558385276);
            
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("characterType_", 1723239973, "Black.Sequence.Action.Ecology.SequenceActionAnimalController.CHARA_TYPE", 368, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("idel_", 3457341858, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 376, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("walk_", 1795687005, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 472, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("jump_", 2596164886, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 568, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("water_", 1923410525, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 664, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("die_", 825426314, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 760, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("fly_", 3858657159, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 856, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inDistance_", 3901678606, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 952, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outDistance_", 2957946277, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1048, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("actor_", 3434601855, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1144, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("actorIdIdel_", 345872260, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1232, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("actorIdWalk_", 1800527991, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1320, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("actorIdJump_", 2347250708, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1408, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("actorIdWater_", 3020731627, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1496, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("actorIdDie_", 473347872, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1584, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("actorIdFly_", 2429304489, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1672, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("actorIdInDistance_", 2763902024, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1760, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("actorIdOutDistance_", 3153394459, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1848, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("upperLength_", 3359177224, "float", 1936, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("downLength_", 1582641934, "float", 1940, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("deepWater_", 3188762035, "float", 1944, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("target_", 1693858869, "Black.Sequence.Action.Ecology.SequenceActionAnimalController.TARGET", 1948, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("distance_", 3236486151, "float", 1952, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("dieTime_", 4228001013, "int", 1956, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("idel_aniPath_", 2867263860, "Ebony.Base.String", 1960, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("idel_aniPath01_", 1175799349, "Ebony.Base.String", 1976, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("idel_rate_", 3088705437, "float", 1992, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("idel_completionTimer_", 251843762, "float", 1996, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("walk_aniPath_", 1380971499, "Ebony.Base.String", 2000, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("walk_rate_", 4050840768, "float", 2016, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("jump_aniPath_", 1802294800, "Ebony.Base.String", 2024, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("jump_rate_", 1564961617, "float", 2040, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("water_aniPath_", 1872878571, "Ebony.Base.String", 2048, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("water_aniPath01_", 530992242, "Ebony.Base.String", 2064, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("water_rate_", 2588910784, "float", 2080, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("die_aniPath_", 3914522652, "Ebony.Base.String", 2088, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("die_rate_", 1887508773, "float", 2104, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("fly_aniPath_", 2539404797, "Ebony.Base.String", 2112, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("fly_st_aniPath_", 2647875667, "Ebony.Base.String", 2128, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("fly_ed_aniPath_", 1672037241, "Ebony.Base.String", 2144, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("fly_rate_", 1328833718, "float", 2160, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("motionId00_", 1693711263, "SQEX.Ebony.Std.Fixid", 2164, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("motionId01_", 2767625974, "SQEX.Ebony.Std.Fixid", 2168, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("initState_", 3727924001, "Black.Sequence.Action.Ecology.SequenceActionAnimalController.STATUS", 2172, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUseInteraction_", 1540276609, "bool", 2176, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}