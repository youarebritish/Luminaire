using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.Physics
{
    public partial class SequenceActionActorBonamikWindPresetControl : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inputPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin forwardSpeed_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sideSpeed_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin position_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rotation_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin attachWindAPreset_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin attachWindBPreset_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin attachWindCPreset_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin attachWindDPreset_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin attachWindEPreset_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stopDefaultPreset_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actorPin_;
		public float multiplication_;
		public UnityEngine.Vector4 windRotationOffet_;
		public float carSpeed_;
		public UnityEngine.Vector4 carPosition_;
		public UnityEngine.Vector4 carRotation_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorBonamikWindPresetControl();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.Physics.SequenceActionActorBonamikWindPresetControl", 0, Black.Sequence.Action.Actor.Physics.SequenceActionActorBonamikWindPresetControl.ObjectType, null, properties, 0, 1376);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.Physics.SequenceActionActorBonamikWindPresetControl", base.GetFieldProperties(), -1598495682, 110508497);
            return fieldProperties;
        }

		
    }
}