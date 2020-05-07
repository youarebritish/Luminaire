using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Data
{
    public partial class TransitionData : SQEX.Luminous.Core.Object.Object
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int fromNodeIdx_;
		public int toNodeIdx_;
		public int conditionIdxInContainerCache_;
		public bool hasRequiresCanStartNextCalculationFlag_;
		public bool requiresCanStartNextCalculation_;
		public bool bDebugLog_;
		public bool bDebugConditionWatch_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new TransitionData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Data.TransitionData", 0, SQEX.Ebony.AIGraph.Data.TransitionData.ObjectType, null, properties, 0, 56);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Data.TransitionData", base.GetFieldProperties(), -654322719, 150703589);
            
			
			
			return fieldProperties;
        }

		
    }
}