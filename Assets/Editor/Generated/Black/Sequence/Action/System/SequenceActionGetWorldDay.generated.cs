using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.System
{
    public partial class SequenceActionGetWorldDay : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stop_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin monday_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin tuesday_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin wednesday_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin thursday_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin friday_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin saturday_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin sunday_;
		public bool updateStatusFlag_;
		public bool changeActivate_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionGetWorldDay();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.System.SequenceActionGetWorldDay", 0, Black.Sequence.Action.System.SequenceActionGetWorldDay.ObjectType, null, properties, 0, 1144);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.System.SequenceActionGetWorldDay", base.GetFieldProperties(), -1544190838, 1870987113);
            return fieldProperties;
        }

		
    }
}