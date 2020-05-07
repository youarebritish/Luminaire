using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Mobhunt
{
    public partial class SequenceActionMobhuntGetLimitedTimeRewordInfo : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finished_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin mobhuntId_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin seqTableMobhuntId_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin gil_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin exp_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin ap_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin itemId_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin itemNum_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin titleMessageId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionMobhuntGetLimitedTimeRewordInfo();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Mobhunt.SequenceActionMobhuntGetLimitedTimeRewordInfo", 0, Black.Sequence.Action.Mobhunt.SequenceActionMobhuntGetLimitedTimeRewordInfo.ObjectType, null, properties, 0, 1632);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Mobhunt.SequenceActionMobhuntGetLimitedTimeRewordInfo", base.GetFieldProperties(), -158330646, 1943516203);
            
			
			
			return fieldProperties;
        }

		
    }
}