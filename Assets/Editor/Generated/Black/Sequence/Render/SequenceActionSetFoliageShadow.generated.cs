using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Render
{
    public partial class SequenceActionSetFoliageShadow : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public int resolution_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetFoliageShadow();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Render.SequenceActionSetFoliageShadow", 0, Black.Sequence.Render.SequenceActionSetFoliageShadow.ObjectType, null, properties, 0, 376);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Render.SequenceActionSetFoliageShadow", base.GetFieldProperties(), -588486782, -1599484587);
            return fieldProperties;
        }

		
    }
}