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
            
			fieldProperties.AddProperty(new Property("inputPin_", 724407991, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 184, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("forwardSpeed_", 261973542, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 280, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("sideSpeed_", 2669446490, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 368, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("position_", 987254735, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 456, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rotation_", 36328192, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 544, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("attachWindAPreset_", 1689048311, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 632, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("attachWindBPreset_", 3345971016, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 728, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("attachWindCPreset_", 2020254377, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 824, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("attachWindDPreset_", 3272588378, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 920, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("attachWindEPreset_", 393009035, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1016, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("stopDefaultPreset_", 1015537334, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1112, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("actorPin_", 3381458010, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1208, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("multiplication_", 2895973060, "float", 1296, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("windRotationOffet_", 527353536, "Luminous.Math.VectorA", 1312, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("carSpeed_", 4043723865, "float", 1328, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("carPosition_", 2147036827, "Luminous.Math.VectorA", 1344, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("carRotation_", 3405730292, "Luminous.Math.VectorA", 1360, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}