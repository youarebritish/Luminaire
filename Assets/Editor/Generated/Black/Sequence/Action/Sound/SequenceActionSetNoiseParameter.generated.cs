using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Sound
{
    public partial class SequenceActionSetNoiseParameter : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin on_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin setBank_;
		public int noiseType_;
		public bool isWeather_;
		public int ambType_;
		public string plantFile_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin fadeIn_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin fadeOut_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin fadeZeroOne_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin volumePin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetNoiseParameter();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Sound.SequenceActionSetNoiseParameter", 0, Black.Sequence.Action.Sound.SequenceActionSetNoiseParameter.ObjectType, null, properties, 0, 848);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Sound.SequenceActionSetNoiseParameter", base.GetFieldProperties(), -1143489311, -257280931);
            return fieldProperties;
        }

		
    }
}