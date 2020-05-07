using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Tray
{
    public partial class AIGraphTrayMindTaskFSM : SQEX.Ebony.AIGraph.Tray.AIGraphTrayFSM
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

            var dummy = new AIGraphTrayMindTaskFSM();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Tray.AIGraphTrayMindTaskFSM", 0, Black.AIGraph.Extend.Tray.AIGraphTrayMindTaskFSM.ObjectType, null, properties, 0, 440);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Tray.AIGraphTrayMindTaskFSM", base.GetFieldProperties(), 1346227240, 1446934624);
            
			
			
			return fieldProperties;
        }

		
    }
}