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
            
			
			
			return fieldProperties;
        }

		
    }
}