using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event.Menu.Executor
{
    public partial class SequenceEventEpisodeDuscaeTitleExecutor : Black.Sequence.Event.Menu.SequenceEventUiEntityInputBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin open_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin closed_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin new_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin newplus_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin continue_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin option_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin debug_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventEpisodeDuscaeTitleExecutor();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.Menu.Executor.SequenceEventEpisodeDuscaeTitleExecutor", 0, Black.Sequence.Event.Menu.Executor.SequenceEventEpisodeDuscaeTitleExecutor.ObjectType, null, properties, 0, 1864);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.Menu.Executor.SequenceEventEpisodeDuscaeTitleExecutor", base.GetFieldProperties(), -596657853, 1137664461);
            
			
			
			return fieldProperties;
        }

		
    }
}