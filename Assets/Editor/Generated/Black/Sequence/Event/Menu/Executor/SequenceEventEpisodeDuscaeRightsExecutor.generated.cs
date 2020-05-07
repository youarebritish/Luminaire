using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event.Menu.Executor
{
    public partial class SequenceEventEpisodeDuscaeRightsExecutor : Black.Sequence.Event.Menu.SequenceEventUiBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin piSwfStartFlow;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin pitOpenCaution;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin pitOpenSQEXLogo;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin poFinishedCaution;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin poFinishedSQEXLogo;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventEpisodeDuscaeRightsExecutor();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.Menu.Executor.SequenceEventEpisodeDuscaeRightsExecutor", 0, Black.Sequence.Event.Menu.Executor.SequenceEventEpisodeDuscaeRightsExecutor.ObjectType, null, properties, 0, 800);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.Menu.Executor.SequenceEventEpisodeDuscaeRightsExecutor", base.GetFieldProperties(), 26641139, 339148922);
            return fieldProperties;
        }

		
    }
}