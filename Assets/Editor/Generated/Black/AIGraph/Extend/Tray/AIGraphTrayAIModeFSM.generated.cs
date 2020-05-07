using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Tray
{
    public partial class AIGraphTrayAIModeFSM : SQEX.Ebony.AIGraph.Tray.AIGraphTrayFSM
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid aiModeId;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid aiSubModeId;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphTrayAIModeFSM();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Tray.AIGraphTrayAIModeFSM", 0, Black.AIGraph.Extend.Tray.AIGraphTrayAIModeFSM.ObjectType, null, properties, 0, 304);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Tray.AIGraphTrayAIModeFSM", base.GetFieldProperties(), 1660628496, 1677008133);
            
			
			
			return fieldProperties;
        }

		
    }
}