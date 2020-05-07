using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Action
{
    public partial class SequenceActionSetVariableWithProperty : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin varGet_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin varRandomMin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin varRandomMax_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin varSet_;
		public int type_;
		public bool boolValue_;
		public int intValue_;
		public float floatValue_;
		public UnityEngine.Vector4 vectorValue_;
		public string stringValue_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData fixidValue_;
		public bool isRandom_;
		public float randomMin_;
		public float randomMax_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetVariableWithProperty();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Action.SequenceActionSetVariableWithProperty", 0, SQEX.Ebony.Framework.Sequence.Action.SequenceActionSetVariableWithProperty.ObjectType, null, properties, 0, 800);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Action.SequenceActionSetVariableWithProperty", base.GetFieldProperties(), 404866112, 452795759);
            return fieldProperties;
        }

		
    }
}