using Black.Sequence.Actor;
using Ebony.Framework.Node;
using Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor
{
    public class SequneceActionActorSetMaterialFloatParameter : SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;

        public GraphTriggerInputPin in_ { get; set; } = new GraphTriggerInputPin();
        public GraphTriggerInputPin startIn_ { get; set; } = new GraphTriggerInputPin();
        public GraphTriggerInputPin stopIn_ { get; set; } = new GraphTriggerInputPin();
        public GraphVariableInputPin actor_ { get; set; } = new GraphVariableInputPin();
        public string materialName_ { get; set; }
        public string parameterName_ { get; set; }
        // TODO a bunch more

        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequneceActionActorSetMaterialFloatParameter();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.SequneceActionActorSetMaterialFloatParameter", 0, SequenceActionActorBase.ObjectType, Construct, properties, 1, 88);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.SequneceActionActorSetMaterialFloatParameter", base.GetFieldProperties(), -350090819, 195217920);
            fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 168, 1, 1, Property.PrimitiveType.ClassField, 0, (char)0));
            fieldProperties.AddProperty(new Property("startIn_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 168, 1, 1, Property.PrimitiveType.ClassField, 0, (char)0));
            fieldProperties.AddProperty(new Property("stopIn_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 168, 1, 1, Property.PrimitiveType.ClassField, 0, (char)0));
            fieldProperties.AddProperty(new Property("actor_", 1827225043, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 168, 1, 1, Property.PrimitiveType.ClassField, 0, (char)0));
            fieldProperties.AddProperty(new Property("materialName_", 1827225043, "Ebony.Base.String", 168, 1, 1, Property.PrimitiveType.String, 0, (char)0));
            fieldProperties.AddProperty(new Property("parameterName_", 1827225043, "Ebony.Base.String", 168, 1, 1, Property.PrimitiveType.String, 0, (char)0));
            return fieldProperties;
        }

        private static BaseObject Construct()
        {
            return new SequneceActionActorSetMaterialFloatParameter();
        }
    }
}
