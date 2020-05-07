using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Control.Struct
{
    public partial class ConditionData : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int Operator;
		public string expression_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ConditionData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Control.Struct.ConditionData", 0, Black.Sequence.Control.Struct.ConditionData.ObjectType, null, properties, 0, 64);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Control.Struct.ConditionData", base.GetFieldProperties(), -1453046010, 871669093);
            return fieldProperties;
        }

		
    }
}