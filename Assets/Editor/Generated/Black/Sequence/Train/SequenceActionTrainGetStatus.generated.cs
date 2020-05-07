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
            
			fieldProperties.AddProperty(new Property("inPinTrain_", 115407762, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 176, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outPinCurrentSpeed_", 162269743, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 264, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outPinElapsedTimeHr_", 840990206, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 352, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outPinElapsedTimeMin_", 2580691938, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 440, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outPinElapsedTimeSec_", 2694783053, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 528, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outPinTraveledDistance_", 2707850401, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 616, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outPinNumOfCarts_", 1469261731, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 704, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("reportType_", 1413702884, "Black.Sequence.Train.SequenceActionTrainGetStatus.StatusType", 792, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}