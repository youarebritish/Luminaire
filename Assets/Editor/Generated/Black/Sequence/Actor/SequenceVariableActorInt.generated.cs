using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor
{
    public partial class SequenceVariableActorInt : Black.Sequence.Actor.SequenceVariableActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin int_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin setting_;
		public int kind_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceVariableActorInt();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SequenceVariableActorInt", 0, Black.Sequence.Actor.SequenceVariableActorInt.ObjectType, null, properties, 0, 416);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SequenceVariableActorInt", base.GetFieldProperties(), 1044245721, -2098420237);
            return fieldProperties;
        }

		
    }
}