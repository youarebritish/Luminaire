using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level.Nifl
{
    public partial class SequenceActionSetupSearchLight : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin lookAtTarget_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin shutdown_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin patrol_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin onVisible_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin onInvisible_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin partolPointGroupActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin searchLightActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin searchTargetActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin visible_;
		public uint joint_;
		public float lightRange_;
		public float lightAngle_;
		public bool relativePatrolPoint_;
		public bool checkObstacle_;
		public bool chasable_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetupSearchLight();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.Nifl.SequenceActionSetupSearchLight", 0, Black.Sequence.Action.Level.Nifl.SequenceActionSetupSearchLight.ObjectType, null, properties, 0, 1232);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.Nifl.SequenceActionSetupSearchLight", base.GetFieldProperties(), -330960430, -268148957);
            return fieldProperties;
        }

		
    }
}