using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Train
{
    public partial class SequenceActionTrainGetStatus : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inPinTrain_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outPinCurrentSpeed_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outPinElapsedTimeHr_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outPinElapsedTimeMin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outPinElapsedTimeSec_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outPinTraveledDistance_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outPinNumOfCarts_;
		public int reportType_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTrainGetStatus();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Train.SequenceActionTrainGetStatus", 0, Black.Sequence.Train.SequenceActionTrainGetStatus.ObjectType, null, properties, 0, 808);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Train.SequenceActionTrainGetStatus", base.GetFieldProperties(), -1484070007, 938564665);
            return fieldProperties;
        }

		
    }
}