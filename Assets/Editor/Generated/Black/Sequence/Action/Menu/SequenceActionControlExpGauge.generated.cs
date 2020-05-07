using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Menu
{
    public partial class SequenceActionControlExpGauge : Black.Sequence.Action.Menu.SequenceActionSwfEntityHierarchyBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin playPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin levelUpPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin endPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin addedExp_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin swfEntityInput_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin counterSwfEntityInput_;
		public uint expTextFieldId_;
		public uint nextExpTextFieldId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionControlExpGauge();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Menu.SequenceActionControlExpGauge", 0, Black.Sequence.Action.Menu.SequenceActionControlExpGauge.ObjectType, null, properties, 0, 1104);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Menu.SequenceActionControlExpGauge", base.GetFieldProperties(), 1616218214, -265979963);
            return fieldProperties;
        }

		
    }
}