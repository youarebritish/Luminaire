using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Action
{
    public partial class SequenceActionTimeLine : SQEX.Ebony.Framework.Sequence.Action.SequenceActionTimeLineBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin startInputPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin reverseInputPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin pauseInputPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin endInputPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outOutputPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin preparedPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finishedOutputPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin skippedOutputPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin playRateInputPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin playSpecificFrameInputPin_;
		public int timeLineType_;
		public bool isLooping_;
		public bool rewindOnPlay_;
		public float playRate_;
		public bool isReflectTimeRate_;
		public uint eventId_;
		public bool isOverrideEnvironment4Event_;
		public bool isEnableSkip_;
		public bool isEnableEventSkip_;
		public int eventSkipFrame_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLine();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Action.SequenceActionTimeLine", 0, SQEX.Ebony.Framework.Sequence.Action.SequenceActionTimeLine.ObjectType, null, properties, 0, 1504);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Action.SequenceActionTimeLine", base.GetFieldProperties(), -471883699, -545527877);
            
			fieldProperties.AddProperty(new Property("startInputPin_", 329314313, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 392, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("reverseInputPin_", 3395388311, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 488, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pauseInputPin_", 605997855, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 584, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("endInputPin_", 627811486, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 680, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outOutputPin_", 1318822242, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 872, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("preparedPin_", 151051208, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 968, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("finishedOutputPin_", 2735445822, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1064, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("skippedOutputPin_", 3189725850, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1160, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("playRateInputPin_", 2504883547, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1256, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("playSpecificFrameInputPin_", 3263032896, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1344, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("timeLineType_", 3983021819, "SQEX.Ebony.Framework.Sequence.Action.SequenceActionTimeLine.TimeLineControlType", 1432, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("isLooping_", 3262821798, "bool", 1436, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("rewindOnPlay_", 757823966, "bool", 1437, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("playRate_", 75761186, "float", 1440, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("isReflectTimeRate_", 1281060730, "bool", 1444, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("eventId_", 548562519, "SQEX.Ebony.Std.Fixid", 1448, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("isOverrideEnvironment4Event_", 2975572995, "bool", 1452, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isEnableSkip_", 4100227358, "bool", 1453, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isEnableEventSkip_", 3271627658, "bool", 1454, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("eventSkipFrame_", 2623242042, "int", 1456, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}