using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.Physics
{
    public partial class SequenceActionActorBonamikWindControl : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin windEnablePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin windMultiplierPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin speedMultiplierPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin windRotationPin_;
		public Black.Entity.Data.Wind.BonamikWindEntity entityPointer_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outActor_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorBonamikWindControl();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.Physics.SequenceActionActorBonamikWindControl", 0, Black.Sequence.Action.Actor.Physics.SequenceActionActorBonamikWindControl.ObjectType, null, properties, 0, 824);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.Physics.SequenceActionActorBonamikWindControl", base.GetFieldProperties(), 1047133209, 78149078);
            return fieldProperties;
        }

		
    }
}