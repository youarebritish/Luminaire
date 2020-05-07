using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Render
{
    public partial class SequenceActionSetOceanDistanceField : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValue_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin visiblePin_;
		public bool visible_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetOceanDistanceField();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Render.SequenceActionSetOceanDistanceField", 0, Black.Sequence.Render.SequenceActionSetOceanDistanceField.ObjectType, null, properties, 0, 552);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Render.SequenceActionSetOceanDistanceField", base.GetFieldProperties(), -173775376, 1222790205);
            return fieldProperties;
        }

		
    }
}