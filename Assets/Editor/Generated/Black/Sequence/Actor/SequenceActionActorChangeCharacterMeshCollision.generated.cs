using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor
{
    public partial class SequenceActionActorChangeCharacterMeshCollision : Black.Sequence.Actor.SequenceActionActorStatusBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool isChangeCharCollision_;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> charaRemoveColIDs_;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> charaColIDs_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorChangeCharacterMeshCollision();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SequenceActionActorChangeCharacterMeshCollision", 0, Black.Sequence.Actor.SequenceActionActorChangeCharacterMeshCollision.ObjectType, null, properties, 0, 520);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SequenceActionActorChangeCharacterMeshCollision", base.GetFieldProperties(), 1195346597, -1418678337);
            return fieldProperties;
        }

		
    }
}