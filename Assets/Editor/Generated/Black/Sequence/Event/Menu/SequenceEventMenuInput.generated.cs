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
            return fieldProperties;
        }

		
    }
}