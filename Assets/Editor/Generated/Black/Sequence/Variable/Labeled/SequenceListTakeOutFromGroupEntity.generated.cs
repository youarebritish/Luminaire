using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Variable.Labeled
{
    public partial class SequenceListTakeOutFromGroupEntity : SQEX.Ebony.Framework.Sequence.SequenceVariable
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin entityGroup_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin list_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin listCount_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceListTakeOutFromGroupEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Variable.Labeled.SequenceListTakeOutFromGroupEntity", 0, Black.Sequence.Variable.Labeled.SequenceListTakeOutFromGroupEntity.ObjectType, null, properties, 0, 352);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Variable.Labeled.SequenceListTakeOutFromGroupEntity", base.GetFieldProperties(), 1238437352, 1690042285);
            
			
			
			return fieldProperties;
        }

		
    }
}