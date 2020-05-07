using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Variable
{
    public partial class SequenceConstVector : SQEX.Ebony.Framework.Sequence.SequenceVariable
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outZ_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outY_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outX_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin out_;
		public UnityEngine.Vector4 value_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceConstVector();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Variable.SequenceConstVector", 0, SQEX.Ebony.Framework.Sequence.Variable.SequenceConstVector.ObjectType, null, properties, 0, 464);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Variable.SequenceConstVector", base.GetFieldProperties(), -408846269, -917482080);
            
			
			
			return fieldProperties;
        }

		
    }
}