using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.System
{
    public partial class SequenceActionAdvanceWorldTimer : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public int hour_;
		public int minute_;
		public int second_;
		public bool oneday_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin varSet_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin addTimePin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAdvanceWorldTimer();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.System.SequenceActionAdvanceWorldTimer", 0, Black.Sequence.Action.System.SequenceActionAdvanceWorldTimer.ObjectType, null, properties, 0, 568);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.System.SequenceActionAdvanceWorldTimer", base.GetFieldProperties(), 356705613, 1213056267);
            
			
			
			return fieldProperties;
        }

		
    }
}