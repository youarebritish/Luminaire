using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.MiniGame.Colosseum
{
    public partial class SequenceActionColosseumGetGroupInformation : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin groupIdPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin listNumberPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin standbyAnmMessageIdPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionColosseumGetGroupInformation();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.MiniGame.Colosseum.SequenceActionColosseumGetGroupInformation", 0, Black.Sequence.Action.MiniGame.Colosseum.SequenceActionColosseumGetGroupInformation.ObjectType, null, properties, 0, 632);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.MiniGame.Colosseum.SequenceActionColosseumGetGroupInformation", base.GetFieldProperties(), -876184409, -237211529);
            
			
			
			return fieldProperties;
        }

		
    }
}