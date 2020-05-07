using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Train
{
    public partial class SequenceActionTrainBindActors : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inPinActors_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inPinTrain_;
		public int cartIndex_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTrainBindActors();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Train.SequenceActionTrainBindActors", 0, Black.Sequence.Train.SequenceActionTrainBindActors.ObjectType, null, properties, 0, 560);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Train.SequenceActionTrainBindActors", base.GetFieldProperties(), 764596007, -112794723);
            
			
			
			return fieldProperties;
        }

		
    }
}