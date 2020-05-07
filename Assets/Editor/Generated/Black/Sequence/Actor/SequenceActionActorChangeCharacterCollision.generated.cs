using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor
{
    public partial class SequenceActionActorChangeCharacterCollision : Black.Sequence.Actor.SequenceActionActorStatusBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool isChangeCharCollision_;
		public uint charaColID_;
		public bool isChangeBGCollision_;
		public uint bgColID_;
		public bool isChangeVsLimsCollision_;
		public uint vsLimsColID_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorChangeCharacterCollision();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SequenceActionActorChangeCharacterCollision", 0, Black.Sequence.Actor.SequenceActionActorChangeCharacterCollision.ObjectType, null, properties, 0, 504);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SequenceActionActorChangeCharacterCollision", base.GetFieldProperties(), -598634211, -1027788611);
            return fieldProperties;
        }

		
    }
}