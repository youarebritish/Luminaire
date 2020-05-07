using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Variable
{
    public partial class SequenceVariableWorldTimer : SQEX.Ebony.Framework.Sequence.SequenceVariable
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin setting_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin dayTime_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin hourFloat_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin days_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin hour_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin minute_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin second_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin enabled_;
		public bool passingDay2_;
		public bool instantUpdate2_;
		public bool passingDay_;
		public bool instantUpdate_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceVariableWorldTimer();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Variable.SequenceVariableWorldTimer", 0, Black.Sequence.Variable.SequenceVariableWorldTimer.ObjectType, null, properties, 0, 800);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Variable.SequenceVariableWorldTimer", base.GetFieldProperties(), 1453084361, 2015127957);
            
			
			
			return fieldProperties;
        }

		
    }
}