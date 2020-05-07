using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.WorldMap
{
    public partial class SequenceActionSetHeightMapVisible : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin visible_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin invisible_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetHeightMapVisible();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.WorldMap.SequenceActionSetHeightMapVisible", 0, Black.Sequence.Action.WorldMap.SequenceActionSetHeightMapVisible.ObjectType, null, properties, 0, 464);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.WorldMap.SequenceActionSetHeightMapVisible", base.GetFieldProperties(), -707122739, 224525487);
            return fieldProperties;
        }

		
    }
}