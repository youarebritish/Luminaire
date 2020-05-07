using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event.Menu
{
    public partial class SequenceEventMenuInput : SQEX.Ebony.Framework.Sequence.SequenceEvent
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin enablePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin disablePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin movePrevPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin moveNextPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin movePrevRepeatPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin moveNextRepeatPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin moveUpPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin moveDownPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin moveUpRepeatPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin moveDownRepeatPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin moveLeftPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin moveRightPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin moveLeftRepeatPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin moveRightRepeatPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin moveL1Pin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin moveR1Pin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin moveL1RepeatPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin moveR1RepeatPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin moveL2Pin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin moveR2Pin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin moveL2RepeatPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin moveR2RepeatPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin decidedPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin canceledPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin squarePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin trianglePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin l3Pin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin r3Pin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin startPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin selectPin_;
		public int cursorDirectionType_;
		public int padAction_;
		public bool autoDisable_;
		public bool useMainKeyFocus_;
		public bool alwaysClearPad_;
		public bool decideClearPad_;
		public bool cancelClearPad_;
		public bool squareClearPad_;
		public bool triangleClearPad_;
		public bool startClearPad_;
		public bool selectClearPad_;
		public bool l1ClearPad_;
		public bool r1ClearPad_;
		public int startRepeatFrame_;
		public int intervalRepeatFrame_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventMenuInput();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.Menu.SequenceEventMenuInput", 0, Black.Sequence.Event.Menu.SequenceEventMenuInput.ObjectType, null, properties, 0, 3104);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.Menu.SequenceEventMenuInput", base.GetFieldProperties(), 1017274828, 1209991591);
            
			fieldProperties.AddProperty(new Property("enablePin_", 2477767534, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("disablePin_", 911041999, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("movePrevPin_", 3867206685, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("moveNextPin_", 2979458537, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 464, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("movePrevRepeatPin_", 20823278, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 560, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("moveNextRepeatPin_", 77318210, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 656, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("moveUpPin_", 3345583493, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 752, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("moveDownPin_", 167598448, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 848, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("moveUpRepeatPin_", 4088788918, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 944, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("moveDownRepeatPin_", 283343739, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1040, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("moveLeftPin_", 1098262945, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1136, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("moveRightPin_", 286398830, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1232, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("moveLeftRepeatPin_", 86353338, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1328, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("moveRightRepeatPin_", 3274082893, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1424, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("moveL1Pin_", 440912247, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1520, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("moveR1Pin_", 3054166949, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1616, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("moveL1RepeatPin_", 581255900, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1712, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("moveR1RepeatPin_", 811884566, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1808, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("moveL2Pin_", 3987866990, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1904, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("moveR2Pin_", 4208394768, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2000, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("moveL2RepeatPin_", 57087565, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2096, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("moveR2RepeatPin_", 4164103259, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2192, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("decidedPin_", 501229515, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2288, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("canceledPin_", 2029360058, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2384, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("squarePin_", 4149579958, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2480, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("trianglePin_", 3145603633, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2576, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("l3Pin_", 2659188040, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2672, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("r3Pin_", 4187379746, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2768, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("startPin_", 2664043275, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2864, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("selectPin_", 806940521, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2960, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("cursorDirectionType_", 2351682253, "Black.Sequence.Event.Menu.SequenceEventMenuInput.CursorDirectionType", 3056, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("padAction_", 1209527701, "Black.Sequence.Event.Menu.SequenceEventMenuInput.PadActionType", 3060, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("autoDisable_", 1670925043, "bool", 3064, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("useMainKeyFocus_", 2326074045, "bool", 3065, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("alwaysClearPad_", 2702492483, "bool", 3066, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("decideClearPad_", 3377348824, "bool", 3067, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("cancelClearPad_", 2056169074, "bool", 3068, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("squareClearPad_", 2670964517, "bool", 3069, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("triangleClearPad_", 2911211188, "bool", 3070, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("startClearPad_", 3504244798, "bool", 3071, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("selectClearPad_", 1846190828, "bool", 3072, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("l1ClearPad_", 4208591357, "bool", 3073, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("r1ClearPad_", 3150150203, "bool", 3074, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("startRepeatFrame_", 2733462798, "unsigned int", 3076, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("intervalRepeatFrame_", 3661613097, "unsigned int", 3080, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}