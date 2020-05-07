using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.MultiPlayer
{
    public partial class SequenceMultiPlayerDebugTime : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inOn_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inOff_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inAdd_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inSet_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inReset_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inSetDate_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueOffset_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueAddOffset_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueDate_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public int setOffset_;
		public int addOffset_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceMultiPlayerDebugTime();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.MultiPlayer.SequenceMultiPlayerDebugTime", 0, Black.Sequence.MultiPlayer.SequenceMultiPlayerDebugTime.ObjectType, null, properties, 0, 1120);
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

            fieldProperties = new PropertyContainer("Black.Sequence.MultiPlayer.SequenceMultiPlayerDebugTime", base.GetFieldProperties(), 1666257076, 361097366);
            return fieldProperties;
        }

		
    }
}