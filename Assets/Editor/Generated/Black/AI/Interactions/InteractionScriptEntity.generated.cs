using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AI.Interactions
{
    public partial class InteractionScriptEntity : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string interactionFile_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InteractionScriptEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AI.Interactions.InteractionScriptEntity", 0, Black.AI.Interactions.InteractionScriptEntity.ObjectType, null, properties, 0, 136);
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

            fieldProperties = new PropertyContainer("Black.AI.Interactions.InteractionScriptEntity", base.GetFieldProperties(), 1889800525, 1610400213);
            
			fieldProperties.AddProperty(new Property("interactionFile_", 1831334318, "SQEX.Ebony.Base.String", 112, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}