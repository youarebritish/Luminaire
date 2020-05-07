using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.WorldMap
{
    public partial class SequenceActionSetFoliageLODScale : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin enable_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin disable_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public int type_;
		public float scale_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetFoliageLODScale();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.WorldMap.SequenceActionSetFoliageLODScale", 0, Black.Sequence.Action.WorldMap.SequenceActionSetFoliageLODScale.ObjectType, null, properties, 0, 472);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.WorldMap.SequenceActionSetFoliageLODScale", base.GetFieldProperties(), 2124139937, -1611897732);
            return fieldProperties;
        }

		
    }
}