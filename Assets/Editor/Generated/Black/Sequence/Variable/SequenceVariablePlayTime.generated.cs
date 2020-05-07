using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Variable
{
    public partial class SequenceVariablePlayTime : SQEX.Ebony.Framework.Sequence.SequenceVariable
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin offset_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin minute_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin second_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceVariablePlayTime();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Variable.SequenceVariablePlayTime", 0, Black.Sequence.Variable.SequenceVariablePlayTime.ObjectType, null, properties, 0, 360);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Variable.SequenceVariablePlayTime", base.GetFieldProperties(), 320853923, -1976797203);
            
			
			
			return fieldProperties;
        }

		
    }
}