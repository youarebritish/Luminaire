using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level
{
    public partial class SequenceActionSetAreaReStart : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public string restartPackage_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin packagePathPin_;
		public UnityEngine.Vector4 restartPosition_;
		public uint restartFixId_;
		public IList<Black.Entity.Data.Area.SetAreaReStartItem> packageList_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin valueRestartPosition_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin valueRestartRotation_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin valueRestartPoint_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin valueRestartLabelId_;
		public bool isUseCampPoint_;
		public bool isUseReturnInfo_;
		public bool isClearWorldPackage_;
		public bool isClearUniversalPackage_;
		public uint debugSceneLabelFixId_;
		public bool isAutoRestartPackage_;
		public bool isSetNewGame_;
		public bool isSetNewGamePlus_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin valueRestartTiming_;
		public bool isMobhuntFirstTravel_;
		public bool isReturnDungeonEntrance_;
		public bool isReturnFromTutorialToWorld_;
		public uint tutorialFixId0_;
		public uint tutorialFixId1_;
		public uint tutorialFixId2_;
		public bool isOverwritePlaytimeAtReturning_;
		public bool isOverwriteSnapshotAtReturning_;
		public bool isOverwriteEnemyKillNumAtReturning_;
		public bool isSetLoadGameCarnival_;
		public bool isMaskingDLCItemDisp_;
		public float loadDistanceLimit_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetAreaReStart();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.SequenceActionSetAreaReStart", 0, Black.Sequence.Action.Level.SequenceActionSetAreaReStart.ObjectType, null, properties, 0, 1120);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.SequenceActionSetAreaReStart", base.GetFieldProperties(), 208401350, 523456246);
            
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("restartPackage_", 2864580609, "SQEX.Ebony.Base.String", 368, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("packagePathPin_", 2775347612, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 384, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("restartPosition_", 4094791152, "SQEX.Luminous.Math.VectorA", 480, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("restartFixId_", 2072187327, "SQEX.Ebony.Std.Fixid", 496, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("packageList_", 3847141300, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.Area.SetAreaReStartItem >", 504, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("valueRestartPosition_", 1297389655, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 520, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("valueRestartRotation_", 2897696920, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 608, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("valueRestartPoint_", 3917621186, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 696, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("valueRestartLabelId_", 599321997, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 784, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUseCampPoint_", 1470513022, "bool", 872, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUseReturnInfo_", 3259058823, "bool", 873, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isClearWorldPackage_", 3749650467, "bool", 874, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isClearUniversalPackage_", 3546328022, "bool", 875, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("debugSceneLabelFixId_", 2140205857, "SQEX.Ebony.Std.Fixid", 876, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("isAutoRestartPackage_", 29672696, "bool", 880, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isSetNewGame_", 2226302826, "bool", 881, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isSetNewGamePlus_", 1892604986, "bool", 882, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("valueRestartTiming_", 2897845296, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 888, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isMobhuntFirstTravel_", 1254054547, "bool", 976, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isReturnDungeonEntrance_", 1058872522, "bool", 977, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isReturnFromTutorialToWorld_", 1652462365, "bool", 978, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("tutorialFixId0_", 919958382, "SQEX.Ebony.Std.Fixid", 980, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("tutorialFixId1_", 1993578903, "SQEX.Ebony.Std.Fixid", 984, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("tutorialFixId2_", 919664192, "SQEX.Ebony.Std.Fixid", 988, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("isOverwritePlaytimeAtReturning_", 3760988831, "bool", 992, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isOverwriteSnapshotAtReturning_", 3545884296, "bool", 993, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isOverwriteEnemyKillNumAtReturning_", 536202980, "bool", 994, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isSetLoadGameCarnival_", 520370824, "bool", 995, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isMaskingDLCItemDisp_", 4051815496, "bool", 996, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("loadDistanceLimit_", 366319694, "float", 1000, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}