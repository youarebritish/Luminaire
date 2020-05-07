using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level.System
{
    public partial class SequenceActionGetPlayerChangeStatus : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin changedPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin unchangedPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finishedPin_;
		public bool bCheckMenuOpen_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionGetPlayerChangeStatus();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.System.SequenceActionGetPlayerChangeStatus", 0, Black.Sequence.Action.Level.System.SequenceActionGetPlayerChangeStatus.ObjectType, null, properties, 0, 568);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.System.SequenceActionGetPlayerChangeStatus", base.GetFieldProperties(), 1049395414, 424790442);
            return fieldProperties;
        }

		
    }
}