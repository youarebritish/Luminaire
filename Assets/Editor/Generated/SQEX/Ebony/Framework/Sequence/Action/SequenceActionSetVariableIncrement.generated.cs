using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Action
{
    public partial class SequenceActionSetVariableIncrement : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inIntValue_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inFloatValue_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outIntValue_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outFloatValue_;
		public int type_;
		public int addIntValue_;
		public float addFloatValue_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetVariableIncrement();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Action.SequenceActionSetVariableIncrement", 0, SQEX.Ebony.Framework.Sequence.Action.SequenceActionSetVariableIncrement.ObjectType, null, properties, 0, 736);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Action.SequenceActionSetVariableIncrement", base.GetFieldProperties(), 1560248701, 219381274);
            
			
			
			return fieldProperties;
        }

		
    }
}