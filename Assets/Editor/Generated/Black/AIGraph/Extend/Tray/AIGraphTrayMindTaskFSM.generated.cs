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
            
			fieldProperties.AddProperty(new Property("id", 926444256, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid", 208, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("priority", 2498028297, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt", 240, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("timeoutTime", 350021985, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 272, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("waitTime", 1213593401, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 304, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isEnableWait", 2233842355, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 336, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("bResetMindLayer", 772950909, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 368, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("bSuspendMindLayer", 310129772, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 400, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}