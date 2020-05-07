using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.AI.Nifl
{
    public partial class SequenceActionAILureCharacter : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin baseActor_;
		public float luarRadius_;
		public float ThrowingDistance_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAILureCharacter();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.AI.Nifl.SequenceActionAILureCharacter", 0, Black.Sequence.Action.Actor.AI.Nifl.SequenceActionAILureCharacter.ObjectType, null, properties, 0, 496);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.AI.Nifl.SequenceActionAILureCharacter", base.GetFieldProperties(), 830753679, 1804057122);
            return fieldProperties;
        }

		
    }
}