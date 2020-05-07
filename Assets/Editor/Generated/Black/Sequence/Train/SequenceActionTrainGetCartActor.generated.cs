using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Train
{
    public partial class SequenceActionTrainGetCartActor : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inPinCartIndex_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inPinTrain_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outPinCart_;
		public int cartIndex_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTrainGetCartActor();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Train.SequenceActionTrainGetCartActor", 0, Black.Sequence.Train.SequenceActionTrainGetCartActor.ObjectType, null, properties, 0, 656);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Train.SequenceActionTrainGetCartActor", base.GetFieldProperties(), 1631003285, -1752280751);
            return fieldProperties;
        }

		
    }
}