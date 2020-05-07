using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Tray
{
    public partial class AIGraphTrayMindTaskBT : SQEX.Ebony.AIGraph.Tray.AIGraphTrayBT
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid id;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt priority;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat timeoutTime;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat waitTime;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool isEnableWait;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool bResetMindLayer;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool bSuspendMindLayer;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphTrayMindTaskBT();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Tray.AIGraphTrayMindTaskBT", 0, Black.AIGraph.Extend.Tray.AIGraphTrayMindTaskBT.ObjectType, null, properties, 0, 408);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Tray.AIGraphTrayMindTaskBT", base.GetFieldProperties(), -484639643, 1193611310);
            return fieldProperties;
        }

		
    }
}