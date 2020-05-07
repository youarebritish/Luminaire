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
            
			
			
			fieldProperties.AddProperty(new Property("fromNodeIdx_", 2810996701, "int", 16, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("toNodeIdx_", 4019214144, "int", 20, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("conditionIdxInContainerCache_", 2320057898, "int", 24, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("hasRequiresCanStartNextCalculationFlag_", 3186666552, "bool", 28, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("requiresCanStartNextCalculation_", 3126083940, "bool", 29, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("bDebugLog_", 3022397583, "bool", 30, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("bDebugConditionWatch_", 187318605, "bool", 31, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}