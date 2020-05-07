using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.MultiPlayer
{
    public partial class SequenceMultiPlayerOffsetTime : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueTime_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueOffset_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueWithoutSecond_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueYear_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueMonth_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueDay_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueHour_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueMinute_;
		public int offset_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceMultiPlayerOffsetTime();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.MultiPlayer.SequenceMultiPlayerOffsetTime", 0, Black.Sequence.MultiPlayer.SequenceMultiPlayerOffsetTime.ObjectType, null, properties, 0, 888);
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

            fieldProperties = new PropertyContainer("Black.Sequence.MultiPlayer.SequenceMultiPlayerOffsetTime", base.GetFieldProperties(), -1529187382, -304776486);
            
			
			
			return fieldProperties;
        }

		
    }
}