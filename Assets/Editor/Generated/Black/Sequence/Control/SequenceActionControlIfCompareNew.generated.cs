using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Control
{
    public partial class SequenceActionControlIfCompareNew : SQEX.Ebony.Framework.Sequence.Control.SequenceControl
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin value_;
		public IList<Black.Sequence.Control.Struct.ConditionCollectionData> data_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionControlIfCompareNew();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Control.SequenceActionControlIfCompareNew", 0, Black.Sequence.Control.SequenceActionControlIfCompareNew.ObjectType, null, properties, 0, 408);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Control.SequenceActionControlIfCompareNew", base.GetFieldProperties(), -1744682622, -678556455);
            return fieldProperties;
        }

		
    }
}