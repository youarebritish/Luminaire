using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor
{
    public partial class SequenceVariableActorVector : Black.Sequence.Actor.SequenceVariableActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outZ_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outY_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outX_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin vector_;
		public int kind_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceVariableActorVector();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SequenceVariableActorVector", 0, Black.Sequence.Actor.SequenceVariableActorVector.ObjectType, null, properties, 0, 592);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SequenceVariableActorVector", base.GetFieldProperties(), 1145273089, 412994880);
            return fieldProperties;
        }

		
    }
}