using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence
{
    public partial class BlackSequenceContainer : SQEX.Ebony.Framework.Sequence.SequenceContainer
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BlackSequenceContainer();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.BlackSequenceContainer", 0, Black.Sequence.BlackSequenceContainer.ObjectType, Construct, properties, 0, 288);
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

            fieldProperties = new PropertyContainer("Black.Sequence.BlackSequenceContainer", base.GetFieldProperties(), -1269676789, -1741686273);
            
			fieldProperties.AddIndirectlyProperty(new Property("nodes_", 61650911, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Sequence.SequenceNode* >", 80, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			
			
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new BlackSequenceContainer();
        }
		
    }
}