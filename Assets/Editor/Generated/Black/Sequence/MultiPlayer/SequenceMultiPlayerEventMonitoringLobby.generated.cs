using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.MultiPlayer
{
    public partial class SequenceMultiPlayerEventMonitoringLobby : Black.Sequence.MultiPlayer.SequenceMultiPlayerSyncEventBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin enable_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin disable_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin progress1_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin progress2_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin progress3_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin progress4_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin errorOutputPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin remainTimeVarOut1Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin remainTimeVarOut2Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin remainTimeVarOut3Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin remainTimeVarOut4Pin_;
		public float checkIntervalTime_;
		public float progressTime1_;
		public float progressTime2_;
		public float progressTime3_;
		public float progressTime4_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceMultiPlayerEventMonitoringLobby();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.MultiPlayer.SequenceMultiPlayerEventMonitoringLobby", 0, Black.Sequence.MultiPlayer.SequenceMultiPlayerEventMonitoringLobby.ObjectType, null, properties, 0, 1384);
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

            fieldProperties = new PropertyContainer("Black.Sequence.MultiPlayer.SequenceMultiPlayerEventMonitoringLobby", base.GetFieldProperties(), -1025441981, -790432683);
            
			fieldProperties.AddProperty(new Property("enable_", 3925052483, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 296, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("disable_", 1760805492, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 392, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("progress1_", 934964926, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 488, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("progress2_", 934523641, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 584, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("progress3_", 2008438352, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 680, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("progress4_", 2007893899, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 776, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("errorOutputPin_", 2215086584, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 872, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("remainTimeVarOut1Pin_", 3066961362, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 968, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("remainTimeVarOut2Pin_", 2244172699, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1056, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("remainTimeVarOut3Pin_", 937592716, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1144, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("remainTimeVarOut4Pin_", 3908671285, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1232, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("checkIntervalTime_", 2180604048, "float", 1320, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("progressTime1_", 517253199, "float", 1324, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("progressTime2_", 1590770552, "float", 1328, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("progressTime3_", 1590623457, "float", 1332, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("progressTime4_", 516708746, "float", 1336, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}