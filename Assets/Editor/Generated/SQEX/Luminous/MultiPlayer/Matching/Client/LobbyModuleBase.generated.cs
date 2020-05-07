using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Luminous.MultiPlayer.Matching.Client
{
    public partial class LobbyModuleBase : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new LobbyModuleBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Luminous.MultiPlayer.Matching.Client.LobbyModuleBase", 0, SQEX.Luminous.MultiPlayer.Matching.Client.LobbyModuleBase.ObjectType, null, properties, 22, 18080);
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

            fieldProperties = new PropertyContainer("SQEX.Luminous.MultiPlayer.Matching.Client.LobbyModuleBase", base.GetFieldProperties(), 208366774, -1031848151);
            return fieldProperties;
        }

		
    }
}