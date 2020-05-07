using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI
{
    public partial class SequenceActionAIStrongPointMove : Black.Sequence.Actor.AI.SequenceActionAIMoveBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValue;
		public float offsetAreaMin;
		public float offsetAreaMax;
		public float offsetNear;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin offsetNearPin;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin offsetAreaMinPin;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin offsetAreaMaxPin;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAIStrongPointMove();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.SequenceActionAIStrongPointMove", 0, Black.Sequence.Actor.AI.SequenceActionAIStrongPointMove.ObjectType, null, properties, 0, 1264);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.SequenceActionAIStrongPointMove", base.GetFieldProperties(), 923251673, 1836994667);
            
			
			
			return fieldProperties;
        }

		
    }
}