using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Luminous.MultiPlayer.Matching.Client
{
    public partial class LobbyModuleOriginal : SQEX.Luminous.MultiPlayer.Matching.Client.LobbyModuleBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new LobbyModuleOriginal();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Luminous.MultiPlayer.Matching.Client.LobbyModuleOriginal", 0, SQEX.Luminous.MultiPlayer.Matching.Client.LobbyModuleOriginal.ObjectType, null, properties, 23, 18080);
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

            fieldProperties = new PropertyContainer("SQEX.Luminous.MultiPlayer.Matching.Client.LobbyModuleOriginal", base.GetFieldProperties(), -1085732041, 46017319);
            
			
			
			
			
			return fieldProperties;
        }

		
    }
}