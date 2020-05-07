using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Mobhunt
{
    public partial class SequenceActionMobhuntSetInfo : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin recieveIn_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin cancelIn_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin reportIn_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin cancelAllOtherDinerIn_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin startDirectonCameraOut_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin endDirectonCameraOut_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin valueCameraTypeOut_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin valueTargetOut_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin questMarkerPosValue_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin questMarkerRadiusValue_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin valueMobhuntFixId_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin valueQuestTargetId_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin valueDinnerIdToCancelOtherAll_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin successed_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin completed_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin notCompleted_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionMobhuntSetInfo();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Mobhunt.SequenceActionMobhuntSetInfo", 0, Black.Sequence.Action.Mobhunt.SequenceActionMobhuntSetInfo.ObjectType, null, properties, 0, 2040);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Mobhunt.SequenceActionMobhuntSetInfo", base.GetFieldProperties(), 657917288, 2116719094);
            return fieldProperties;
        }

		
    }
}