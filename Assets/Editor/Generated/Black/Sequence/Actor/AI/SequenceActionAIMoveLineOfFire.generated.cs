using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI
{
    public partial class SequenceActionAIMoveLineOfFire : Black.Sequence.Actor.AI.SequenceActionAIMoveBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin baseActor;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin fireActor;
		public float offsetNear;
		public float distanceToBaseActorMin;
		public float distanceToBaseActorMax;
		public float giveUpFireOfLineLength;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin offsetNearPin;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin DistanceMinPin;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin DistanceMaxPin;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin GiveupLengthPin;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAIMoveLineOfFire();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.SequenceActionAIMoveLineOfFire", 0, Black.Sequence.Actor.AI.SequenceActionAIMoveLineOfFire.ObjectType, null, properties, 0, 1536);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.SequenceActionAIMoveLineOfFire", base.GetFieldProperties(), -633688306, 793507035);
            
			fieldProperties.AddProperty(new Property("baseActor", 3734764649, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 896, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("fireActor", 445230470, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 984, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("offsetNear", 3077841604, "float", 1072, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("distanceToBaseActorMin", 3046787709, "float", 1076, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("distanceToBaseActorMax", 3213283971, "float", 1080, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("giveUpFireOfLineLength", 3940705926, "float", 1084, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("offsetNearPin", 3811368499, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1088, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("DistanceMinPin", 3419088605, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1176, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("DistanceMaxPin", 40178195, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1264, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("GiveupLengthPin", 2383476440, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1352, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}