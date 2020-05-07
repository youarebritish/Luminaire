using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor
{
    public partial class SequenceActionActorSmartChangeVisible : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin activate_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin deactivate_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin on_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin off_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finished_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValue_;
		public bool changeWithTrigger_;
		public bool changeWithWeather_;
		public bool changeWithTime_;
		public bool onWeatherFlag_;
		public int onTimeHour_;
		public bool offWeatherFlag_;
		public int offTimeHour_;
		public bool changeAtViewRangeOut_;
		public bool offPriorityHigher_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorSmartChangeVisible();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SequenceActionActorSmartChangeVisible", 0, Black.Sequence.Actor.SequenceActionActorSmartChangeVisible.ObjectType, null, properties, 0, 920);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SequenceActionActorSmartChangeVisible", base.GetFieldProperties(), -19328962, -1654770613);
            return fieldProperties;
        }

		
    }
}