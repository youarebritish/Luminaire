using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AI.Ambient
{
    public partial class AmbientGroupDescriptionEntity : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public IList<Black.AI.Ambient.AmbientGroupMemberDescription> memberDescriptions_;
		public int maxMembers_;
		public int maxCount_;
		public uint steeringMoveArchetype_;
		public uint interactionGroupId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AmbientGroupDescriptionEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AI.Ambient.AmbientGroupDescriptionEntity", 0, Black.AI.Ambient.AmbientGroupDescriptionEntity.ObjectType, null, properties, 0, 104);
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

            fieldProperties = new PropertyContainer("Black.AI.Ambient.AmbientGroupDescriptionEntity", base.GetFieldProperties(), -115744571, -825519210);
            
			
			
			return fieldProperties;
        }

		
    }
}