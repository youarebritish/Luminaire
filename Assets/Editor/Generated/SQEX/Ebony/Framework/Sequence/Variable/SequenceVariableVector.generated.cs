using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Variable
{
    public partial class SequenceVariableVector : SQEX.Ebony.Framework.Sequence.SequenceVariable
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin setX_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin setY_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin setZ_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin set_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin getX_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin getY_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin getZ_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin get_;
		public UnityEngine.Vector4 value_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceVariableVector();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Variable.SequenceVariableVector", 0, SQEX.Ebony.Framework.Sequence.Variable.SequenceVariableVector.ObjectType, null, properties, 0, 816);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Variable.SequenceVariableVector", base.GetFieldProperties(), 745041034, -1626626706);
            return fieldProperties;
        }

		
    }
}