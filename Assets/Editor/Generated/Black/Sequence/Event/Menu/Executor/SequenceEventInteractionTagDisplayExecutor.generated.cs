using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event.Menu.Executor
{
    public partial class SequenceEventInteractionTagDisplayExecutor : Black.Sequence.Event.Menu.SequenceEventUiEntityInputBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float parOfScreenWidth_;
		public float parOfScreenHeight_;
		public float parOfOffset_;
		public float keyinfoTime_;
		public uint keyinfoText_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventInteractionTagDisplayExecutor();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.Menu.Executor.SequenceEventInteractionTagDisplayExecutor", 0, Black.Sequence.Event.Menu.Executor.SequenceEventInteractionTagDisplayExecutor.ObjectType, null, properties, 0, 1160);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.Menu.Executor.SequenceEventInteractionTagDisplayExecutor", base.GetFieldProperties(), -1944185632, -857832745);
            
			fieldProperties.AddProperty(new Property("parOfScreenWidth_", 2764058536, "float", 1088, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("parOfScreenHeight_", 1473123695, "float", 1092, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("parOfOffset_", 2882525211, "float", 1096, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("keyinfoTime_", 2730666594, "float", 1100, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("keyinfoText_", 3024448200, "SQEX.Ebony.Std.Fixid", 1104, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}