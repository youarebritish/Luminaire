using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Event
{
    public partial class SequenceEventPadInput : SQEX.Ebony.Framework.Sequence.SequenceEvent
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin enable_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin disable_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin a_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin b_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin x_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin y_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin l1_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin l2_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin r1_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin r2_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin left_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin right_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin up_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin down_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin start_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin l3_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin r3_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin lsLeft_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin lsRight_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin lsUp_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin lsDown_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin decide_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin cancel_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin lr1_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin lr2_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin lr12_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin lr2Sta_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin upA_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin upB_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin upX_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin upY_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin downA_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin downB_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin downX_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin downY_;
		public int simPushType_;
		public int simPushType2_;
		public int padNumber_;
		public int padAction_;
		public bool authoringOnly_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventPadInput();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Event.SequenceEventPadInput", 0, SQEX.Ebony.Framework.Sequence.Event.SequenceEventPadInput.ObjectType, null, properties, 0, 3568);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Event.SequenceEventPadInput", base.GetFieldProperties(), 1992856881, -1394298528);
            
			fieldProperties.AddProperty(new Property("enable_", 3925052483, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("disable_", 1760805492, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("a_", 1915043849, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("b_", 1915485134, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 464, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("x_", 845366280, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 560, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("y_", 1918883633, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 656, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("l1_", 652833987, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 752, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("l2_", 1726454508, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 848, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("r1_", 1530447241, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 944, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("r2_", 1530888526, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1040, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("left_", 4210150909, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1136, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("right_", 127990734, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1232, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("up_", 1636505837, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1328, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("down_", 1969139582, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1424, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("start_", 3266844032, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1520, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("l3_", 1726307413, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1616, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("r3_", 456973815, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1712, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("lsLeft_", 690877586, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1808, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("lsRight_", 3363260959, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1904, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("lsUp_", 1072745278, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2000, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("lsDown_", 3057402577, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2096, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("decide_", 1280552794, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2192, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("cancel_", 1679818508, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2288, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("lr1_", 3932559603, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2384, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("lr2_", 3932412508, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2480, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("lr12_", 2871287585, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2576, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("lr2Sta_", 567770768, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2672, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("upA_", 1068383876, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2768, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("upB_", 4289730651, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2864, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("upX_", 1072076565, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2960, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("upY_", 1072223660, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 3056, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("downA_", 3844557017, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 3152, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("downB_", 3844998302, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 3248, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("downX_", 3843424184, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 3344, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("downY_", 3843277089, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 3440, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("simPushType_", 1287234149, "SQEX.Ebony.Framework.Sequence.Event.SequenceEventPadInput.SIMULTANEOUS_PUSH", 3536, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("simPushType2_", 43044595, "SQEX.Ebony.Framework.Sequence.Event.SequenceEventPadInput.SIMULTANEOUS_PUSH", 3540, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("padNumber_", 3085615064, "int", 3544, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("padAction_", 1209527701, "SQEX.Ebony.Framework.Sequence.Event.SequenceEventPadInput.PadActionType", 3548, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("authoringOnly_", 4271511001, "bool", 3552, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}