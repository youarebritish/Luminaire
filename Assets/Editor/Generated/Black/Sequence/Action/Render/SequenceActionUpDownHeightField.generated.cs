using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Render
{
    public partial class SequenceActionUpDownHeightField : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public UnityEngine.Vector4 position_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin positionPin_;
		public float radius_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin radiusPin_;
		public float attenuation_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin attenuationPin_;
		public float power_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin powerPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionUpDownHeightField();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Render.SequenceActionUpDownHeightField", 0, Black.Sequence.Action.Render.SequenceActionUpDownHeightField.ObjectType, null, properties, 0, 768);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Render.SequenceActionUpDownHeightField", base.GetFieldProperties(), -344213967, 478979189);
            return fieldProperties;
        }

		
    }
}