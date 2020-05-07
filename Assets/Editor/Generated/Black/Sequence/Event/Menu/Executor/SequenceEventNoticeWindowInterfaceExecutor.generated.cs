using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event.Menu.Executor
{
    public partial class SequenceEventNoticeWindowInterfaceExecutor : Black.Sequence.Event.Menu.SequenceEventUiBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint areaId_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin pitEnqueInfo;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventNoticeWindowInterfaceExecutor();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.Menu.Executor.SequenceEventNoticeWindowInterfaceExecutor", 0, Black.Sequence.Event.Menu.Executor.SequenceEventNoticeWindowInterfaceExecutor.ObjectType, null, properties, 0, 400);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.Menu.Executor.SequenceEventNoticeWindowInterfaceExecutor", base.GetFieldProperties(), -431226100, 1186973012);
            
			fieldProperties.AddIndirectlyProperty(new Property("refInPorts_", 1035088696, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 24, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("refOutPorts_", 283683627, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 40, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triInPorts_", 291734708, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 96, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triOutPorts_", 3107891487, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 112, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("outPin_", 2732252299, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outPin_.pinName_", 1767361694, "Base.String", 184, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outPin_.name_", 2948420441, "Base.String", 200, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outPin_.connections_", 78281129, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 216, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("outPin_.delayType_", 2315115539, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 248, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outPin_.delayTime_", 2421045752, "float", 252, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outPin_.delayMaxTime_", 3973394610, "float", 256, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pitEnqueInfo.pinName_", 1056754505, "Base.String", 312, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pitEnqueInfo.name_", 225106004, "Base.String", 328, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pitEnqueInfo.connections_", 1372870058, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 344, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("pitEnqueInfo.delayType_", 1975588632, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 376, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pitEnqueInfo.delayTime_", 824141907, "float", 380, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pitEnqueInfo.delayMaxTime_", 3216643147, "float", 384, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("areaId_", 3443565698, "SQEX.Ebony.Std.Fixid", 296, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("pitEnqueInfo", 3288104750, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 304, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}