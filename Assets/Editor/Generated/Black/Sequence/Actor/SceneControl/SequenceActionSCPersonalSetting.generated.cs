using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.SceneControl
{
    public partial class SequenceActionSCPersonalSetting : SQEX.Ebony.Framework.Sequence.Variable.SequenceConstBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inCharEntryPath_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin overwriteParameterIDPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin spawnSet_;
		public int actorType_;
		public bool autoLoadCharaEntry_;
		public string charaEntry_;
		public uint overwriteParameterID_;
		public int defaultAIControllerType_;
		public string sourcePathAI_;
		public string sourcePathAIGraph_;
		public uint overwriteInteractionParamId_;
		public uint teritoryFixId_;
		public bool isOverwriteDefaultControllerType_;
		public string sourcePathScheduleAI_;
		public string sourcePathScheduleDefault_;
		public uint overrideAIParamId_;
		public string sourcePathCommand_;
		public int maxSpawnNum_;
		public int minSpawnNum_;
		public int maxAliveNum_;
		public int minAliveNum_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSCPersonalSetting();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SceneControl.SequenceActionSCPersonalSetting", 0, Black.Sequence.Actor.SceneControl.SequenceActionSCPersonalSetting.ObjectType, null, properties, 0, 504);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SceneControl.SequenceActionSCPersonalSetting", base.GetFieldProperties(), -849926598, -390443165);
            
			fieldProperties.AddProperty(new Property("inCharEntryPath_", 1635483842, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 88, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("overwriteParameterIDPin_", 3878013520, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 176, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("spawnSet_", 3879999141, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 264, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("actorType_", 364512479, "Black.Entity.Data.CharacterEntry.ActorType", 352, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("autoLoadCharaEntry_", 566782704, "bool", 356, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("charaEntry_", 1111613605, "Ebony.Base.String", 360, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("overwriteParameterID_", 1970039245, "SQEX.Ebony.Std.Fixid", 376, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("defaultAIControllerType_", 1565540817, "Black.Actor.Component.Controller.CONTROLLER_TYPE", 380, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("sourcePathAI_", 482071410, "Ebony.Base.String", 384, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("sourcePathAIGraph_", 3998915884, "Ebony.Base.String", 400, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("overwriteInteractionParamId_", 4230144195, "SQEX.Ebony.Std.Fixid", 416, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("teritoryFixId_", 3292314088, "SQEX.Ebony.Std.Fixid", 420, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("isOverwriteDefaultControllerType_", 2273265948, "bool", 424, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("sourcePathScheduleAI_", 291784217, "Ebony.Base.String", 432, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("sourcePathScheduleDefault_", 1607129188, "Ebony.Base.String", 448, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("overrideAIParamId_", 2314906194, "SQEX.Ebony.Std.Fixid", 464, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("sourcePathCommand_", 3792604233, "Ebony.Base.String", 472, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("maxSpawnNum_", 3388314369, "int", 488, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("minSpawnNum_", 1214781407, "int", 492, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("maxAliveNum_", 1576209383, "int", 496, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("minAliveNum_", 1268498533, "int", 500, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}