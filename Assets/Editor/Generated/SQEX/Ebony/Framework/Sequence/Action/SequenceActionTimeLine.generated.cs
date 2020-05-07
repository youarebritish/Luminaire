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
            
			fieldProperties.AddIndirectlyProperty(new Property("refInPorts_", 1035088696, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 24, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("refOutPorts_", 283683627, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 40, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triInPorts_", 291734708, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 96, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triOutPorts_", 3107891487, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 112, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("nodes_", 61650911, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Sequence.SequenceNode* >", 184, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("timeLine_", 1509031883, "SQEX.Ebony.Framework.TimeControl.TimeLine.TimeLine", 224, 120, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("timeLine_.childTrackList_", 3193550447, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.TimeControl.TimeLine.Track* >", 232, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddIndirectlyProperty(new Property("timeLine_.workAreaLeft_", 1688727675, "float", 248, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("timeLine_.workAreaRight_", 658033740, "float", 252, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("timeLine_.subTimeLineList_", 348868797, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Sequence.Action.TimeLine.Struct.TimeLineReferenceValue* >", 256, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddIndirectlyProperty(new Property("timeLine_.mainTimeLineList_", 2739202634, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Sequence.Action.TimeLine.Struct.TimeLineReferenceValue* >", 272, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddIndirectlyProperty(new Property("startInputPin_.pinName_", 432437104, "Base.String", 400, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startInputPin_.name_", 4035838875, "Base.String", 416, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startInputPin_.connections_", 731968051, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 432, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("startInputPin_.delayType_", 120047197, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 464, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startInputPin_.delayTime_", 2841118378, "float", 468, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startInputPin_.delayMaxTime_", 1030515184, "float", 472, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("reverseInputPin_.pinName_", 631855026, "Base.String", 496, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("reverseInputPin_.name_", 760318317, "Base.String", 512, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("reverseInputPin_.connections_", 3662820949, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 528, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("reverseInputPin_.delayType_", 1689407839, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 560, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("reverseInputPin_.delayTime_", 1572689228, "float", 564, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("reverseInputPin_.delayMaxTime_", 2186711158, "float", 568, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pauseInputPin_.pinName_", 2031264714, "Base.String", 592, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pauseInputPin_.name_", 3307693973, "Base.String", 608, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pauseInputPin_.connections_", 1085717261, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 624, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("pauseInputPin_.delayType_", 3216678855, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 656, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pauseInputPin_.delayTime_", 1408883204, "float", 660, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pauseInputPin_.delayMaxTime_", 3594861086, "float", 664, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endInputPin_.pinName_", 343662105, "Base.String", 688, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endInputPin_.name_", 2046799140, "Base.String", 704, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endInputPin_.connections_", 3147371994, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 720, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("endInputPin_.delayType_", 3064633352, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 752, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endInputPin_.delayTime_", 1840404163, "float", 756, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endInputPin_.delayMaxTime_", 1155161147, "float", 760, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outOutputPin_.pinName_", 2560299205, "Base.String", 880, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outOutputPin_.name_", 3358972288, "Base.String", 896, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outOutputPin_.connections_", 2186399278, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 912, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("outOutputPin_.delayType_", 814680988, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 944, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outOutputPin_.delayTime_", 2432476175, "float", 948, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outOutputPin_.delayMaxTime_", 3340550167, "float", 952, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("preparedPin_.pinName_", 302809543, "Base.String", 976, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("preparedPin_.name_", 95360498, "Base.String", 992, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("preparedPin_.connections_", 819861344, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1008, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("preparedPin_.delayType_", 945347958, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 1040, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("preparedPin_.delayTime_", 1709227009, "float", 1044, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("preparedPin_.delayMaxTime_", 1605944029, "float", 1048, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("finishedOutputPin_.pinName_", 92916025, "Base.String", 1072, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("finishedOutputPin_.name_", 4048395908, "Base.String", 1088, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("finishedOutputPin_.connections_", 4022389562, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1104, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("finishedOutputPin_.delayType_", 417034664, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 1136, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("finishedOutputPin_.delayTime_", 3487875939, "float", 1140, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("finishedOutputPin_.delayMaxTime_", 1482644123, "float", 1144, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("skippedOutputPin_.pinName_", 1747420429, "Base.String", 1168, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("skippedOutputPin_.name_", 234272920, "Base.String", 1184, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("skippedOutputPin_.connections_", 1237643574, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1200, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("skippedOutputPin_.delayType_", 2630165364, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 1232, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("skippedOutputPin_.delayTime_", 1852671063, "float", 1236, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("skippedOutputPin_.delayMaxTime_", 2157208879, "float", 1240, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("playRateInputPin_.pinName_", 3217869006, "Base.String", 1264, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("playRateInputPin_.name_", 2187546633, "Base.String", 1280, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("playRateInputPin_.connections_", 2733117561, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1296, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("playRateInputPin_.pinValueType_", 1908825600, "Base.String", 1328, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("playSpecificFrameInputPin_.pinName_", 313602831, "Base.String", 1352, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("playSpecificFrameInputPin_.name_", 2364382954, "Base.String", 1368, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("playSpecificFrameInputPin_.connections_", 2218754664, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 1384, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("playSpecificFrameInputPin_.pinValueType_", 1977779955, "Base.String", 1416, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
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