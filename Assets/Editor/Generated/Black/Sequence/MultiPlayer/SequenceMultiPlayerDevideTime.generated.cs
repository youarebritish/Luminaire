using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.MultiPlayer
{
    public partial class SequenceMultiPlayerDevideTime : SQEX.Ebony.Framework.Sequence.SequenceVariable
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueDevidedTimePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueYearPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueMonthPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueDayPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueHourMinutePin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceMultiPlayerDevideTime();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.MultiPlayer.SequenceMultiPlayerDevideTime", 0, Black.Sequence.MultiPlayer.SequenceMultiPlayerDevideTime.ObjectType, null, properties, 0, 552);
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

            fieldProperties = new PropertyContainer("Black.Sequence.MultiPlayer.SequenceMultiPlayerDevideTime", base.GetFieldProperties(), 1018948722, -1375985337);
            
			
			
			return fieldProperties;
        }

		
    }
}