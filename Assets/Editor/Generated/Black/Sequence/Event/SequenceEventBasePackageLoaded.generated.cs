using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event
{
    public partial class SequenceEventBasePackageLoaded : SQEX.Ebony.Framework.Sequence.SequenceEvent
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventBasePackageLoaded();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.SequenceEventBasePackageLoaded", 0, Black.Sequence.Event.SequenceEventBasePackageLoaded.ObjectType, null, properties, 0, 272);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.SequenceEventBasePackageLoaded", base.GetFieldProperties(), 642306183, 19696347);
            return fieldProperties;
        }

		
    }
}