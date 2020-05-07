using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event.Menu.Executor
{
    public partial class SequenceEventItemGetInfoDisplayExecutor : Black.Sequence.Event.Menu.SequenceEventUiEntityInputBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int textFieldMinimumWidth_;
		public int wndMargin_;
		public int wndHeight_;
		public int iconOffsetH_;
		public float timeItemGetDisplay_;
		public float timeGilGetStopAnime_;
		public float timeGilGetDisplay_;
		public float rapidRatio_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventItemGetInfoDisplayExecutor();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.Menu.Executor.SequenceEventItemGetInfoDisplayExecutor", 0, Black.Sequence.Event.Menu.Executor.SequenceEventItemGetInfoDisplayExecutor.ObjectType, null, properties, 0, 1416);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.Menu.Executor.SequenceEventItemGetInfoDisplayExecutor", base.GetFieldProperties(), 2072882609, 39258446);
            
			fieldProperties.AddProperty(new Property("textFieldMinimumWidth_", 86131775, "int", 1088, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("wndMargin_", 1471013567, "int", 1092, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("wndHeight_", 751797016, "int", 1096, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("iconOffsetH_", 264554458, "int", 1100, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("timeItemGetDisplay_", 1895039502, "float", 1104, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("timeGilGetStopAnime_", 1371032085, "float", 1108, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("timeGilGetDisplay_", 2157436691, "float", 1112, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rapidRatio_", 1693299181, "float", 1116, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}