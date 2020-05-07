using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor
{
    public partial class SequenceActionActorReportCollision : Black.Sequence.Actor.SequenceActionActorStatusBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool reportCollisions_;
		public float momentumThreshold_;
		public float momentumThreshold2_;
		public float speedThreshold_;
		public bool reportAttacks_;
		public float damageThreshold_;
		public bool filterReports_;
		public int filterType_;
		public int filterValue_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stop_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outSelfActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outSelfRigidBody_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outRigidBody_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outAttackerActor_;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> nameList_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorReportCollision();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SequenceActionActorReportCollision", 0, Black.Sequence.Actor.SequenceActionActorReportCollision.ObjectType, null, properties, 0, 1256);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SequenceActionActorReportCollision", base.GetFieldProperties(), 1168851474, -904202780);
            
			
			
			return fieldProperties;
        }

		
    }
}