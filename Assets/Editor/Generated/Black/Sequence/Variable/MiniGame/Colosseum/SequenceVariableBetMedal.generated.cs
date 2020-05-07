using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Variable.MiniGame.Colosseum
{
    public partial class SequenceVariableBetMedal : SQEX.Ebony.Framework.Sequence.SequenceVariable
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin medalPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin setMedalPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceVariableBetMedal();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Variable.MiniGame.Colosseum.SequenceVariableBetMedal", 0, Black.Sequence.Variable.MiniGame.Colosseum.SequenceVariableBetMedal.ObjectType, null, properties, 0, 264);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Variable.MiniGame.Colosseum.SequenceVariableBetMedal", base.GetFieldProperties(), 930038787, 250359591);
            return fieldProperties;
        }

		
    }
}