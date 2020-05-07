using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Event
{
    public partial class SequenceEventKeyboardInput : SQEX.Ebony.Framework.Sequence.SequenceEvent
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin enable_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin disable_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin push_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin repeat_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin released_;
		public bool bIsNeedShiftPress_;
		public bool bIsNeedCtrlPress_;
		public bool bIsNeedAltPress_;
		public int inputKey_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventKeyboardInput();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Event.SequenceEventKeyboardInput", 0, SQEX.Ebony.Framework.Sequence.Event.SequenceEventKeyboardInput.ObjectType, null, properties, 0, 672);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Event.SequenceEventKeyboardInput", base.GetFieldProperties(), -5678882, 99827544);
            
			
			
			return fieldProperties;
        }

		
    }
}