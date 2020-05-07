using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event.Menu.Executor
{
    public partial class SequenceEventEncountGaugeExecutor : Black.Sequence.Event.Menu.SequenceEventUiEntityInputBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin8_;
		public float offTimeAfterEncount_;
		public float posYRate_;
		public float posXOffset_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventEncountGaugeExecutor();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.Menu.Executor.SequenceEventEncountGaugeExecutor", 0, Black.Sequence.Event.Menu.Executor.SequenceEventEncountGaugeExecutor.ObjectType, null, properties, 0, 1544);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.Menu.Executor.SequenceEventEncountGaugeExecutor", base.GetFieldProperties(), 116588667, 1834846368);
            
			
			
			return fieldProperties;
        }

		
    }
}