using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Menu
{
    public partial class SequenceActionSetGaugeUi : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin open_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin close_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin setValue_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin valuePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin secondsPin_;
		public float encountGauge_;
		public float seconds_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin openOut_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin closeOut_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin gaugeFinished_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin isOpenedPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetGaugeUi();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Menu.SequenceActionSetGaugeUi", 0, Black.Sequence.Action.Menu.SequenceActionSetGaugeUi.ObjectType, null, properties, 0, 1032);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Menu.SequenceActionSetGaugeUi", base.GetFieldProperties(), -1727826261, -149165570);
            return fieldProperties;
        }

		
    }
}