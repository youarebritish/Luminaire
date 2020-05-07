using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.AI.AIMode
{
    public partial class SequenceActionExecAIModeLead : Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin target_;
		public uint routeId_;
		public int movement_;
		public float speedRate_;
		public float enableWaitDistance_;
		public float disableWaitDistance_;
		public float arrivalDistacne_;
		public float successDistance_;
		public float failedDistance_;
		public bool isWaitOnPointEntity_;
		public bool isLookBack_;
		public bool disableLookAtIK;
		public bool isTryToKeepLead_;
		public uint sceneId_;
		public uint waitStartScriptGroupId_;
		public uint waitOutScriptGroupId_;
		public uint arrivalScriptGroupId_;
		public bool isAutoLoadVoice_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionExecAIModeLead();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModeLead", 0, Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModeLead.ObjectType, null, properties, 0, 1504);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModeLead", base.GetFieldProperties(), -52565586, 1539837766);
            
			fieldProperties.AddProperty(new Property("target_", 1693858869, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1224, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("routeId_", 1540478228, "SQEX.Luminous.Std.Fixid", 1312, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("movement_", 1839887621, "Black.AI.Move.AIMovement", 1316, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("speedRate_", 3062039623, "float", 1320, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableWaitDistance_", 3550165881, "float", 1324, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("disableWaitDistance_", 3422543610, "float", 1328, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("arrivalDistacne_", 1060243140, "float", 1332, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("successDistance_", 1901104572, "float", 1336, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("failedDistance_", 3209868480, "float", 1340, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("isWaitOnPointEntity_", 137942255, "bool", 1344, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isLookBack_", 2677583486, "bool", 1345, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("disableLookAtIK", 2586624813, "bool", 1346, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isTryToKeepLead_", 2978695677, "bool", 1347, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("sceneId_", 2391626355, "SQEX.Luminous.Std.Fixid", 1348, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("waitStartScriptGroupId_", 3735013892, "SQEX.Luminous.Std.Fixid", 1352, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("waitOutScriptGroupId_", 2445488908, "SQEX.Luminous.Std.Fixid", 1356, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("arrivalScriptGroupId_", 3982637526, "SQEX.Luminous.Std.Fixid", 1360, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("isAutoLoadVoice_", 2087250069, "bool", 1364, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}