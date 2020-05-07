using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor
{
    public partial class SequenceActionActorCreateBase : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public bool isUseRayCheck_;
		public bool isForceCreateActor_EvenRayCheckNG_;
		public float upperRayOffset;
		public float lowerRayOffset;
		public bool isSameActorRayCheckNG_;
		public string baseActorName1_;
		public bool isHoldLODLevel_;
		public bool deleteActorsAtDestroy_;
		public bool setInactiveAtSpawn_;
		public bool setFadeAtSpawn_;
		public bool failAtNoResource_;
		public bool deleteWhenEnterTray_;
		public bool useSystemTime_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorCreateBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SequenceActionActorCreateBase", 0, Black.Sequence.Actor.SequenceActionActorCreateBase.ObjectType, null, properties, 0, 992);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SequenceActionActorCreateBase", base.GetFieldProperties(), 1975573413, -1594084743);
            
			
			
			return fieldProperties;
        }

		
    }
}