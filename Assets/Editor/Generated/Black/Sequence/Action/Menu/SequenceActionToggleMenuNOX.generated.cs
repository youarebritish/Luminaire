using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Menu
{
    public partial class SequenceActionToggleMenuNOX : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin pinShow_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin pinHide_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin pinPause_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin pinResume_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin pinConfig_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin pinAddTime_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin pinSetBonus_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin pinOut_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin pinOnClosed_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin labelAddTime_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin labelPinCurrentTime_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin labelPinBonusTime_;
		public int menuType_;
		public int countdownTime_;
		public float stopTime_;
		public float currentTime_;
		public float addTime_;
		public float bonusTime_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionToggleMenuNOX();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Menu.SequenceActionToggleMenuNOX", 0, Black.Sequence.Action.Menu.SequenceActionToggleMenuNOX.ObjectType, null, properties, 0, 1392);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Menu.SequenceActionToggleMenuNOX", base.GetFieldProperties(), -1626555324, 471423118);
            
			
			
			return fieldProperties;
        }

		
    }
}