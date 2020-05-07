using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Variable
{
    public partial class SequenceVariableSwfPlayerEntityBase : SQEX.Ebony.Framework.Sequence.SequenceVariable
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int pinNum_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValue_;
		public SQEX.Ebony.Framework.Entity.TransformEntity entityPointer_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceVariableSwfPlayerEntityBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Variable.SequenceVariableSwfPlayerEntityBase", 0, Black.Sequence.Variable.SequenceVariableSwfPlayerEntityBase.ObjectType, null, properties, 0, 192);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Variable.SequenceVariableSwfPlayerEntityBase", base.GetFieldProperties(), 1792760024, 219651554);
            
			
			
			return fieldProperties;
        }

		
    }
}