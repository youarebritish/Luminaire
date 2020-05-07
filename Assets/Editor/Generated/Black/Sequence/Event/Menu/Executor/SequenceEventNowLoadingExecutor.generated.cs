using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event.Menu.Executor
{
    public partial class SequenceEventNowLoadingExecutor : Black.Sequence.Event.Menu.SequenceEventUiEntityInputBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint nowLoadingMsgId_;
		public uint headLineMsgId_;
		public uint bodyMsgId_;
		public int maxloadedMegaByte_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventNowLoadingExecutor();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.Menu.Executor.SequenceEventNowLoadingExecutor", 0, Black.Sequence.Event.Menu.Executor.SequenceEventNowLoadingExecutor.ObjectType, null, properties, 0, 1232);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.Menu.Executor.SequenceEventNowLoadingExecutor", base.GetFieldProperties(), 1959148519, -1840514075);
            
			fieldProperties.AddProperty(new Property("nowLoadingMsgId_", 79533716, "SQEX.Ebony.Std.Fixid", 1088, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("headLineMsgId_", 3519527124, "SQEX.Ebony.Std.Fixid", 1092, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("bodyMsgId_", 409750240, "SQEX.Ebony.Std.Fixid", 1096, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("maxloadedMegaByte_", 3529952333, "unsigned int", 1100, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}