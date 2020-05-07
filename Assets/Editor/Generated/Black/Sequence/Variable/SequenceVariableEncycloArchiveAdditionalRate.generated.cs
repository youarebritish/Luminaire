using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Variable
{
    public partial class SequenceVariableEncycloArchiveAdditionalRate : SQEX.Ebony.Framework.Sequence.SequenceVariable
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin rate_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin percentage_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin openNum_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin itemNum_;
		public int categoryType_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceVariableEncycloArchiveAdditionalRate();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Variable.SequenceVariableEncycloArchiveAdditionalRate", 0, Black.Sequence.Variable.SequenceVariableEncycloArchiveAdditionalRate.ObjectType, null, properties, 0, 448);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Variable.SequenceVariableEncycloArchiveAdditionalRate", base.GetFieldProperties(), 915725436, 1452787688);
            
			
			
			return fieldProperties;
        }

		
    }
}