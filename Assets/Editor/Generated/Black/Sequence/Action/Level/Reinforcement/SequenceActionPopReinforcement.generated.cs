using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level.Reinforcement
{
    public partial class SequenceActionPopReinforcement : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin start_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finish_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin error_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inGenerator_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inEncountTrigger;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inPopPosition_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outReinforceID_;
		public uint conditionIncreaseFixid_;
		public uint conditionDecreaseFixid_;
		public uint conditionForceMaxFixid_;
		public uint conditionForceOffFixid_;
		public uint teritoryFixId_;
		public float territoryRadius_;
		public float territoryHeight_;
		public float battleAreaMargin_;
		public string bgmFilePath_;
		public float genrateAngleFromCameraBehind_;
		public float generateDistanceFromCameraMin_;
		public float generateDistanceFromCameraMax_;
		public float generateHeightFromGround_;
		public float autoDeleteDistance_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionPopReinforcement();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.Reinforcement.SequenceActionPopReinforcement", 0, Black.Sequence.Action.Level.Reinforcement.SequenceActionPopReinforcement.ObjectType, null, properties, 0, 912);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.Reinforcement.SequenceActionPopReinforcement", base.GetFieldProperties(), 1400295520, 1988407484);
            
			fieldProperties.AddProperty(new Property("start_", 3266844032, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("finish_", 190439095, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("error_", 3860306698, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inGenerator_", 3151397428, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 464, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inEncountTrigger", 2252481728, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 552, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inPopPosition_", 4186121559, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 640, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outReinforceID_", 3500519022, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 728, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("conditionIncreaseFixid_", 2918905769, "SQEX.Ebony.Std.Fixid", 816, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("conditionDecreaseFixid_", 2209966009, "SQEX.Ebony.Std.Fixid", 820, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("conditionForceMaxFixid_", 1488103722, "SQEX.Ebony.Std.Fixid", 824, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("conditionForceOffFixid_", 3569230997, "SQEX.Ebony.Std.Fixid", 828, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("teritoryFixId_", 3292314088, "SQEX.Ebony.Std.Fixid", 832, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("territoryRadius_", 1364787960, "float", 836, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("territoryHeight_", 668888755, "float", 840, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("battleAreaMargin_", 975283145, "float", 844, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("bgmFilePath_", 519512013, "Ebony.Base.String", 848, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("genrateAngleFromCameraBehind_", 1292583070, "float", 864, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("generateDistanceFromCameraMin_", 925481987, "float", 868, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("generateDistanceFromCameraMax_", 3452778345, "float", 872, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("generateHeightFromGround_", 1593659951, "float", 876, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("autoDeleteDistance_", 1081281987, "float", 880, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}