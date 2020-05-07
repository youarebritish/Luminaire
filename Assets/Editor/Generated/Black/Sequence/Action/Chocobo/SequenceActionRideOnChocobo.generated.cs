using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Chocobo
{
    public partial class SequenceActionRideOnChocobo : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stop_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finish_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin failed_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin chocoboActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin riderActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin cameraNoPin_;
		public bool motionSkip_;
		public bool disableRideOff_;
		public bool invisibleUI_;
		public bool setRiderPosition_;
		public bool playMusic_;
		public uint paramId_;
		public uint massageId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionRideOnChocobo();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Chocobo.SequenceActionRideOnChocobo", 0, Black.Sequence.Action.Chocobo.SequenceActionRideOnChocobo.ObjectType, null, properties, 0, 960);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Chocobo.SequenceActionRideOnChocobo", base.GetFieldProperties(), 1655406715, -423415140);
            return fieldProperties;
        }

		
    }
}