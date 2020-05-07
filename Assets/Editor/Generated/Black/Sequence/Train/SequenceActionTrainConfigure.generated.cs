using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Train
{
    public partial class SequenceActionTrainConfigure : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inPinTrain_;
		public bool toConfigNavigation_;
		public bool autoFindNextCurve_;
		public int timerType_;
		public bool toConfigRoll_;
		public float rollMaxDegree_;
		public float rollScale_;
		public float rollAngularSpeed_;
		public float rollSmoothingCoeff_;
		public bool toConfigVibration_;
		public float vibrationMaxX_;
		public float vibrationMaxY_;
		public float vibrationFreq_;
		public float vibrationDuration_;
		public bool toConfigSimMovingPlat_;
		public bool smpEnableAsConnectionPortActor_;
		public bool toConfigOffsetOverRail_;
		public float offsetOverRailVertical_;
		public float offsetOverRailHorizontal_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTrainConfigure();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Train.SequenceActionTrainConfigure", 0, Black.Sequence.Train.SequenceActionTrainConfigure.ObjectType, null, properties, 0, 520);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Train.SequenceActionTrainConfigure", base.GetFieldProperties(), -1603701930, -153223531);
            return fieldProperties;
        }

		
    }
}