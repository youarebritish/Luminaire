using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Tray
{
    public partial class AIGraphTrayAIModeBT : SQEX.Ebony.AIGraph.Tray.AIGraphTrayBT
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

            var dummy = new AIGraphTrayAIModeBT();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Tray.AIGraphTrayAIModeBT", 0, Black.AIGraph.Extend.Tray.AIGraphTrayAIModeBT.ObjectType, null, properties, 0, 272);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Tray.AIGraphTrayAIModeBT", base.GetFieldProperties(), 899296779, 643128411);
            return fieldProperties;
        }

		
    }
}