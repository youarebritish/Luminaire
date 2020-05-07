using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Data
{
    public partial class ConditionData : SQEX.Luminous.Core.Object.Object
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int type_;
		public string condition_;
		public string compiledCondition_;
		public int conditionIdxInContainerCache_;
		public bool bDebugLog_;
		public bool bDebugConditionWatch_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ConditionData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Data.ConditionData", 0, SQEX.Ebony.AIGraph.Data.ConditionData.ObjectType, null, properties, 0, 64);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Data.ConditionData", base.GetFieldProperties(), 286990604, 480872431);
            return fieldProperties;
        }

		
    }
}