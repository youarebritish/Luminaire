using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI.Corps
{
    public partial class SequenceVariableLabeledCorps : Black.Sequence.Actor.SequenceVariableLabeledActor
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin teamCount_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin corpsRoll_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin rollArgument_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceVariableLabeledCorps();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.Corps.SequenceVariableLabeledCorps", 0, Black.Sequence.Actor.AI.Corps.SequenceVariableLabeledCorps.ObjectType, null, properties, 0, 1224);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.Corps.SequenceVariableLabeledCorps", base.GetFieldProperties(), -1596699249, 1965368221);
            return fieldProperties;
        }

		
    }
}