using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity
{
    public partial class ActorEntity : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string charaEntry_;
		public bool setInactiveAtSpawn_;
		public bool setFadeAtSpawn_;
		public bool isHideInitialForScript_;
		public bool isHideInitial_;
		public float scaling_;
		public uint overwriteParameterID_;
		public string sourcePathAI_;
		public string sourcePathAIGraph_;
		public int actorType_;
		public uint overwriteInteractionParamId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ActorEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.ActorEntity", 0, Black.Entity.ActorEntity.ObjectType, null, properties, 0, 352);
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

            fieldProperties = new PropertyContainer("Black.Entity.ActorEntity", base.GetFieldProperties(), 1896381988, 1070462923);
            return fieldProperties;
        }

		
    }
}